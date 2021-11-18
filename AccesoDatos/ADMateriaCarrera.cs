using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Entidades;

namespace AccesoDatos
{
    public class ADMateriaCarrera
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
        public ADMateriaCarrera() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADMateriaCarrera(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        

        #region Metodos

        public DataSet ListarMateriasCarreras(string condicion)
        {  //devuelve un dataset de MateriasCarreras para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select CodMateriaCarrera,MC.CodigoMateria,NombreMateria,CreditosMateria,NombreCarrera,C.CodigoCarrera from TBL_MateriasCarreras MC inner join TBL_Materias M on MC.CodigoMateria = M.CodigoMateria inner join TBL_Carreras C on MC.CodigoCarrera = C.CodigoCarrera";

            if (!string.IsNullOrEmpty(condicion))
            { //si la condicion no esta vacia entonces concatene esa condicion a la sentencia
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Materias Carreras");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }

        public MateriasCarreras ObtenerMateriaCarrera(int codMateriaCarrera)
        { //devuelve una materia carrera cuando se busca
            MateriasCarreras materiaC = new MateriasCarreras();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute
            string sentencia = string.Format("select CodMateriaCarrera,C.CodigoCarrera,M.CodigoMateria, MC.Requisito,MC.corequisito,M.NombreMateria,C.NombreCarrera, M.CreditosMateria" +
                                             " from TBL_MateriasCarreras MC inner join TBL_Materias M on "+
                                             " MC.CodigoMateria = M.CodigoMateria inner join TBL_Carreras C "+
                                             " on MC.CodigoCarrera = C.CodigoCarrera "+
                                             "WHERE CodMateriaCarrera ={0}", codMateriaCarrera);//si el id fuera texto se debe poner el 0 entre comillas asi '{0}' dentro del string

            comando.Connection = conexion;
            comando.CommandText = sentencia;
            materiaC.CodigoCarreras = new Carreras(); // se instancian los atributos que posee la clase MateriasCarreras
            materiaC.CodigoMateria = new Materias();
            materiaC.Requisito = new Materias();
            materiaC.Corequisito = new Materias();

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    materiaC.CodigoMateriaCarrera = dataReader.GetInt32(0); //esta columna es de tipo integer y esta en la posicion 0
                    materiaC.CodigoCarreras.CodigoCarrera = dataReader.GetInt32(1);
                    materiaC.CodigoMateria.CodigoMateria = dataReader.GetString(2);
                    if (!dataReader.IsDBNull(3))
                    {
                        materiaC.Requisito.CodigoMateria = dataReader.GetString(3); //el requisito y correquisito pueden ser nulos por lo tanto se verifica que no lleguen nulos
                    }
                    if (!dataReader.IsDBNull(4))
                    {
                        materiaC.Corequisito.CodigoMateria = dataReader.GetString(4);
                    }
                    materiaC.CodigoMateria.NombreMateria = dataReader.GetString(5);
                    materiaC.CodigoCarreras.NombreCarrera = dataReader.GetString(6);
                    materiaC.CodigoMateria.CreditosMateria = dataReader.GetByte(7);

                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return materiaC;

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
            comando.Parameters.AddWithValue("@codMateriaCarrera",codMateriaCarrera);
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

        #endregion

    }
}
