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
        private int valorMatricula;

        #endregion

        #region Constructores

        public ValoresReferencia()
        {
            anio = 0;
            periodo = 0;
            valorMatricula = 0;
        }


        #endregion

        #region Propiedad

        public int Anio { get => anio; set => anio = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int ValorMatricula { get => valorMatricula; set => valorMatricula = value; }

        #endregion

    }
}
