using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class Materias
    {

        #region Atributos
        private string codigoMateria;
        private string nombreMateria;
        private int creditosMateria;
        private int borrado;
        #endregion

        #region Constructores
        public Materias(string codMateria, string nombreM, int creditosM)
        {
            codigoMateria = codMateria;
            nombreMateria = nombreM;
            creditosMateria = creditosM;
            borrado = 0;
        }

        public Materias()
        {
            codigoMateria = string.Empty;
            nombreMateria = string.Empty;
            creditosMateria = 0;
            borrado = 0;
        }
        #endregion

        #region Propiedades
        public string CodigoMateria { get => codigoMateria; set => codigoMateria = value; }
        public string NombreMateria { get => nombreMateria; set => nombreMateria = value; }
        public int CreditosMateria { get => creditosMateria; set => creditosMateria = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", codigoMateria, nombreMateria, creditosMateria);
        }

        #endregion
    }
}
