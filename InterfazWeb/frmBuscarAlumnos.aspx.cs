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
    public partial class frmBuscarAlumnos : System.Web.UI.Page
    {
        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaEstudiante logicaEstudiante = new LogicaEstudiante(Configuracion.getConnectionString);
            DataSet dsEstudiantes;

            try
            {
                dsEstudiantes = logicaEstudiante.ListarEstudiante(condicion);
                if (dsEstudiantes.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    GrdEstudiantes.DataSource = dsEstudiantes;
                    GrdEstudiantes.DataMember = dsEstudiantes.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                    GrdEstudiantes.DataBind();
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

                Session["_mensaje"] = $"Error al cargar la informacion {ex.Message}";
            }
        }

        protected void GrdEstudiantes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GrdEstudiantes.PageIndex = e.NewPageIndex;
                CargarDataSet();

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar los estudiantes {ex.Message}";
            }
        }

        protected void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            try
            {
                string condicion = $"CarnetEstudiante like '%{txtCarnetEstudiante.Text.Trim()}%' and NombreEstudiante like '%{txtNombreEstudiante.Text.Trim()}%'";
                CargarDataSet(condicion);
            }
            catch (Exception)
            {

                Session["_mensaje"] = "Error al buscar la materia";
            }
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            string idEstudiante = e.CommandArgument.ToString();
            Session["_CarnetEstudiante"] = idEstudiante; //obtiene el id y lo manda al formulario de matricular
            Response.Redirect("FrmMatricular.aspx");
        }
    }
}