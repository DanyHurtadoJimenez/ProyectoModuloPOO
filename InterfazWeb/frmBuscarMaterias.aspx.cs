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
    public partial class frmBuscarMaterias : System.Web.UI.Page
    {
        private void CargarDataSet(string condicion = "") //carga las materias carreras en el modal
        { //carga el datagridview con el dataset
            LogicaMateriaCarrera logicaMC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
            DataSet DSMateriaCarrera;

            try
            {
                DSMateriaCarrera = logicaMC.ListarMateriasCarreras(condicion);

                if (DSMateriaCarrera != null) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    GrdListaMaterias.DataSource = DSMateriaCarrera;
                    GrdListaMaterias.DataMember = DSMateriaCarrera.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                    GrdListaMaterias.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
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

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDataSet();
            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las materias {ex.Message}";
            }
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            Session["_CodMateriaCarrera"] = id;
            Response.Redirect("FrmAbrirC.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = $"MC.CodigoMateria like '%{txtCodigoMateria.Text.Trim()}%' and M.NombreMateria like '%{txtNombreMateria.Text.Trim()}%'";
                CargarDataSet(condicion);
            }
            catch (Exception)
            {

                Session["_mensaje"] = "Error al buscar la materia";
            }

        }
    }
}