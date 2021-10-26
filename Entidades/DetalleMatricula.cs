using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
   public class DetalleMatricula
    {
        #region Atributos
        private Matricula numFactura;
        private MateriasAbiertas codigoMateriaAbierta;
        private decimal porcentajeDescuento;
        private decimal notaFinal;
        private string estadoDetalle;
        #endregion

        #region Constructor
        public DetalleMatricula(Matricula numFact, MateriasAbiertas codigoMA, decimal descuento, decimal notaF, string estadoD)
        {
            numFactura = numFact;
            codigoMateriaAbierta = codigoMA;
            porcentajeDescuento = descuento;
            notaFinal = notaF;
            estadoDetalle = estadoD;
        }

        public DetalleMatricula()
        {
            numFactura = null;
            codigoMateriaAbierta = null;
            porcentajeDescuento = 0;
            notaFinal = 0;
            estadoDetalle = "MAT";
        }
        #endregion

        #region Propiedades
        public Matricula NumFactura { get => numFactura; set => numFactura = value; }
        public MateriasAbiertas CodigoMateriaAbierta { get => codigoMateriaAbierta; set => codigoMateriaAbierta = value; }
        public decimal PorcentajeDescuento { get => porcentajeDescuento; set => porcentajeDescuento = value; }
        public decimal NotaFinal { get => notaFinal; set => notaFinal = value; }
        public string EstadoDetalle { get => estadoDetalle; set => estadoDetalle = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3}", numFactura, codigoMateriaAbierta, porcentajeDescuento, notaFinal);
        }
        #endregion
    }
}
