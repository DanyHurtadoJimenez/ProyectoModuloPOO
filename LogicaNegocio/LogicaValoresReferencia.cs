using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LogicaValoresReferencia
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
        public LogicaValoresReferencia() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaValoresReferencia(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public ValoresReferencia RecuperarPeriodoAnio()
        {
            ValoresReferencia valoresRef;
            ADValoresReferencia accesoDatosVR = new ADValoresReferencia(_cadenaConexion);
            try
            {
                valoresRef = accesoDatosVR.RecuperarValoresReferencia();
            }
            catch (Exception)
            {
                throw;
            }

            return valoresRef;
        }

        #endregion

    }
}
