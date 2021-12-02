using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADMatricula
    {

        #region Atributos
        private string _cadenaConexion;
        private string _mensaje;
        #endregion

        #region Propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        #endregion

        #region Constructor

        public ADMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public double calcularCostos(decimal descuentoEstudiante, List<MateriasAbiertas> materias, ref double subtotal, ref double montoDescuentoE, ref double montoIVA, double montoMatricula)
        {
            double totalPagar = 0;

            for (int i = 0; i < materias.Count; i++)
            {
                totalPagar += Convert.ToDouble(materias[i].Costo);
            }

            //for (int i = 0; i < materias.Tables[0].Rows.Count; i++)
            //{
            //    totalPagar += Convert.ToDouble(materias.Tables[0].Rows[0]["Costo"]); //sino hagalo con el dataset
            //}


            subtotal = totalPagar + montoMatricula;

            montoDescuentoE = subtotal * (Convert.ToDouble(descuentoEstudiante));//se calcula el descuento
            montoIVA = subtotal * 0.02; //se calcula el iva
            totalPagar = subtotal - montoDescuentoE;//se aplica el descuento
            totalPagar += montoIVA; //se aplica el impuesto Iva

            return totalPagar;

        }

        public int Insertar(Matricula matriculaE, int codMateriaA, int numeroFactura) //funciona tanto para matricular como para modificar la matricula
        {
            int resultado;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_INSERTARMATRICULA"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@carnetEstudiante", matriculaE.CarnetEstudiante.CarnetEstudiante);
            comando.Parameters.AddWithValue("@fechaMatricula", Convert.ToDateTime(matriculaE.FechaMatricula));
            comando.Parameters.AddWithValue("@montoMatricula", Convert.ToDecimal(matriculaE.MontoMatricula));
            comando.Parameters.AddWithValue("@tipoPago", matriculaE.TipoPago);
            comando.Parameters.AddWithValue("@codMateriaA", codMateriaA);
            comando.Parameters.AddWithValue("@numeroFactura", numeroFactura);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@numFactura", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@numFactura"].Value); //obtengo la variable de retorno
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado; //devuelve el numerodeFactura

        }


        public DataSet ListarMatriculas(string condicion)
        {  //devuelve un dataset de MateriasCarreras para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select NumFactura,E.CarnetEstudiante,E.IdEstudiante, " +
                               "concat(E.NombreEstudiante, ' ', Apellido1Estudiante, ' ', Apellido2Estudiante) as 'NombreEstudiante'" +
                               ",FechaMatricula,MontoMatricula,TipoPago from TBL_Matriculas M inner join TBL_Estudiantes E on " +
                               " E.CarnetEstudiante = m.CarnetEstudiante where EstadoFactura = 'PEN'"; //solo recupera las matriculas pendientes

            if (!string.IsNullOrEmpty(condicion))
            { //si la condicion no esta vacia entonces concatene esa condicion a la sentencia
                sentencia = string.Format("{0} and {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Matriculas");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }

        public Matricula ObtenerMatricula(int numFactura)
        { //devuelve una matricula
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            Matricula matriculaAlumno = new Matricula();
            matriculaAlumno.CarnetEstudiante = new Estudiantes();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute
            string sentencia = string.Format("select NumFactura, M.CarnetEstudiante,E.IdEstudiante," +
                                             "CONCAT(e.NombreEstudiante, ' ', e.Apellido1Estudiante, ' ', e.Apellido2Estudiante) as 'NombreEstudiante'" +
                                             ",E.CorreoEstudiante,e.Descuento,FechaMatricula,MontoMatricula,TipoPago from TBL_Matriculas M inner join " +
                                             " TBL_Estudiantes E on M.CarnetEstudiante = E.CarnetEstudiante where NumFactura = {0}", numFactura);//si el id fuera texto se debe poner el 0 entre comillas asi '{0}' dentro del string
            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    matriculaAlumno.NumeroFactura = dataReader.GetInt32(0);//esta columna es de tipo integer y esta en la posicion 0
                    matriculaAlumno.CarnetEstudiante.CarnetEstudiante = dataReader.GetString(1);
                    matriculaAlumno.CarnetEstudiante.Cedula = dataReader.GetString(2);
                    matriculaAlumno.CarnetEstudiante.Nombre = dataReader.GetString(3);
                    if (!dataReader.IsDBNull(4))
                    {
                        matriculaAlumno.CarnetEstudiante.CorreoElectronico = dataReader.GetString(4);
                    }
                    if (!dataReader.IsDBNull(5))
                    {
                        matriculaAlumno.CarnetEstudiante.Descuento = dataReader.GetInt32(5);
                    }
                    matriculaAlumno.FechaMatricula = dataReader.GetDateTime(6);
                    matriculaAlumno.MontoMatricula = dataReader.GetDecimal(7);
                    matriculaAlumno.TipoPago = dataReader.GetString(8);
                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return matriculaAlumno;

        }

        public DataSet ListarMateriasMatriculadas(int numFactura)
        {  //devuelve un dataset de MateriasAbiertas que el estudiante matriculó para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = string.Format("SELECT CodMateriaAbierta,CodigoMateria,NombreMateria,Requisito,nombreRequisito,nombreProfesor,NumeroAula,Grupo,Costo " +
                                             " FROM CONSULTA_MATERIAS_MATRICULADAS WHERE NumFactura = {0}", numFactura);
            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Materias Matriculadas");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }


        public int EliminarMateriasEscogidas(int numFactura, int codMateriaAbierta)
        {
            int resultado;


            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_ELIMINAR_MATERIAS_ESCOGIDAS"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@numFactura", numFactura);
            comando.Parameters.AddWithValue("@CodMateriaAbierta", codMateriaAbierta);


            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            //comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                resultado = comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                //Convert.ToInt32(comando.Parameters["@resultado"].Value); //obtengo la variable de retorno
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }


        public void ModificarMatricula(Matricula matricula)
        {
          
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_Modificar_Matricula"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@numeroFactura", matricula.NumeroFactura);
            comando.Parameters.AddWithValue("@carnetEstudiante", matricula.CarnetEstudiante.CarnetEstudiante);
            comando.Parameters.AddWithValue("@fechaMatricula", matricula.FechaMatricula);
            comando.Parameters.AddWithValue("@montoMatricula", matricula.MontoMatricula);


            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            //comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                //Convert.ToInt32(comando.Parameters["@resultado"].Value); //obtengo la variable de retorno
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }


        public DataTable convertirArregloAdatatable(List<MateriasAbiertas> materiasAbiertas)
        {

            DataTable DT = new DataTable();
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Int32");
            column.ColumnName = "codMateriaAbierta";
            DT.Columns.Add(column);

            foreach (var item in materiasAbiertas)
            {
                DT.Rows.Add(new object[] { item.CodigoMateriaAbierta });
            }

            return DT;

        }

        public int FacturarMatricula(int numFactura, string tipoPago)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update TBL_Matriculas set EstadoFactura = 'CAN',TipoPago = @tipoPago WHERE NumFactura = @numFactura";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@numFactura", numFactura);
            comando.Parameters.AddWithValue("@tipoPago", tipoPago);

            try
            {
                conexion.Open();
                filasAfectadas = comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                conexion.Dispose();
                comando.Dispose();
            }
            return filasAfectadas;
        }


        public int VerificarMatriculaEstudiante(string carnetEstudiante) //verifica si el estudiante posee una matricula activa Y CANCELADA para ver si puede volver a matricular o no
        {
            int resultado = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = string.Format("select 1 from TBL_Matriculas M inner join TBL_Estudiantes E on M.CarnetEstudiante = E.CarnetEstudiante where EstadoMatricula = 'ACT' and EstadoFactura = 'CAN' and e.CarnetEstudiante = '{0}'", carnetEstudiante);
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                resultado = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }


        public int VMatriculaPendiente(string carnetEstudiante) //verifica si el estudiante posee una matricula activa y pendiente, eso con el fin de poder cargarla en la pantalla devuelve el numde factura
        {
            int resultado = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = string.Format("select NumFactura from TBL_Matriculas M inner join " +
                                                " TBL_Estudiantes E on M.CarnetEstudiante = E.CarnetEstudiante " +
                                                " where EstadoFactura = 'PEN' and EstadoMatricula = 'ACT' and e.CarnetEstudiante = '{0}'", carnetEstudiante);
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                resultado = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public int verificarMateriasRepetidas(int codigoMateriaAbierta, int numFactura)
        {
            int resultado = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_VERIFICAR_MATERIAS_REPETIDAS"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //parametros de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaAbierta", codigoMateriaAbierta);
            comando.Parameters.AddWithValue("@numFactura", numFactura);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@materiaRepetida", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@materiaRepetida"].Value); //obtengo la variable de retorno
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return resultado;

        }

        public int ObtenerNumeroFactura(string carnetEstudiante) //devuelve el numero de factura que tenga un estudiante
        {
            int numFactura = 0;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = string.Format("SELECT NumFactura FROM TBL_Matriculas WHERE CarnetEstudiante = '{0}'", carnetEstudiante);
            comando.Connection = conexion;

            try
            {
                conexion.Open();
                numFactura = Convert.ToInt32(comando.ExecuteScalar());
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return numFactura;

        }

        #endregion

    }
}
