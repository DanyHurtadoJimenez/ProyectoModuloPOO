using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Horarios
    {
        #region Atributos
        private MateriasAbiertas codigoMateriaAbierta;
        private string dia;
        private string horaInicio; //////////////////////////////
        private string horaFin; ///////////////////////////////////
        #endregion

        #region Constructores
        public Horarios(MateriasAbiertas codigoMA, string diaH, string horaInicioH, string horaFinH)
        {
            codigoMateriaAbierta = codigoMA;
            dia = diaH;
            horaInicio = horaInicioH;
            horaFin = horaFinH;
        }

        public Horarios()
        {
            codigoMateriaAbierta = null;
            dia = string.Empty;
            horaInicio = string.Empty;
            horaFin = string.Empty;
        }
        #endregion

        #region Propiedades
        public MateriasAbiertas CodigoMateriaAbierta { get => codigoMateriaAbierta; set => codigoMateriaAbierta = value; }
        public string Dia { get => dia; set => dia = value; }
        public string HoraInicio { get => horaInicio; set => horaInicio = value; }
        public string HoraFin { get => horaFin; set => horaFin = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", codigoMateriaAbierta, dia, horaInicio, horaFin);
        }
        #endregion
    }
}
