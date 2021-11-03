using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class ValoresReferencia
    {

        #region Atributos

            private int anio;
            private int periodo;
            private int montoMatricula;
            private int disponibilidad;

        #endregion

        #region Constructores

        public ValoresReferencia()
        {
            anio = 0;
            periodo = 0;
            montoMatricula = 0;
            disponibilidad = 0;
        }


        #endregion

        #region Propiedad

        public int Anio { get => anio; set => anio = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int MontoMatricula { get => montoMatricula; set => montoMatricula = value; }
        public int Disponibilidad { get => disponibilidad; set => disponibilidad = value; }

        #endregion

    }
}
