using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using AccesoDatos;
using Entidades;

namespace LogicaNegocio
{
    public class LogicaProfesores
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
        public LogicaProfesores() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaProfesores(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Métodos 

        public DataSet ListarProfesores(string condicion)
        {
            DataSet DS;
            ADProfesor accesoDatosProfe = new ADProfesor(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosProfe.ListarProfesores(condicion);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }


        public Profesores ObtenerProfesor(int codProfe)
        {
            Profesores profesor;
            ADProfesor accesoDatosProfe = new ADProfesor(_cadenaConexion);
            try
            {
                profesor = accesoDatosProfe.ObtenerProfesor(codProfe);
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
