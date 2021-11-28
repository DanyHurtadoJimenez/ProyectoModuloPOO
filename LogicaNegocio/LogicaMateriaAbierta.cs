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

        public DataSet ListarMateriasAbiertas(string condicion)
        {
            DataSet DS;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosMA.ListarMateriasAbiertas(condicion);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        public int InsertarMateriaAbierta(MateriasAbiertas materiaAbierta, Horarios horario, int codMateriaAB)
        {
            int codMateriaA = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                if (horario.HoraInicio >= DateTime.Parse("07:00") && horario.HoraInicio <= DateTime.Parse("20:00"))
                {
                    if (horario.HoraFin >= DateTime.Parse("08:00") && horario.HoraFin <= DateTime.Parse("22:00"))
                    {
                        if (horario.HoraInicio != horario.HoraFin)
                        {
                            if (horario.HoraFin > horario.HoraInicio)
                            {
                                codMateriaA = accesoDatosMA.InsertarMateriaAConSP(materiaAbierta, horario, codMateriaAB);
                                _mensaje = accesoDatosMA.Mensaje;
                            }
                            else
                            {
                                _mensaje = "ERROR, la hora no es válida, la hora final debe ser mayor que la hora de inicio";
                            }

                        }
                        else
                        {
                            _mensaje = "ERROR, la hora de inicio y la hora de fin no pueden ser iguales";
                        }
                    }
                    else
                    {
                        _mensaje = "ERROR, la hora de fin va desde las 08:00 hasta las 22:00";
                    }
                }
                else
                {
                    _mensaje = "ERROR, la hora de inicio va desde las 07:00 hasta las 20:00";
                }

            }
            catch (Exception)
            {
                throw;
            }

            return codMateriaA;
        }



        public int AsignarProfesor(int codProfesor, int idMateriaA)
        {
            int resultado = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                resultado = accesoDatosMA.InsertarProfesor(codProfesor, idMateriaA);
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

        public int verificarChoquesMaterias(string carnetEstudiante, string codRequisito)
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


        public int generarGrupo(int codMateriaCarrera, int anio, int periodo)
        {

            int numeroGrupo;
            ADMateriaAbierta accesoMa = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                numeroGrupo = accesoMa.generarGrupo(codMateriaCarrera, anio, periodo);
            }
            catch (Exception)
            {

                throw;
            }
            _mensaje = accesoMa.Mensaje;
            return numeroGrupo;
        }

        public int modificarMateriaAbierta(MateriasAbiertas materiaA)
        {
            int resultado = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                resultado = accesoDatosMA.modificarMateriaAbierta(materiaA);
            }
            catch (Exception)
            {
                throw;
            }
            _mensaje = accesoDatosMA.Mensaje;
            return resultado;
        }


        public int EliminarProfesor(int codMateriaAbierta, int codProfe)
        {
            int filasAfectadas = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatosMA.EliminarProfesor(codMateriaAbierta, codProfe);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }

        public int EliminarAula(int codMateriaAbierta, int codAula)
        {
            int filasAfectadas = 0;
            ADMateriaAbierta accesoDatosMA = new ADMateriaAbierta(_cadenaConexion);
            try
            {
                filasAfectadas = accesoDatosMA.EliminarAula(codMateriaAbierta, codAula);
            }
            catch (Exception)
            {
                throw;
            }
            return filasAfectadas;
        }


        #endregion


    }
}
