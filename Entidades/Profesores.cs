using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Profesores
    {
        #region Atributos
        private int codigoProfesor;
        private string idProfesor;
        private string nombreProfesor;
        private string apellido1Profesor;
        private string apellido2Profesor;
        private string telefonoProfesor;
        private string correoProfesor;
        //private Carreras especialidad;
        private int borrado;
        #endregion

        #region Atributos
        public Profesores(int codProfe, string idProfe, string nombreProfe, string apellido1Profe, string apellido2Profe, string telefonoProfe, string correoProfe)
        {
            codigoProfesor = codProfe;
            idProfesor = idProfe;
            nombreProfesor = nombreProfe;
            apellido1Profesor = apellido1Profe;
            apellido2Profesor = apellido2Profe;
            telefonoProfesor = telefonoProfe;
            correoProfesor = correoProfe;
            borrado = 0;
        }


        public Profesores()
        {
            codigoProfesor = 0;
            idProfesor = string.Empty;
            nombreProfesor = string.Empty;
            apellido1Profesor = string.Empty;
            apellido2Profesor = string.Empty;
            telefonoProfesor = string.Empty;
            correoProfesor = string.Empty;
            borrado = 0;
        }
        #endregion

        #region Propiedades
        public int CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        public string IdProfesor { get => idProfesor; set => idProfesor = value; }
        public string NombreProfesor { get => nombreProfesor; set => nombreProfesor = value; }
        public string Apellido1Profesor { get => apellido1Profesor; set => apellido1Profesor = value; }
        public string Apellido2Profesor { get => apellido2Profesor; set => apellido2Profesor = value; }
        public string TelefonoProfesor { get => telefonoProfesor; set => telefonoProfesor = value; }
        public string CorreoProfesor { get => correoProfesor; set => correoProfesor = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", codigoProfesor, nombreProfesor, apellido1Profesor);
        }
        #endregion

    }
}
