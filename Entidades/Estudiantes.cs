using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Estudiantes : Persona
    {
        #region Atributos
        private string carnetEstudiante;
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


        public Estudiantes()
        {
            carnetEstudiante = string.Empty;
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
            return string.Format("{0} - {1} - {2} - {3} - {4} - {5} - {6} - {7} - {8} - {9}", carnetEstudiante, cedula, nombre,apellido1,apellido2,correoElectronico,provinciaEstudiante,cantonEstudiante,fechaIngreso,descuento);
        }

        #endregion
    }
}
