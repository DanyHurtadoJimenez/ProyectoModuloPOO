using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADMateriaAbierta
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

        public string CadenaConexion//set opcional en caso de que en el otro constructor no se le pase la cadenaConexion
        {
            set => _cadenaConexion = value;
        }
        #endregion

        #region Constructor
        public ADMateriaAbierta() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADMateriaAbierta(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarMateriasAbiertas(string condicion)
        {  //devuelve un dataset de Aulas para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = string.Format("SELECT CodMateriaAbierta, CodigoMateria, NombreMateria, NombreProfesor, " +
                                             "NumeroAula, Grupo, Cupo, Costo, Periodo,Anio FROM CONSULTA_MATERIAS_ABIERTAS WHERE Disponible = 0 ");

            if (!string.IsNullOrEmpty(condicion))
            { //si la condicion no esta vacia entonces concatene esa condicion a la sentencia
                sentencia = string.Format("{0} and {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Materias Abiertas");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }


        //public int InsertarMateriaAConSP(MateriasAbiertas materiaAbierta, List<Horarios> horarios)
        //{ 
        //    int resultado = -1;
        //    DataTable dtaHorarios = convertirArregloAdatatable(horarios);//los horarios se convierten en un datatable para enviarlo como parametro al procedimiento del SQL
        //    dtaHorarios.TableName = "dbo.HorarioType";

        //    SqlConnection conexion = new SqlConnection(_cadenaConexion);
        //    SqlCommand comando = new SqlCommand();

        //    comando.CommandText = "SP_INSERTARMATERIAABIERTA"; //nombre del procedimiento almacenado
        //    comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
        //    comando.Connection = conexion;
        //    //parametro de entrada para el SP
        //    comando.Parameters.AddWithValue("@codMateriaCarrera", materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera);
        //    comando.Parameters.AddWithValue("@grupo", Convert.ToByte(materiaAbierta.Grupo));
        //    comando.Parameters.AddWithValue("@cupo", Convert.ToByte(materiaAbierta.Cupo));
        //    comando.Parameters.AddWithValue("@costo", materiaAbierta.Costo);
        //    comando.Parameters.AddWithValue("@periodo",Convert.ToByte(materiaAbierta.Periodo));
        //    comando.Parameters.AddWithValue("@anio", (Int16)materiaAbierta.Anio);
        //    SqlParameter dataTable = new SqlParameter();
        //    dataTable.SqlDbType = SqlDbType.Structured;
        //    dataTable.TypeName = "dbo.HorarioType";
        //    dataTable.Value = dtaHorarios;
        //    comando.Parameters.AddWithValue("@Horario", dataTable.Value);

        //    //parametro de salida del SP
        //    comando.Parameters.Add("@msj", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
        //    comando.Parameters.Add("@idMateriaAbierta", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

        //    try
        //    {
        //        conexion.Open();
        //        comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
        //        resultado = Convert.ToInt32(comando.Parameters["@idMateriaAbierta"].Value); //obtengo la variable de retorno
        //        //se va a leer el parametro de salida del SP
        //        _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
        //        conexion.Close();
        //    }
        //    catch (Exception)
        //    {

        //        throw;
        //    }

        //    return resultado;

        //}


        public int InsertarMateriaAConSP(MateriasAbiertas materiaAbierta, Horarios horario, int codMateriaA)
        {
            int resultado = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_INSERTARMATERIAABIERTA"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaAbierta", codMateriaA);
            comando.Parameters.AddWithValue("@codMateriaCarrera", materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera);
            comando.Parameters.AddWithValue("@grupo", Convert.ToByte(materiaAbierta.Grupo));
            comando.Parameters.AddWithValue("@cupo", Convert.ToByte(materiaAbierta.Cupo));
            comando.Parameters.AddWithValue("@costo", materiaAbierta.Costo);
            comando.Parameters.AddWithValue("@periodo", Convert.ToByte(materiaAbierta.Periodo));
            comando.Parameters.AddWithValue("@anio", (Int16)materiaAbierta.Anio);
            comando.Parameters.AddWithValue("@dia", horario.Dia);
            comando.Parameters.AddWithValue("@horaInicio", horario.HoraInicio);
            comando.Parameters.AddWithValue("@horaFin", horario.HoraFin);


            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@idMateriaAbierta", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@idMateriaAbierta"].Value); //obtengo la variable de retorno
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


        public int InsertarProfesor(int codProfesor, int idMateriaAbierta)
        { //insertar el profesor mediante un stored Procedure en la tabla de materias Abiertas
            int resultado = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_ASIGNAR_PROFE_MA"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //parametros de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaAbierta", idMateriaAbierta);
            comando.Parameters.AddWithValue("@idProfesor", codProfesor);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@existeChoque", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@existeChoque"].Value); //obtengo la variable de retorno
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

        public int InsertarAula(int codAula, int idMateriaAbierta)
        { //insertar el profesor mediante un stored Procedure en la tabla de materias Abiertas
            int resultado = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_ASIGNAR_AULA_MA"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //parametros de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaAbierta", idMateriaAbierta);
            comando.Parameters.AddWithValue("@idAula", codAula);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@existeChoque", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                resultado = Convert.ToInt32(comando.Parameters["@existeChoque"].Value); //obtengo la variable de retorno
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


        //public DataTable convertirArregloAdatatable(List<Horarios> horarios) {

        //    DataTable DT = new DataTable();
        //    DataColumn column = new DataColumn();
        //    column.DataType = System.Type.GetType("System.Char");
        //    column.ColumnName = "Dia";
        //    DT.Columns.Add(column);

        //    column = new DataColumn();
        //    column.DataType = System.Type.GetType("System.DateTime");
        //    column.ColumnName = "HoraInicio";
        //    DT.Columns.Add(column);

        //    column = new DataColumn();
        //    column.DataType = System.Type.GetType("System.DateTime");
        //    column.ColumnName = "HoraFin";
        //    DT.Columns.Add(column);

        //    foreach (var item in horarios)
        //    {
        //        DT.Rows.Add(new object[] { item.Dia, item.HoraInicio, item.HoraFin });
        //    }

        //    return DT;

        //}

        public MateriasAbiertas ObtenerMateriaAbierta(int codMateriaAbierta)
        { //devuelve una materia abierta cuando se busca
            MateriasAbiertas materiaA = new MateriasAbiertas();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute
            string sentencia = string.Format("SELECT CodMateriaAbierta,CodMateriaCarrera,CodigoMateria,NombreMateria,Requisito," +
                                             "nombreRequisito,corequisito,nombreCoRequisito,CodigoProfesor,NombreProfesor,CodigoAula," +
                                             "NumeroAula,Grupo,Cupo,Costo,Periodo,Anio,NombreCarrera,CreditosMateria FROM OBTENER_MATERIA_ABIERTA " +
                                             " where CodMateriaAbierta = {0}", codMateriaAbierta);
            comando.Connection = conexion;
            comando.CommandText = sentencia;
            materiaA.CodigoMateriaCarrera = new MateriasCarreras();
            materiaA.CodigoMateriaCarrera.CodigoCarreras = new Carreras();
            materiaA.CodigoMateriaCarrera.CodigoMateria = new Materias();
            materiaA.CodigoMateriaCarrera.Requisito = new Materias();
            materiaA.CodigoMateriaCarrera.Corequisito = new Materias();
            materiaA.CodigoProfesor = new Profesores();
            materiaA.CodigoAula = new Aulas();

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    materiaA.CodigoMateriaAbierta = dataReader.GetInt32(0); //esta columna es de tipo integer y esta en la posicion 0
                    materiaA.CodigoMateriaCarrera.CodigoMateriaCarrera = dataReader.GetInt32(1);
                    materiaA.CodigoMateriaCarrera.CodigoMateria.CodigoMateria = dataReader.GetString(2);
                    materiaA.CodigoMateriaCarrera.CodigoMateria.NombreMateria = dataReader.GetString(3);
                    if (!dataReader.IsDBNull(4))
                    {
                        materiaA.CodigoMateriaCarrera.Requisito.CodigoMateria = dataReader.GetString(4);
                    }
                    if (!dataReader.IsDBNull(5))
                    {
                        materiaA.CodigoMateriaCarrera.Requisito.NombreMateria = dataReader.GetString(5);
                    }
                    if (!dataReader.IsDBNull(6))
                    {
                        materiaA.CodigoMateriaCarrera.Corequisito.CodigoMateria = dataReader.GetString(6);
                    }
                    if (!dataReader.IsDBNull(7))
                    {
                        materiaA.CodigoMateriaCarrera.Corequisito.NombreMateria = dataReader.GetString(7);
                    }
                    if (!dataReader.IsDBNull(8))
                    {
                        materiaA.CodigoProfesor.CodigoProfesor = dataReader.GetInt32(8);
                    }
                    if (!dataReader.IsDBNull(9))
                    {
                        materiaA.CodigoProfesor.Nombre = dataReader.GetString(9);
                    }
                    if (!dataReader.IsDBNull(10))
                    {
                        materiaA.CodigoAula.CodigoAula = dataReader.GetInt32(10);
                    }
                    if (!dataReader.IsDBNull(11))
                    {
                        materiaA.CodigoAula.NumeroAula = dataReader.GetInt32(11);
                    }
                    materiaA.Grupo = dataReader.GetByte(12);
                    materiaA.Cupo = dataReader.GetByte(13);
                    materiaA.Costo = dataReader.GetDecimal(14);
                    materiaA.Periodo = dataReader.GetByte(15);
                    materiaA.Anio = dataReader.GetInt16(16);
                    materiaA.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera = dataReader.GetString(17);
                    materiaA.CodigoMateriaCarrera.CodigoMateria.CreditosMateria = dataReader.GetByte(18);
                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return materiaA;
        }


        public int verificarChoquesMaterias(string carnetEstudiante, string codRequisito)
        { //insertar el profesor mediante un stored Procedure en la tabla de materias Abiertas
            int resultado = -1;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_VERIFICARREQUISITO"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;
            comando.Connection = conexion;

            //parametros de entrada para el SP
            comando.Parameters.AddWithValue("@codRequisito", codRequisito);
            comando.Parameters.AddWithValue("@carnetEstudiante", carnetEstudiante);

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

        public int generarGrupo(int codMateriaCarrera, int anio, int periodo)
        {
            int numGrupo;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_ASIGNAR_GRUPO"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaCarrera", codMateriaCarrera);
            comando.Parameters.AddWithValue("@anio", anio);
            comando.Parameters.AddWithValue("@periodo", periodo);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 1000).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado
            comando.Parameters.Add("@numGrupo", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;//se declara otro parametro de retorno del SP que obtenga el retorno del SP

            try
            {
                conexion.Open();
                comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
                numGrupo = Convert.ToInt32(comando.Parameters["@numGrupo"].Value); //obtengo la variable de retorno
                //se va a leer el parametro de salida del SP
                _mensaje = comando.Parameters["@msj"].Value.ToString();//obtiene el mensaje que se devolvio del SP
                conexion.Close();
            }
            catch (Exception)
            {

                throw;
            }

            return numGrupo;

        }


        public int modificarMateriaAbierta(MateriasAbiertas materiaA)
        {
            int resultado;

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_Modificar_Materia_Abierta"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaAbierta", materiaA.CodigoMateriaAbierta);
            comando.Parameters.AddWithValue("@codMateriaCarrera", materiaA.CodigoMateriaCarrera.CodigoMateriaCarrera);
            comando.Parameters.AddWithValue("@grupo", Convert.ToByte(materiaA.Grupo));
            comando.Parameters.AddWithValue("@cupo", Convert.ToByte(materiaA.Cupo));
            comando.Parameters.AddWithValue("@costo", materiaA.Costo);
            comando.Parameters.AddWithValue("@periodo", Convert.ToByte(materiaA.Periodo));
            comando.Parameters.AddWithValue("@anio", (Int16)materiaA.Anio);

            //parametro de salida del SP
            comando.Parameters.Add("@msj", SqlDbType.VarChar, 250).Direction = ParameterDirection.Output;//definicion del parametro de salida del procedimiento almacenado

            try
            {
                conexion.Open();
                resultado = comando.ExecuteNonQuery(); //ejecuta el SP y se llenan las variables de retorno del SP
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

        public int EliminarProfesor(int codMateriaAbierta, int codProfe) //elimina un profesor de la materia abierta
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE TBL_MateriasAbiertas SET CodigoProfesor = Null where CodMateriaAbierta = @CodMateriaAbierta and CodigoProfesor = @CodigoProfesor";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@CodMateriaAbierta", codMateriaAbierta);
            comando.Parameters.AddWithValue("@CodigoProfesor", codProfe);

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

        public int EliminarAula(int codMateriaAbierta, int codAula) //elimina un profesor de la materia abierta
        {
            int filasAfectadas = -1;
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            string sentencia = "UPDATE TBL_MateriasAbiertas SET CodigoAula = Null where CodMateriaAbierta = @CodMateriaAbierta and CodigoAula = @CodigoAula";
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            comando.Parameters.AddWithValue("@CodMateriaAbierta", codMateriaAbierta);
            comando.Parameters.AddWithValue("@CodigoAula", codAula);

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
