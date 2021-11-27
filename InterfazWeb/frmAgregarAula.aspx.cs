using Entidades;
using LogicaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InterfazWeb
{
    public partial class frmAgregarAula : System.Web.UI.Page
    {



        private void cargarDatos() //carga todos los datos necesarios como los de la materia y las aulas
        {
            MateriasAbiertas materiaAbierta;
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_CodMateriaAbierta"]));

            if (materiaAbierta.CodigoAula.CodigoAula != 0) //significa que si tiene un aula ya asignado
            {
                Aulas aula;
                LogicaAula traerAula = new LogicaAula(Configuracion.getConnectionString);
                aula = traerAula.ObtenerAula(materiaAbierta.CodigoAula.CodigoAula);

                txtCodMateriaAbierta.Text = materiaAbierta.CodigoMateriaAbierta.ToString();
                txtCodMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
                txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
                txtCreditosM.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                txtCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
                txtCupo.Text = materiaAbierta.Cupo.ToString();
                txtGrupo.Text = materiaAbierta.Grupo.ToString();
                txtPeriodo.Text = materiaAbierta.Periodo.ToString();
                txtAnio.Text = materiaAbierta.Anio.ToString();

                txtCodigoAula.Text = aula.CodigoAula.ToString();
                txtNumAula.Text = aula.NumeroAula.ToString();
                txtTipoAula.Text = aula.TipoAula;
                txtCapacidadAula.Text = aula.Capacidad.ToString();

            }
            else
            {
                txtCodMateriaAbierta.Text = materiaAbierta.CodigoMateriaAbierta.ToString();
                txtCodMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
                txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
                txtCreditosM.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                txtCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
                txtCupo.Text = materiaAbierta.Cupo.ToString();
                txtGrupo.Text = materiaAbierta.Grupo.ToString();
                txtPeriodo.Text = materiaAbierta.Periodo.ToString();
                txtAnio.Text = materiaAbierta.Anio.ToString();
            }

        }

        private void cargarAulas(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaAula logicaAU = new LogicaAula(Configuracion.getConnectionString);
            DataSet DSAU;

            try
            {
                DSAU = logicaAU.ListarAulas(condicion);
                if (DSAU.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    GrdVerAulas.DataSource = DSAU;
                    GrdVerAulas.DataMember = DSAU.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                    GrdVerAulas.DataBind();
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
                    cargarDatos();
                    cargarAulas();
                }

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar la informacion {ex.Message}";
            }
        }

        protected void GrdVerAulas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GrdVerAulas.PageIndex = e.NewPageIndex;
                cargarAulas();

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las aulas {ex.Message}";
            }
        }

        protected void lnkSeleccionar_Command(object sender, CommandEventArgs e)
        {

            int idAula = int.Parse(e.CommandArgument.ToString());

            try
            {
                Aulas aula;
                MateriasAbiertas materiaAbierta;
                LogicaAula traerAula = new LogicaAula(Configuracion.getConnectionString);
                LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);

                materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_CodMateriaAbierta"])); //obtiene la materia y el aula
                aula = traerAula.ObtenerAula(idAula);

                if (materiaAbierta.Cupo <= aula.Capacidad) //revisa si el cupo de la materia es el adecuado para la capacidad del aula
                {
                    int resultado;
                    resultado = logicaMA.AsignarAula(idAula, materiaAbierta.CodigoMateriaAbierta);//se trata de ingresar el aula
                    Session["_mensaje"] = $"{logicaMA.Mensaje}";

                    if (resultado == 0)
                    {
                        txtCodigoAula.Text = aula.CodigoAula.ToString();
                        txtNumAula.Text = aula.NumeroAula.ToString();
                        txtTipoAula.Text = aula.TipoAula;
                        txtCapacidadAula.Text = aula.Capacidad.ToString();
                    }
                }
                else
                {
                    Session["_mensaje"] = "No se puede asignar esta aula, ya que el cupo de la materia es superior a la capacidad del aula";
                }

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"{ex.Message}";
            }


        }
    }
}