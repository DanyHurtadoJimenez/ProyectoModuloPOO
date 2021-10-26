using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Estudiantes 
    {
        #region Atributos
        private string carnetEstudiante;
        private string idEstudiante;
        private string nombreEstudiante;
        private string apellido1Estudiante;
        private string apellido2Estudiante;
        private string telefonoEstudiante;
        private string correoEstudiante;
        private string provinciaEstudiante;
        private string cantonEstudiante;
        private string distritoEstudiante;
        private string otrasSenias;
        private DateTime fechaIngreso;
        private int descuento;
        private string estado;
        private int borrado;

        #endregion

        #region Propiedades
        public string CarnetEstudiante { get => carnetEstudiante; set => carnetEstudiante = value; }
        public string IdEstudiante { get => idEstudiante; set => idEstudiante = value; }
        public string NombreEstudiante { get => nombreEstudiante; set => nombreEstudiante = value; }
        public string Apellido1Estudiante { get => apellido1Estudiante; set => apellido1Estudiante = value; }
        public string Apellido2Estudiante { get => apellido2Estudiante; set => apellido2Estudiante = value; }
        public string TelefonoEstudiante { get => telefonoEstudiante; set => telefonoEstudiante = value; }
        public string CorreoEstudiante { get => correoEstudiante; set => correoEstudiante = value; }
        public string ProvinciaEstudiante { get => provinciaEstudiante; set => provinciaEstudiante = value; }
        public string CantonEstudiante { get => cantonEstudiante; set => cantonEstudiante = value; }
        public string DistritoEstudiante { get => distritoEstudiante; set => distritoEstudiante = value; }
        public string OtrasSenias { get => otrasSenias; set => otrasSenias = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public int Descuento { get => descuento; set => descuento = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Constructores

        public Estudiantes(string carnetEstud, string idEstudia, string nombreE, string apellido1E, string apellido2E, string telefonoE, string correoE, string provinciaE, string cantonE, string distritoE, string direccionE, DateTime fechaIngresoE, int descuentoE, string estadoE)
        {
            carnetEstudiante = carnetEstud;
            idEstudiante = idEstudia;
            nombreEstudiante = nombreE;
            apellido1Estudiante = apellido1E;
            apellido2Estudiante = apellido2E;
            telefonoEstudiante = telefonoE;
            correoEstudiante = correoE;
            provinciaEstudiante = provinciaE;
            cantonEstudiante = cantonE;
            distritoEstudiante = distritoE;
            otrasSenias = direccionE;
            fechaIngreso = fechaIngresoE;
            descuento = descuentoE;
            estado = estadoE;
            borrado = 0;
        }

        public Estudiantes()
        {
            carnetEstudiante = string.Empty;
            idEstudiante = string.Empty;
            nombreEstudiante = string.Empty;
            apellido1Estudiante = string.Empty;
            apellido2Estudiante = string.Empty;
            telefonoEstudiante = string.Empty;
            correoEstudiante = string.Empty;
            provinciaEstudiante = string.Empty;
            cantonEstudiante = string.Empty;
            distritoEstudiante = string.Empty;
            otrasSenias = string.Empty;
            fechaIngreso = DateTime.Today;
            descuento = 0;
            estado = "ACT";
            borrado = 0;
        }

        #endregion

        #region Metodos

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", carnetEstudiante, idEstudiante, nombreEstudiante,apellido1Estudiante,telefonoEstudiante,correoEstudiante,provinciaEstudiante,cantonEstudiante,fechaIngreso,descuento);
        }

        #endregion
    }
}
