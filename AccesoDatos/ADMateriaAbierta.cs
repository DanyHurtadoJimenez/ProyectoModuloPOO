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

        public int InsertarMateriaAConSP(MateriasAbiertas materiaAbierta, List<Horarios> horarios)
        { 
            int resultado = -1;
            DataTable dtaHorarios = convertirArregloAdatatable(horarios);//los horarios se convierten en un datatable para enviarlo como parametro al procedimiento del SQL
            dtaHorarios.TableName = "dbo.HorarioType";

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_INSERTARMATERIAABIERTA"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@codMateriaCarrera", materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera);
            comando.Parameters.AddWithValue("@grupo", Convert.ToByte(materiaAbierta.Grupo));
            comando.Parameters.AddWithValue("@cupo", Convert.ToByte(materiaAbierta.Cupo));
            comando.Parameters.AddWithValue("@costo", materiaAbierta.Costo);
            comando.Parameters.AddWithValue("@periodo",Convert.ToByte(materiaAbierta.Periodo));
            comando.Parameters.AddWithValue("@anio", (Int16)materiaAbierta.Anio);
            SqlParameter dataTable = new SqlParameter();
            dataTable.SqlDbType = SqlDbType.Structured;
            dataTable.TypeName = "dbo.HorarioType";
            dataTable.Value = dtaHorarios;
            comando.Parameters.AddWithValue("@Horario", dataTable.Value);



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

        public int InsertarProfesor(int codProfesor,int idMateriaAbierta)
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


        public DataTable convertirArregloAdatatable(List<Horarios> horarios) {

            DataTable DT = new DataTable();
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Char");
            column.ColumnName = "Dia";
            DT.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "HoraInicio";
            DT.Columns.Add(column);

            column = new DataColumn();
            column.DataType = System.Type.GetType("System.DateTime");
            column.ColumnName = "HoraFin";
            DT.Columns.Add(column);

            foreach (var item in horarios)
            {
                DT.Rows.Add(new object[] { item.Dia, item.HoraInicio, item.HoraFin });
            }

            return DT;

        }


        #endregion



    }
}
