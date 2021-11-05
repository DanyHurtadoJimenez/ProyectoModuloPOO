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

            subtotal = totalPagar + montoMatricula;

            montoDescuentoE = subtotal * (Convert.ToDouble(descuentoEstudiante));//se calcula el descuento
            montoIVA = subtotal * 0.02; //se calcula el iva
            totalPagar = subtotal - montoDescuentoE;//se aplica el descuento
            totalPagar += montoIVA; //se aplica el impuesto Iva

            return totalPagar;

        }

        public int Insertar(Matricula matriculaE, List<MateriasAbiertas> materiasA)
        {
            int resultado = -1;
            DataTable dtaMateriasA = convertirArregloAdatatable(materiasA);//los horarios se convierten en un datatable para enviarlo como parametro al procedimiento del SQL
            dtaMateriasA.TableName = "dbo.MateriasEscogidasType";

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
            SqlParameter dataTable = new SqlParameter();
            dataTable.SqlDbType = SqlDbType.Structured;
            dataTable.TypeName = "dbo.MateriasEscogidasType";
            dataTable.Value = dtaMateriasA;
            comando.Parameters.AddWithValue("@Materias", dataTable.Value);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
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
            string sentencia = string.Format("SELECT MA.CodMateriaAbierta,M.CodigoMateria,M.NombreMateria,MC.Requisito," +
                               "(SELECT NombreMateria FROM TBL_Materias WHERE CodigoMateria = MC.Requisito) AS 'nombreRequisito'," +
                               "MC.corequisito,(SELECT NombreMateria FROM TBL_Materias WHERE CodigoMateria = MC.corequisito) AS 'nombreCoRequisito'," +
                               "concat(NombreProfesor, ' ', Apellido1Profesor, ' ', Apellido2Profesor) as 'nombreProfesor',A.NumeroAula,Grupo,Costo " +
                               " FROM TBL_MateriasAbiertas MA left join TBL_MateriasCarreras MC on MA.CodMateriaCarrera = MC.CodMateriaCarrera " +
                               " left join TBL_Materias M on M.CodigoMateria = MC.CodigoMateria  left join TBL_Profesores P on P.CodigoProfesor = MA.CodigoProfesor " +
                               " left join TBL_Aulas A on A.CodigoAula = MA.CodigoAula left join  TBL_DetallesMatriculas DM on " +
                               " DM.CodMateriaAbierta = MA.CodMateriaAbierta left join TBL_Matriculas MT on MT.NumFactura = DM.NumFactura WHERE MT.NumFactura = {0}", numFactura);
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


        public int ModificarMaterias(int numFactura, List<MateriasAbiertas> materiasA)
        {
            int resultado = -1;
            DataTable dtaMateriasA = convertirArregloAdatatable(materiasA);//los horarios se convierten en un datatable para enviarlo como parametro al procedimiento del SQL
            dtaMateriasA.TableName = "dbo.MateriasEscogidasType";

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_MODIFICARMATERIASESCOGIDAS"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@numFactura", numFactura);
            SqlParameter dataTable = new SqlParameter();
            dataTable.SqlDbType = SqlDbType.Structured;
            dataTable.TypeName = "dbo.MateriasEscogidasType";
            dataTable.Value = dtaMateriasA;
            comando.Parameters.AddWithValue("@Materias", dataTable.Value);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@resultado", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@resultado"].Value); //obtengo la variable de retorno
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

        public int FacturarMatricula(int numFactura)
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "update TBL_Matriculas set EstadoFactura = 'CAN' WHERE NumFactura = @numFactura";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@numFactura", numFactura);

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

        #endregion

    }
}
