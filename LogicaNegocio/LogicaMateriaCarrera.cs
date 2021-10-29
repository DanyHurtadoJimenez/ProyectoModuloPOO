using System;
using System.Data;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class LogicaMateriaCarrera
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
        public LogicaMateriaCarrera() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaMateriaCarrera(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarMateriasCarreras(string condicion)
        {
            DataSet DS;
            ADMateriaCarrera accesoDatosMateriaC = new ADMateriaCarrera(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosMateriaC.ListarMateriasCarreras(condicion);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        public MateriasCarreras ObtenerMateriaCarrera(int codMateriaCarrera)
        {
            MateriasCarreras materiaC;
            ADMateriaCarrera accesoDatosMC = new ADMateriaCarrera(_cadenaConexion);
            try
            {
                materiaC = accesoDatosMC.ObtenerMateriaCarrera(codMateriaCarrera);
            }
            catch (Exception)
            {
                throw;
            }

            return materiaC;
        }

        #endregion

    }
}
