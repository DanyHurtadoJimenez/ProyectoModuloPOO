using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class LogicaEstudiante
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
        public LogicaEstudiante(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public DataSet ListarEstudiante(string condicion)
        {
            DataSet DS;
            ADEstudiante accesoDatosEstudiante = new ADEstudiante(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosEstudiante.ListarEstudiantes(condicion);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        public Estudiantes ObtenerEstudiante(string codEstudiante)
        {
            Estudiantes estudiante;
            ADEstudiante accesoDatosEstudiante = new ADEstudiante(_cadenaConexion);
            try
            {
                estudiante = accesoDatosEstudiante.ObtenerEstudiante(codEstudiante);
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
