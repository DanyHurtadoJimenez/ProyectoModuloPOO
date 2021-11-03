using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace AccesoDatos
{
    public class ADMatricula
    {

        #region Atributos
        private string _cadenaConexion;
        private string _mensaje;
        #endregion

        #region Propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        #endregion

        #region Constructor

        public ADMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
        }
        #endregion

        #region Metodos

        public double calcularCostos(decimal descuentoEstudiante, List<MateriasAbiertas> materias, int montoMatricula)
        { 
            double totalPagar = 0;
            double descuento = 0;
            double iva = 0;

            for (int i = 0; i < materias.Count; i++)
            {
                totalPagar += Convert.ToDouble(materias[i].Costo);
            }

            totalPagar += montoMatricula;

            descuento = totalPagar * (Convert.ToDouble(descuentoEstudiante));//se calcula el descuento
            iva = totalPagar * 0.13; //se calcula el iva
            totalPagar += iva;//se graba el iva
            totalPagar -= descuento; //se aplica el descuento

            return totalPagar;

        }

        

        #endregion

    }
}
