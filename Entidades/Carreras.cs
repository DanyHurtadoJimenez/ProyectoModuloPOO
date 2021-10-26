using System;

namespace Entidades
{
    public class Carreras
    {
        #region Atributos
        private int codigoCarrera;
        private string nombreCarrera;
        private int totalCreditos;
        private string gradoCarrera;
        private int borrado;
        #endregion

        #region Constructores
        public Carreras(int codCarrera, string nombCarrera, int creditosTotales, string gradoCarrer)
        {
            codigoCarrera = codCarrera;
            nombreCarrera = nombCarrera;
            totalCreditos = creditosTotales;
            gradoCarrera = gradoCarrer;
            borrado = 0;
        }

        public Carreras()
        {
            codigoCarrera = 0;
            nombreCarrera = string.Empty; 
            totalCreditos = 0;
            gradoCarrera = string.Empty;
            borrado = 0;
        }

        #endregion

        #region Propiedades
        public int CodigoCarrera { get => codigoCarrera; set => codigoCarrera = value; }
        public string NombreCarrera { get => nombreCarrera; set => nombreCarrera = value; }
        public int TotalCreditos { get => totalCreditos; set => totalCreditos = value; }
        public string GradoCarrera { get => gradoCarrera; set => gradoCarrera = value; }
        public int Borrado { get => borrado; set => borrado = value; }
        #endregion

        #region Metodos

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", codigoCarrera, nombreCarrera,totalCreditos);
        }

        #endregion
    }
}
