using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AccesoDatos;

namespace LogicaNegocio
{
   public class LogicaHorarios
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
        public LogicaHorarios() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaHorarios(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarHorarios(int codMateriaAbierta)
        {
            DataSet DS;
            ADHorarios accesoDatosH = new ADHorarios(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosH.Listar(codMateriaAbierta);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        #endregion


    }
}
