using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LogicaMateriaAbierta
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
        public LogicaMateriaAbierta() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaMateriaAbierta(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public int InsertarMateriaAbierta(MateriasAbiertas materiaA,List<Horarios> horario)
        {
            int codMateriaA = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                codMateriaA = accesoDatosMA.InsertarMateriaAConSP(materiaA,horario);
            }
            catch (Exception)
            {
                throw;
            }
            _mensaje = accesoDatosMA.Mensaje;
            return codMateriaA;
        }

        public int AsignarProfesor(MateriasAbiertas materiaA, int codProfesor,int idMateriaA, List<Horarios> horario)
        {
            int resultado = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                resultado = accesoDatosMA.InsertarProfesor(materiaA,codProfesor,idMateriaA, horario);
            }
            catch (Exception)
            {
                throw;
            }
            _mensaje = accesoDatosMA.Mensaje;
            return resultado;
        }


        #endregion


    }
}
