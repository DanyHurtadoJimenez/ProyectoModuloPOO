using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Profesores : Persona
    {
        #region Atributos
        private int codigoProfesor;
        private int borrado;
        #endregion

        #region Atributos

        public Profesores()
        {
            codigoProfesor = 0;
            borrado = 0;
        }
        #endregion

        #region Propiedades
        public int CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", codigoProfesor, nombre, apellido1,apellido2);
        }
        #endregion

    }
}
