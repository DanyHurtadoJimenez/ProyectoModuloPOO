using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADProfesor
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
        public ADProfesor() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public ADProfesor(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodo

        public DataSet ListarProfesores(string condicion)
        {  //devuelve un dataset de MateriasCarreras para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT CodigoProfesor,IdProfesor,NombreProfesor,Apellido1Profesor,Apellido2Profesor,TelefonoProfesor FROM TBL_Profesores";

            if (!string.IsNullOrEmpty(condicion))
            { //si la condicion no esta vacia entonces concatene esa condicion a la sentencia
                sentencia = string.Format("{0} where {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Profesores");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }

        public Profesores ObtenerProfesor(int codProfe)
        { //devuelve una materia carrera cuando se busca
            Profesores profesor = new Profesores();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute
            string sentencia = string.Format("SELECT CodigoProfesor,IdProfesor,NombreProfesor,Apellido1Profesor,Apellido2Profesor,TelefonoProfesor, CorreoProfesor FROM TBL_Profesores " +
                                             "WHERE CodigoProfesor ={0}", codProfe);

            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    profesor.CodigoProfesor = dataReader.GetInt32(0); //esta columna es de tipo integer y esta en la posicion 0
                    profesor.Cedula = dataReader.GetString(1);
                    profesor.Nombre = dataReader.GetString(2);
                    profesor.Apellido1 = dataReader.GetString(3);
                    if (!dataReader.IsDBNull(4))
                    {
                        profesor.Apellido2 = dataReader.GetString(4); //el apellido2 puede ser nulo
                    }
                    profesor.Telefono = dataReader.GetString(5);
                    profesor.CorreoElectronico = dataReader.GetString(6);

                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return profesor;
        }



        #endregion




    }
}
