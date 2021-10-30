using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class AccesoDatosAula
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
        public AccesoDatosAula() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public AccesoDatosAula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarAulas(string condicion)
        {  //devuelve un dataset de Aulas para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "select CodigoAula, TipoAula, NumeroAula,Capacidad from TBL_Aulas where Disponibilidad = 0 ";

            if (!string.IsNullOrEmpty(condicion))
            { //si la condicion no esta vacia entonces concatene esa condicion a la sentencia
                sentencia = string.Format("{0} and {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Aulas");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }

        public Aulas ObtenerAula(int codAula)
        { //devuelve una materia carrera cuando se busca
            Aulas aula = new Aulas();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute
            string sentencia = string.Format("select CodigoAula, TipoAula, NumeroAula,Capacidad, Disponibilidad "+
                                            " from TBL_Aulas where Disponibilidad = 0 and CodigoAula = {0}", codAula);

            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    aula.CodigoAula = dataReader.GetInt32(0); //esta columna es de tipo integer y esta en la posicion 0
                    aula.TipoAula = dataReader.GetString(1);
                    aula.NumeroAula = dataReader.GetInt32(2);
                    aula.Capacidad = dataReader.GetInt32(3);
                    aula.Disponibilidad = dataReader.GetBoolean(4);
                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return aula;
        }


        #endregion


    }
}
