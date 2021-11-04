﻿using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using AccesoDatos;
using System.Data;

namespace LogicaNegocio
{
    public class LogicaMatricula
    {

        #region Atributos

        private string _cadenaConexion;
        private string _mensaje;
        private double subtotal;
        private double montoDescuento;
        private double montoIVA;

        #endregion

        #region Propiedades
        public string Mensaje
        {
            get => _mensaje;
        }

        public string CadenaConexion//set opcional en caso de que en el otro constructor no se le pase la cadenaConexion
        {
            set => _cadenaConexion = value;
        }

        public double Subtotal { get => subtotal;}
        public double MontoDescuento { get => montoDescuento;}
        public double MontoIVA { get => montoIVA; }

        #endregion

        #region Constructor
        public LogicaMatricula() //opcional por si despues otro dv quiera setear la cadena de conexion
        {
            _cadenaConexion = string.Empty;
            _mensaje = string.Empty;
            subtotal = 0;
            montoDescuento = 0;
            montoIVA = 0;
        }

        public LogicaMatricula(string cadenaConexion)
        {
            _cadenaConexion = cadenaConexion;
            _mensaje = string.Empty;
            subtotal = 0;
            montoDescuento = 0;
            montoIVA = 0;
        }
        #endregion

        #region Metodos
        // Convert.ToDecimal(txtDescuentoE.Text), ref subtotal, ref montoDescuento,ref montoIVA, ref totalPagar, ref listaMateriasA
        public double calcularCostos(decimal descuentoEstudiante,List<MateriasAbiertas> materias, double montoMatricula)
        {
            double costos;
            ADMatricula accesoDatos = new ADMatricula(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                costos = accesoDatos.calcularCostos(descuentoEstudiante, materias, ref subtotal,ref montoDescuento, ref montoIVA, montoMatricula);

            }
            catch (Exception)
            {
                throw;
            }

            return costos;
        }

        public int Insertar(Matricula matriculas, List<MateriasAbiertas> materiasA)
        {
            int numFactura = 0;
            ADMatricula accesoDatosMRT = new ADMatricula(_cadenaConexion);
            try
            {
                numFactura = accesoDatosMRT.Insertar(matriculas, materiasA);
            }
            catch (Exception)
            {
                throw;
            }
            _mensaje = accesoDatosMRT.Mensaje;
            return numFactura;
        }

        public DataSet ListarMatriculas(string condicion)
        {
            DataSet DS;
            ADMatricula accesoDatosMatricula = new ADMatricula(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosMatricula.ListarMatriculas(condicion);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        public Matricula ObtenerMatricula(int numFactura)
        {
            Matricula matriculaEstu;
            ADMatricula accesoDatosMRT = new ADMatricula(_cadenaConexion);
            try
            {
                matriculaEstu = accesoDatosMRT.ObtenerMatricula(numFactura);
            }
            catch (Exception)
            {
                throw;
            }

            return matriculaEstu;
        }


        public DataSet ListarMateriasMatriculadas(int numFactura)
        {
            DataSet DS;
            ADMatricula accesoDatosMatricula = new ADMatricula(_cadenaConexion);//se instancia el acceso a los datos

            try
            {
                DS = accesoDatosMatricula.ListarMateriasMatriculadas(numFactura);

            }
            catch (Exception)
            {
                throw;
            }

            return DS;//se devuelve el dataset
        }

        #endregion



    }
}
