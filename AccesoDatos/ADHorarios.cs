using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace AccesoDatos
{
    public class ADHorarios
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

        public ADHorarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet Listar(int codMateriaAbierta) //lista horarios seleccionados
        {  //devuelve un dataset de Aulas para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = string.Format("select dia,HoraInicio,HoraFin from TBL_Horarios where CodMateriaAbierta = {0}", codMateriaAbierta);

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Horarios");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }


        public int verificarChoquesMaterias(DataSet datos, string carnetEstudiante)
        {
            int resultado = -1;
            DataTable dtaHorarios = convertirADataTable(datos);//los horarios se convierten en un datatable para enviarlo como parametro al procedimiento del SQL
            dtaHorarios.TableName = "dbo.HorarioType";

            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();

            comando.CommandText = "SP_VERIFICARCHOQUEMATERIAS"; //nombre del procedimiento almacenado
            comando.CommandType = CommandType.StoredProcedure;//se especifica que tipo de comando es, en este caso es un procedimiento almacenado
            comando.Connection = conexion;
            //parametro de entrada para el SP
            comando.Parameters.AddWithValue("@carnetEstudiante", carnetEstudiante);
            SqlParameter dataTable = new SqlParameter();
            dataTable.SqlDbType = SqlDbType.Structured;
            dataTable.TypeName = "dbo.HorarioType";
            dataTable.Value = dtaHorarios;
            comando.Parameters.AddWithValue("@Horario", dataTable.Value);

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


        public DataTable convertirADataTable(DataSet datos) //convierte de un dataset a una lista
        {

            DataTable dtHorarios = new DataTable();
            dtHorarios.Columns.Add("dia", typeof(string));
            dtHorarios.Columns.Add("HoraInicio", typeof(DateTime));
            dtHorarios.Columns.Add("HoraFin", typeof(DateTime));
            dtHorarios = datos.Tables[0];

            //List<Horarios> listaHorarios = new List<Horarios>();

            //for (int i = 0; i < dtHorarios.Rows.Count; i++)
            //{
            //    Horarios horario = new Horarios();
            //    horario.Dia = Convert.ToString(dtHorarios.Rows[i]["dia"]);
            //    horario.HoraInicio = (DateTime)dtHorarios.Rows[i]["HoraInicio"];
            //    horario.HoraFin = (DateTime)dtHorarios.Rows[i]["HoraFin"];
            //    listaHorarios.Add(horario);
            //}

            //foreach (DataRow item in datos.Tables[0].Rows)
            //{
            //    horario = new Horarios();
            //    horario.Dia = item["dia"].ToString();
            //    horario.HoraInicio=Convert.ToDateTime(item["HoraInicio"]);
            //    horario.HoraFin = Convert.ToDateTime(item["HoraFin"]);
            //    listaHorarios.Add(horario);
            //}
            return dtHorarios;
        }




        #endregion


    }
}
