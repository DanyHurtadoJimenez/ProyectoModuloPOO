using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class LogicaAula
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
        public LogicaAula() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaAula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarAulas(string condicion)
        {
            DataSet DS;
            AccesoDatosAula accesoDatosA = new AccesoDatosAula(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosA.ListarAulas(condicion);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        public Aulas ObtenerAula(int codAula)
        {
            Aulas aula;
            AccesoDatosAula accesoDatosAula = new AccesoDatosAula(_cadenaConexion);
            try
            {
                aula = accesoDatosAula.ObtenerAula(codAula);
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
