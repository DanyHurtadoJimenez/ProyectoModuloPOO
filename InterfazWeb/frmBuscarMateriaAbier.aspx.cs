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
    public partial class frmBuscarMateriaAbier : System.Web.UI.Page
    {
        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaMateriaAbierta logicaMateriaAbierta = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            DataSet dsMateriasAbiertas;

            try
            {
                dsMateriasAbiertas = logicaMateriaAbierta.ListarMateriasAbiertas(condicion, 0); //se le manda la condicion si hay y que tipo de proceso lo solicita en este caso para usarse en el modulo de abrir cursos
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
                    CargarDataSet();
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
                GrdListaMaterias.PageIndex = e.NewPageIndex;
                CargarDataSet();

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las Materias {ex.Message}";
            }
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Session["_CodMateriaAbierta"] = id; //obtiene el id y lo manda al formulario de abrir cursos en este caso para poder realizar una modificacion a la materia abierta
            Response.Redirect("FrmAbrirC.aspx");
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