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
    public partial class FrmAbrirC : System.Web.UI.Page
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
            catch (Exception ex)
            {
                //Session["_mensaje"] = $"Error al cargar las materias {ex.Message}";
                throw;
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            MateriasAbiertas materiaAbierta;
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            try
            {
                if (!IsPostBack)
                {
                    DropDownAnios.Items.Add(DateTime.Today.Year.ToString());
                    DropDownAnios.Items.Add(DateTime.Today.AddYears(1).Year.ToString());
                    CargarDataSet();
                    //Session["_mensaje"] = null;
                    //if (Session["CodMateriaAbierta"] != null)
                    //{
                    //    materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["CodMateriaAbierta"]));
                    //    txtCodigoMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera.ToString();
                    //    txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria.ToString();
                    //    txtCreditos.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                    //    txtNombreCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.CodigoCarrera.ToString();
                    //    txtGrupo.Text = materiaAbierta.Grupo.ToString();
                    //    nudCupo.Text = materiaAbierta.Cupo.ToString();
                    //    txtCosto.Text = materiaAbierta.Costo.ToString();
                    //    DropDownAnios.SelectedValue = materiaAbierta.Anio.ToString();

                    //}
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

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {
            int id = int.Parse(e.CommandArgument.ToString());
            MateriasCarreras materiaCarr;
            LogicaMateriaCarrera logicaMAC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
            try
            {
                materiaCarr = logicaMAC.ObtenerMateriaCarrera(id);
                if (materiaCarr != null)
                {
                    txtCodigoMateria.Text = materiaCarr.CodigoMateria.ToString();
                    txtNombreMateria.Text = materiaCarr.CodigoMateria.NombreMateria;
                    txtCreditos.Text = materiaCarr.CodigoMateria.CreditosMateria.ToString();
                    txtNombreCarrera.Text = materiaCarr.CodigoCarreras.NombreCarrera;
                }
            }
            catch (Exception)
            {

                Session["_mensaje"] = "Error al Seleccionar la materia";
            }
        }
    }
}