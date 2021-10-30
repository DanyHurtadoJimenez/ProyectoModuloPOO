using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Aulas
    {
        #region Atributos
        private int codigoAula;
        private string tipoAula;
        private int numeroAula;
        private int capacidad;
        private bool disponibilidad;
        #endregion

        #region Constructores
        public Aulas(int codigoA, string tipoA, int numeroA, int capacidadA)
        {
            codigoAula = codigoA;
            tipoAula = tipoA;
            numeroAula = numeroA;
            capacidad = capacidadA;
            disponibilidad = true;
        }

        public Aulas()
        {
            codigoAula = 0;
            tipoAula = string.Empty;
            numeroAula = 0;
            capacidad = 0;
            disponibilidad = true;
        }
        #endregion

        #region Propiedades
        public int CodigoAula { get => codigoAula; set => codigoAula = value; }
        public string TipoAula { get => tipoAula; set => tipoAula = value; }
        public int NumeroAula { get => numeroAula; set => numeroAula = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public bool Disponibilidad { get => disponibilidad; set => disponibilidad = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", codigoAula, tipoAula, numeroAula,capacidad);
        }
        #endregion
    }
}
