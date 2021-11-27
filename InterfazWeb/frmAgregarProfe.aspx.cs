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
    public partial class frmAgregarProfe : System.Web.UI.Page
    {

        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaProfesores logicaPR = new LogicaProfesores(Configuracion.getConnectionString);
            DataSet DSProfesores;

            try
            {
                DSProfesores = logicaPR.ListarProfesores(condicion);
                if (DSProfesores.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    GrdVerProfesores.DataSource = DSProfesores;
                    GrdVerProfesores.DataMember = DSProfesores.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                    GrdVerProfesores.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void cargarMateriaAbierta()
        {
            MateriasAbiertas materiaAbierta;
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_CodMateriaAbierta"]));
            txtCodMateriaAbierta.Text = materiaAbierta.CodigoMateriaAbierta.ToString();
            txtCodMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
            txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
            txtCreditosM.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
            txtCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
            txtGrupo.Text = materiaAbierta.Grupo.ToString();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    cargarMateriaAbierta();
                    CargarDataSet();
                }

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar los profesores disponibles {ex.Message}";
            }
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {

            Profesores profesor;
            LogicaProfesores logicaProfe = new LogicaProfesores(Configuracion.getConnectionString);

            int idProfe = int.Parse(e.CommandArgument.ToString());
            profesor = logicaProfe.ObtenerProfesor(idProfe);
            txtCodigoProfe.Text = idProfe.ToString();
            txtNombreProfe.Text = profesor.Nombre;
            txtApellido1P.Text = profesor.Apellido1;
            txtApellido2P.Text = profesor.Apellido2;

        }
    }
}