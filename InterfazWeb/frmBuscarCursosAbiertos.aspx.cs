using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using LogicaNegocio;
using Entidades;
using System.Data;

namespace InterfazWeb
{
    public partial class frmBuscarCursosAbiertos : System.Web.UI.Page
    {

        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaMateriaAbierta logicaMateriaAbierta = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            DataSet dsMateriasAbiertas;

            try
            {
                dsMateriasAbiertas = logicaMateriaAbierta.ListarMateriasAbiertas(condicion, 1); //se le manda la condicion si hay y que tipo de proceso lo solicita en este caso para usarse en el modulo de matricular cursos
                if (dsMateriasAbiertas.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    GrdListaMaterias.DataSource = dsMateriasAbiertas;
                    GrdListaMaterias.DataMember = dsMateriasAbiertas.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                    GrdListaMaterias.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    ValoresReferencia valoresR;
                    valoresR = ObtenerAnioPeriodo();//se obtiene el periodo y el anio en la que se esta realizando la matricula
                    string condicion = string.Format("Periodo = {0} and anio = {1}", valoresR.Periodo, valoresR.Anio); //se construye la condicion para recuperar solo las materias abiertas del periodo de la matricula

                    CargarDataSet(condicion);
                }

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las materias {ex.Message}";
            }
        }

        protected void GrdListaMaterias_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                ValoresReferencia valoresR;
                valoresR = ObtenerAnioPeriodo();//se obtiene el periodo y el anio en la que se esta realizando la matricula

                string condicion = string.Format("Periodo = {0} and anio = {1}", valoresR.Periodo, valoresR.Anio); //se construye la condicion para recuperar solo las materias abiertas del periodo de la matricula

                GrdListaMaterias.PageIndex = e.NewPageIndex;
                CargarDataSet(condicion);

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las Materias {ex.Message}";
            }
        }

        private ValoresReferencia ObtenerAnioPeriodo() //obtiene el periodo y el anio en el cual se esta cursando actualmente
        {

            LogicaValoresReferencia logicaValores = new LogicaValoresReferencia(Configuracion.getConnectionString); //se obtiene el periodo y el anio correspondiente
            ValoresReferencia valoresR = new ValoresReferencia();
            valoresR = logicaValores.RecuperarPeriodoAnio();

            return valoresR;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = $"CodigoMateria like '%{txtCodigoMateria.Text.Trim()}%' and NombreMateria like '%{txtNombreMateria.Text.Trim()}%'";
                CargarDataSet(condicion);
            }
            catch (Exception)
            {

                Session["_mensaje"] = "Error al buscar la materia";
            }
        }
    }
}