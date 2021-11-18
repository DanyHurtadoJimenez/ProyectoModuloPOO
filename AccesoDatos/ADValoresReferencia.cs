using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADValoresReferencia
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

        public ADValoresReferencia(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region  Metodos

        public ValoresReferencia RecuperarValoresReferencia() //devuelve el periodo del valor de referencia
        {

            ValoresReferencia valoresReferencia = new ValoresReferencia();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute

            string sentencia = "select valor from TBL_ValoresReferencia where dato = 'periodo'";

            string sentencia2 = "select valor from TBL_ValoresReferencia where dato = 'anio'";

            string sentencia3 = "select valor from TBL_ValoresReferencia where dato = 'valorMatricula'";

            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();//ejecuta la primera sentencia

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    valoresReferencia.Periodo = dataReader.GetInt32(0); 
                }

                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }

            comando.CommandText = sentencia2;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader(); //ejecuta la segunda sentencia

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    valoresReferencia.Anio = dataReader.GetInt32(0);
                }

                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }

            comando.CommandText = sentencia3;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader(); //ejecuta la Tercera sentencia

                if (dataReader.HasRows)
                {
                    dataReader.Read();
                    valoresReferencia.ValorMatricula = dataReader.GetInt32(0);
                }

                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }

            return valoresReferencia; //devuelve el objeto lleno
        }

        #endregion

    }
}
