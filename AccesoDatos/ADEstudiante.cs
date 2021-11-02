using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADEstudiante
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

        public ADEstudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarEstudiantes(string condicion)
        {  //devuelve un dataset de Aulas para mostrarlo en un datagridView

            DataSet datos = new DataSet(); //lugar donde se va a guardar la tabla que vendra de la consulta del sql
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlDataAdapter adapter;
            string sentencia = "SELECT CarnetEstudiante, IdEstudiante,concat(NombreEstudiante, ' ', Apellido1Estudiante, ' ', Apellido2Estudiante) as 'NombreEstudiante'"+
                               ",TelefonoEstudiante,CorreoEstudiante,FechaIngresso,Descuento FROM TBL_Estudiantes WHERE Borrado = 0";

            if (!string.IsNullOrEmpty(condicion))
            { //si la condicion no esta vacia entonces concatene esa condicion a la sentencia
                sentencia = string.Format("{0} and {1}", sentencia, condicion);
            }

            try
            {
                adapter = new SqlDataAdapter(sentencia, conexion);//se realiza la conexion y se prepara el adaptador para ejecutar la sentencia
                adapter.Fill(datos, "Estudiantes");//el adaptador llena el dataset y le pone nombre 
            }
            catch (Exception)
            {
                throw;
            }

            return datos; //devuelve el dataset
        }

        public Estudiantes ObtenerEstudiante(string codAlumno)
        { //devuelve una materia carrera cuando se busca
            Estudiantes estudiante = new Estudiantes();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute

            string sentencia = string.Format("SELECT CarnetEstudiante, IdEstudiante, NombreEstudiante, Apellido1Estudiante, Apellido2Estudiante, "+
                                             " TelefonoEstudiante, CorreoEstudiante, ProvinciaEstudiante, OtrasSenias, FechaIngresso, Descuento "+
                                             " FROM TBL_Estudiantes WHERE CarnetEstudiante ='{0}'", codAlumno);

            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    estudiante.CarnetEstudiante = dataReader.GetString(0); //esta columna es de tipo integer y esta en la posicion 0
                    estudiante.IdEstudiante = dataReader.GetString(1);
                    estudiante.NombreEstudiante = dataReader.GetString(2);
                    estudiante.Apellido1Estudiante = dataReader.GetString(3);
                    if (!dataReader.IsDBNull(4))
                    {
                        estudiante.Apellido2Estudiante = dataReader.GetString(4); //el apellido2 puede ser nulo
                    }
                    estudiante.TelefonoEstudiante = dataReader.GetString(5);
                    estudiante.CorreoEstudiante = dataReader.GetString(6);
                    if (!dataReader.IsDBNull(7))
                    {
                        estudiante.ProvinciaEstudiante = dataReader.GetString(7); //la provincia puede ser nula
                    }
                    if (!dataReader.IsDBNull(8))
                    {
                        estudiante.OtrasSenias = dataReader.GetString(8); 
                    }
                    estudiante.FechaIngreso = dataReader.GetDateTime(9);
                    if (!dataReader.IsDBNull(10))
                    {
                        estudiante.Descuento = dataReader.GetInt32(10);
                    }

                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return estudiante;
        }

        #endregion

    }
}
