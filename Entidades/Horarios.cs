﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Horarios
    {
        #region Atributos
        private MateriasAbiertas codigoMateriaAbierta;
        private string dia;
        private DateTime horaInicio; //////////////////////////////
        private DateTime horaFin; ///////////////////////////////////
        #endregion

        #region Constructores
        public Horarios(MateriasAbiertas codigoMA, string diaH, DateTime horaInicioH, DateTime horaFinH)
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
            horaInicio = DateTime.Today;
            horaFin = DateTime.Today;
        }
        #endregion

        #region Propiedades
        public MateriasAbiertas CodigoMateriaAbierta { get => codigoMateriaAbierta; set => codigoMateriaAbierta = value; }
        public string Dia { get => dia; set => dia = value; }
        public DateTime HoraInicio { get => horaInicio; set => horaInicio = value; }
        public DateTime HoraFin { get => horaFin; set => horaFin = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", codigoMateriaAbierta, dia, horaInicio, horaFin);
        }
        #endregion
    }
}
