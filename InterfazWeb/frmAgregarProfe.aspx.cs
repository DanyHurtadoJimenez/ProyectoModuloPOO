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

        private void cargarDatos() //carga todos los datos necesarios como los de la materia y los profesores
        {
            MateriasAbiertas materiaAbierta;
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_CodMateriaAbierta"]));

            if (materiaAbierta.CodigoProfesor.CodigoProfesor != 0) //significa que si tiene un profesor ya asignado
            {
                Profesores profesor;
                LogicaProfesores logicaProfe = new LogicaProfesores(Configuracion.getConnectionString);
                profesor = logicaProfe.ObtenerProfesor(materiaAbierta.CodigoProfesor.CodigoProfesor); //carga el profesor que trae la materia

                txtCodMateriaAbierta.Text = materiaAbierta.CodigoMateriaAbierta.ToString();
                txtCodMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
                txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
                txtCreditosM.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                txtCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
                txtGrupo.Text = materiaAbierta.Grupo.ToString();
                txtPeriodo.Text = materiaAbierta.Periodo.ToString();
                txtAnio.Text = materiaAbierta.Anio.ToString();

                txtCodigoProfe.Text = profesor.CodigoProfesor.ToString();
                txtNombreProfe.Text = profesor.Nombre;
                txtApellido1P.Text = profesor.Apellido1;
                txtApellido2P.Text = profesor.Apellido2;

            }
            else
            {
                txtCodMateriaAbierta.Text = materiaAbierta.CodigoMateriaAbierta.ToString();
                txtCodMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
                txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
                txtCreditosM.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                txtCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
                txtGrupo.Text = materiaAbierta.Grupo.ToString();
                txtPeriodo.Text = materiaAbierta.Periodo.ToString();
                txtAnio.Text = materiaAbierta.Anio.ToString();
            }

        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (!IsPostBack)
                {
                    cargarDatos(); //carga los datos importantes de la materia y profesores si hay
                    CargarDataSet();//carga los profesores disponibles
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

            try
            {
                LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                int resultado;
                resultado = logicaMA.AsignarProfesor(idProfe, Convert.ToInt32(txtCodMateriaAbierta.Text)); //se trata de ingresar al profesor
                Session["_mensaje"] = $"{logicaMA.Mensaje}";

                if (resultado == 0)
                {
                    profesor = logicaProfe.ObtenerProfesor(idProfe); //si se logra asignar el profesor lo muestra
                    txtCodigoProfe.Text = idProfe.ToString();
                    txtNombreProfe.Text = profesor.Nombre;
                    txtApellido1P.Text = profesor.Apellido1;
                    txtApellido2P.Text = profesor.Apellido2;
                }
            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"{ex.Message}";
            }

        }

        protected void btnEliminarProfe_Click(object sender, EventArgs e)
        {
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            int resultado;

            if (!string.IsNullOrEmpty(txtCodigoProfe.Text) && !string.IsNullOrEmpty(txtNombreProfe.Text) &&
                !string.IsNullOrEmpty(txtApellido1P.Text) && !string.IsNullOrEmpty(txtApellido2P.Text) &&
                !string.IsNullOrEmpty(txtCodMateriaAbierta.Text)) //revisa que ya se haya cargado la informacion con la que se trabajará
            {
                try
                {
                    resultado = logicaMA.EliminarProfesor(Convert.ToInt32(txtCodMateriaAbierta.Text), Convert.ToInt32(txtCodigoProfe.Text));
                    if (resultado > 0)
                    {
                        Session["_mensaje"] = "Se ha eliminado el profesor del curso";
                        txtCodigoProfe.Text = string.Empty;
                        txtNombreProfe.Text = string.Empty;
                        txtApellido1P.Text = string.Empty;
                        txtApellido2P.Text = string.Empty;
                    }
                    else
                    {
                        Session["_mensaje"] = "No se pudo eliminar el profesor del curso";
                    }
                }
                catch (Exception ex)
                {

                    Session["_mensaje"] = $"{ex.Message}";
                }

            }
            else
            {
                Session["_mensaje"] = null; 
            }
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            Session["_CodMateriaAbierta"] = txtCodMateriaAbierta.Text;//se mantiene el codigo de la materia abierta para que no se pierdan los datos
            Session["_CodMateriaCarrera"] = null;//SE LIMPIA EL SESSION con la variable de codigo de materia carrera para que permita cargar solamente las materias abiertas cuando se devuelva
            Response.Redirect("FrmAbrirC.aspx");
        }

        protected void GrdVerProfesores_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GrdVerProfesores.PageIndex = e.NewPageIndex;
                CargarDataSet();

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las Materias {ex.Message}";
            }
        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmAgregarAula.aspx");
        }
    }
}