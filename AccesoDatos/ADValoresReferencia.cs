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

        public ValoresReferencia RecuperarPeriodoAnio() 
        {  

            ValoresReferencia valoresReferencia = new ValoresReferencia();
            SqlConnection conexion = new SqlConnection(_cadenaConexion);
            SqlCommand comando = new SqlCommand();
            SqlDataReader dataReader;//el data reader no tiene constructor para llenarlo es mediante un execute

            string sentencia = "select anio,periodo,montoMatricula,disponibilidad from TBL_ValoresReferencia where disponibilidad = 1";

            comando.Connection = conexion;
            comando.CommandText = sentencia;

            try
            {
                conexion.Open();
                dataReader = comando.ExecuteReader();

                if (dataReader.HasRows)
                {
                    dataReader.Read();//lee fila por fila del data reader
                    valoresReferencia.Anio = dataReader.GetInt32(0); //esta columna es de tipo integer y esta en la posicion 0
                    valoresReferencia.Periodo = dataReader.GetInt32(1);
                    valoresReferencia.MontoMatricula = dataReader.GetInt32(2);

                }
                conexion.Close();

            }
            catch (Exception)
            {
                throw;
            }
            return valoresReferencia;
        }

        #endregion

    }
}
