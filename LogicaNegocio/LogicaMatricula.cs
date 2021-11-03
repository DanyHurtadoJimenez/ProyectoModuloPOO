using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;

namespace LogicaNegocio
{
    public class LogicaMatricula
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
        public LogicaMatricula() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
        }

        public LogicaMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public double calcularCostos(decimal descuentoEstudiante, List<MateriasAbiertas> materias, int montoMatricula)
        {
            double costos;
            ADMatricula accesoDatos = new ADMatricula(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                costos = accesoDatos.calcularCostos(descuentoEstudiante, materias, montoMatricula);

            }
            catch (Exception)
            {
                throw;
            }

            return costos;
        }

        #endregion



    }
}
