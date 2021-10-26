using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Matricula
    {
        #region Atributos
        private int numeroFactura;
        private Estudiantes carnetEstudiante;
        private DateTime fechaMatricula;
        private decimal montoMatricula;
        private string tipoPago;
        private string comprobantePago;
        private string estadoFactura;
        private string estadoMatricula;
        #endregion

        #region Constructores
        public Matricula(int numFactura, Estudiantes carnetE, DateTime fechaMatri, decimal montoMatri, string tipoPagoMatri, string comprobantePagoMatri, string estadoFacturaMatri, string estadoMatri)
        {
            numeroFactura = numFactura;
            carnetEstudiante = carnetE;
            fechaMatricula = fechaMatri;
            montoMatricula = montoMatri;
            tipoPago = tipoPagoMatri;
            comprobantePago = comprobantePagoMatri;
            estadoFactura = estadoFacturaMatri;
            estadoMatricula = estadoMatri;
        }

        public Matricula()
        {
            numeroFactura = 0;
            carnetEstudiante = null;
            fechaMatricula = DateTime.Today;
            montoMatricula = 0;
            tipoPago = string.Empty;
            comprobantePago = string.Empty;
            estadoFactura = "PEN";
            estadoMatricula = "ACT";
        }
        #endregion

        #region Propiedad
        public int NumeroFactura { get => numeroFactura; set => numeroFactura = value; }
        public Estudiantes CarnetEstudiante { get => carnetEstudiante; set => carnetEstudiante = value; }
        public DateTime FechaMatricula { get => fechaMatricula; set => fechaMatricula = value; }
        public decimal MontoMatricula { get => montoMatricula; set => montoMatricula = value; }
        public string TipoPago { get => tipoPago; set => tipoPago = value; }
        public string ComprobantePago { get => comprobantePago; set => comprobantePago = value; }
        public string EstadoFactura { get => estadoFactura; set => estadoFactura = value; }
        public string EstadoMatricula { get => estadoMatricula; set => estadoMatricula = value; }
        #endregion

        #region Metodos
        public override string ToString()
        {
            return string.Format("{0} - {1} - {2} - {3} - {4}", numeroFactura, carnetEstudiante, fechaMatricula, montoMatricula,tipoPago);
        }
        #endregion
    }
}
