using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;
using System.Data;

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

        public DataSet ListarMateriasAbiertas(string condicion, int periodo, int anio)
        {
            DataSet DS;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosMA.ListarMateriasAbiertas(condicion,periodo, anio);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

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

        public int AsignarProfesor(int codProfesor,int idMateriaA)
        {
            int resultado = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                resultado = accesoDatosMA.InsertarProfesor(codProfesor,idMateriaA);
            }
            catch (Exception)
            {
                throw;
            }
            _mensaje = accesoDatosMA.Mensaje;
            return resultado;
        }

        public int AsignarAula(int codAula, int idMateriaA)
        {
            int resultado = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                resultado = accesoDatosMA.InsertarAula(codAula, idMateriaA);
            }
            catch (Exception)
            {
                throw;
            }
            _mensaje = accesoDatosMA.Mensaje;
            return resultado;
        }

        public MateriasAbiertas ObtenerMateriaAbierta(int codMA)
        {
            MateriasAbiertas materiaAbierta;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                materiaAbierta = accesoDatosMA.ObtenerMateriaAbierta(codMA);
            }
            catch (Exception)
            {
                throw;
            }

            return materiaAbierta;
        }

        public int verificarChoquesMaterias(string carnetEstudiante,string codRequisito)
        {
            int resultado = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                resultado = accesoDatosMA.verificarChoquesMaterias(carnetEstudiante, codRequisito);
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
