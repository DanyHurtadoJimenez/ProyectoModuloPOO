using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MateriasAbiertas 
    {
        #region Atributos
        private int codigoMateriaAbierta;
        private MateriasCarreras codigoMateriaCarrera;
        private Profesores codigoProfesor;
        private Aulas codigoAula;
        private int grupo;
        private int cupo;
        private decimal costo;
        private int periodo;
        private int anio;
        private int disponible;
        #endregion

        #region Constructores
        public MateriasAbiertas(int codigoMA, MateriasCarreras codigoMC, Profesores codigoProfe, Aulas codigoA, int grupoMA, int cupoMA, decimal costoMA, int periodoMA, int anioMA)
        {
            codigoMateriaAbierta = codigoMA;
            codigoMateriaCarrera = codigoMC;
            codigoProfesor = codigoProfe;
            codigoAula = codigoA;
            grupo = grupoMA;
            cupo = cupoMA;
            costo = costoMA;
            periodo = periodoMA;
            anio = anioMA;
            disponible = 1;
        }

        public MateriasAbiertas()
        {
            codigoMateriaAbierta = 0;
            codigoMateriaCarrera = null;
            codigoProfesor = null;
            codigoAula = null;
            grupo = 0;
            cupo = 0;
            costo = 0;
            periodo = 0;
            anio = 0; ////////////////////////////////////////////////////////////
            disponible = 1;
        }
        #endregion

        #region Propiedades
        public int CodigoMateriaAbierta { get => codigoMateriaAbierta; set => codigoMateriaAbierta = value; }
        public MateriasCarreras CodigoMateriaCarrera { get => codigoMateriaCarrera; set => codigoMateriaCarrera = value; }
        public Profesores CodigoProfesor { get => codigoProfesor; set => codigoProfesor = value; }
        public Aulas CodigoAula { get => codigoAula; set => codigoAula = value; }
        public int Grupo { get => grupo; set => grupo = value; }
        public int Cupo { get => cupo; set => cupo = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public int Periodo { get => periodo; set => periodo = value; }
        public int Anio { get => anio; set => anio = value; }
        public int Disponible { get => disponible; set => disponible = value; }
        #endregion

        #region Metodos
        //public override string ToString()
        //{
        //    return string.Format("{0} - {1} - {2} - {3}", codigoAula, tipoAula, numeroAula, capacidad);
        //}
        #endregion
    }
}
