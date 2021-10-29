using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class MateriasCarreras
    {
        #region Atributos
        private int codigoMateriaCarrera;
        private Carreras codigoCarreras;
        private Materias codigoMateria;
        private Materias requisito;
        private Materias corequisito;
        private string estado;
        private int borrado;
        #endregion

        #region Constructores
        public MateriasCarreras(int codigoMC, Carreras codigoC, Materias codigoM, Materias requisitoC, Materias corequisitoMC, string estadoMC)
        {
            codigoMateriaCarrera = codigoMC;
            codigoCarreras = codigoC;
            codigoMateria = codigoM;
            requisito = requisitoC;
            corequisito = corequisitoMC;
            estado = estadoMC;
            borrado = 0;
        }

        public MateriasCarreras()
        {
            codigoMateriaCarrera = 0;
            codigoCarreras = null;
            codigoMateria = null;
            requisito = null;
            corequisito = null;
            estado = "VIGENTE";
            borrado = 0;
        }
        #endregion

        #region Propiedades
        public int CodigoMateriaCarrera { get => codigoMateriaCarrera; set => codigoMateriaCarrera = value; }
        public Carreras CodigoCarreras { get => codigoCarreras; set => codigoCarreras = value; }
        public Materias CodigoMateria { get => codigoMateria; set => codigoMateria = value; }
        public Materias Requisito { get => requisito; set => requisito = value; }
        public Materias Corequisito { get => corequisito; set => corequisito = value; }
        public string Estado { get => estado; set => estado = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        #endregion

    }
}
