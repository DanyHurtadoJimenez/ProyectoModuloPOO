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



        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    DropDownAnios.Items.Add(DateTime.Today.Year.ToString());
                    DropDownAnios.Items.Add(DateTime.Today.AddYears(1).Year.ToString());
                    txtHoraInicio.Text = "07:00";
                    txtHoraFin.Text = "08:00";

                    Session["_mensaje"] = null;
                    if (Session["_CodMateriaCarrera"] != null)
                    {
                        MateriasCarreras materiaCarrera;
                        LogicaMateriaCarrera logicaMAC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
                        materiaCarrera = logicaMAC.ObtenerMateriaCarrera(Convert.ToInt32(Session["_CodMateriaCarrera"]));
                        txtCodMateriaCarrera.Text = Session["_CodMateriaCarrera"].ToString();
                        txtCodigoMateria.Text = materiaCarrera.CodigoMateria.CodigoMateria.ToString();
                        txtNombreMateria.Text = materiaCarrera.CodigoMateria.NombreMateria;
                        txtCreditos.Text = materiaCarrera.CodigoMateria.CreditosMateria.ToString();
                        txtNombreCarrera.Text = materiaCarrera.CodigoCarreras.NombreCarrera;
                    }
                    else if (Session["_CodMateriaAbierta"] != null)
                    {
                        MateriasAbiertas materiaAbierta;
                        LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                        materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_CodMateriaAbierta"]));
                        txtCodMateriaCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera.ToString();
                        txtCodigoMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
                        txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
                        txtCreditos.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                        txtNombreCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
                        txtGrupo.Text = materiaAbierta.Grupo.ToString();
                        nudCupo.Text = materiaAbierta.Cupo.ToString();
                        txtCosto.Text = Convert.ToInt32(materiaAbierta.Costo).ToString();
                        nudPeriodo.Text = materiaAbierta.Periodo.ToString();
                        DropDownAnios.SelectedValue = Convert.ToInt32(materiaAbierta.Anio).ToString();
                        CargarDataSet(materiaAbierta.CodigoMateriaAbierta); //carga los horarios que la materia tenga 
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        protected void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            btnCrearGrupo.Enabled = true;
            Session["_CodMateriaAbierta"] = null;
            Response.Redirect("FrmBuscarMateria.aspx");
        }

        protected void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (txtCodigoMateria.Text != string.Empty && DropDownAnios.SelectedIndex != -1 && nudPeriodo.Text != string.Empty)
            {
                try
                {
                    LogicaMateriaAbierta crearGrupo = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                    int numeroGrupo = crearGrupo.generarGrupo(Convert.ToInt32(txtCodMateriaCarrera.Text), Convert.ToInt32(DropDownAnios.SelectedItem.ToString()), Convert.ToInt32(nudPeriodo.Text)); //se genera el numero del grupo
                    txtGrupo.Text = numeroGrupo.ToString();
                }
                catch (Exception ex)
                {

                    Session["_mensaje"] = $"Error al generar el numero de grupo {ex.Message}";
                }

            }
            else
            {
                Session["_mensaje"] = "Debe especificar primero el año y el periodo para la materia";
            }
        }

        private MateriasAbiertas GenerarEntidadMA()
        {
            MateriasAbiertas materiaA = new MateriasAbiertas();
            materiaA.CodigoMateriaCarrera = new MateriasCarreras();
            if (Session["_CodMateriaAbierta"] != null)
            {
                materiaA.CodigoMateriaAbierta = int.Parse(Session["_CodMateriaAbierta"].ToString());
                materiaA.CodigoMateriaCarrera.CodigoMateriaCarrera = Convert.ToInt32(txtCodMateriaCarrera.Text);
                materiaA.Existe = true;
            }
            else
            {
                materiaA.CodigoMateriaAbierta = -1;
                materiaA.CodigoMateriaCarrera.CodigoMateriaCarrera = int.Parse(Session["_CodMateriaCarrera"].ToString());
                materiaA.Existe = false;
            }


            materiaA.Grupo = Convert.ToInt32(txtGrupo.Text);
            materiaA.Cupo = Convert.ToInt32(nudCupo.Text);
            materiaA.Costo = Convert.ToDecimal(txtCosto.Text);
            materiaA.Periodo = Convert.ToInt32(nudPeriodo.Text);
            materiaA.Anio = Convert.ToInt32(DropDownAnios.SelectedValue);

            return materiaA;

        }

        private Horarios GenerarEntidadH(int codMateriaAbierta)
        {
            Horarios horario = new Horarios();
            horario.CodigoMateriaAbierta = new MateriasAbiertas();

            horario.CodigoMateriaAbierta.CodigoMateriaAbierta = codMateriaAbierta;
            horario.Dia = DropDownListDias.SelectedValue;
            horario.HoraInicio = Convert.ToDateTime(txtHoraInicio.Text);
            horario.HoraFin = Convert.ToDateTime(txtHoraFin.Text);


            return horario;

        }

        private void CargarDataSet(int codMateriaAbierta) //carga los horarios en el datagrid
        { //carga el datagridview con el dataset
            LogicaHorarios logicaH = new LogicaHorarios(Configuracion.getConnectionString);
            DataSet DSMateriaCarrera;

            try
            {
                DSMateriaCarrera = logicaH.ListarHorarios(codMateriaAbierta);

                if (DSMateriaCarrera != null) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    GrdVerHorarios.DataSource = DSMateriaCarrera;
                    GrdVerHorarios.DataMember = DSMateriaCarrera.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                    GrdVerHorarios.DataBind();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        protected void btnAniadirHorario_Click(object sender, EventArgs e) //cuando se le da a agregar horario se esta abriendo una materia abierta con su respectivo horario, si ya esta existe entonces lo que se realiza es aniadir un horario a la materia sin crearla
        {

            if (!string.IsNullOrEmpty(txtCodigoMateria.Text) && !string.IsNullOrEmpty(txtNombreMateria.Text) && !string.IsNullOrEmpty(txtCreditos.Text) && //vuelve a verificar que todo este lleno
                !string.IsNullOrEmpty(txtNombreCarrera.Text) && !string.IsNullOrEmpty(txtGrupo.Text) && !string.IsNullOrEmpty(nudCupo.Text) &&
                !string.IsNullOrEmpty(txtCosto.Text) && !string.IsNullOrEmpty(nudPeriodo.Text) && DropDownAnios.SelectedIndex != -1 &&
                DropDownListDias.SelectedIndex != -1 && !string.IsNullOrEmpty(txtHoraInicio.Text) && !string.IsNullOrEmpty(txtHoraFin.Text))
            {
                LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                MateriasAbiertas materiaA;
                Horarios horario;
                int resultado;

                try
                {
                    materiaA = GenerarEntidadMA();
                    if (materiaA.Existe)
                    {  //modificar materia abierta
                        horario = GenerarEntidadH(materiaA.CodigoMateriaAbierta);
                        resultado = logicaMA.InsertarMateriaAbierta(materiaA, horario, Convert.ToInt16(Session["_CodMateriaAbierta"])); //si ya existe la materia entonces solo hay que agregarle el horario y modificarla 
                        CargarDataSet(materiaA.CodigoMateriaAbierta); //carga el datagrid con los horarios de esa materia abierta
                    }
                    else
                    { //crear materia abierta
                        horario = GenerarEntidadH(materiaA.CodigoMateriaAbierta);
                        resultado = logicaMA.InsertarMateriaAbierta(materiaA, horario, Convert.ToInt16(Session["_CodMateriaAbierta"]));

                        if (resultado > 0)//si el resultado es mayor que 0 la materia abierta si existe y se guarda en el session
                        {
                            Session["_CodMateriaAbierta"] = resultado;
                            CargarDataSet(resultado); //carga el datagrid con los horarios de esa materia abierta
                        }
                        else
                        {
                            Session["_CodMateriaAbierta"] = null; //si aun no se ha creado la materia abierta no debe existir la variable en el session
                        }
                    }

                    Session["_mensaje"] = $"{logicaMA.Mensaje}";


                }
                catch (Exception ex)
                {

                    Session["_mensaje"] = $"Error al insertar la materia con el horario {ex.Message}";
                }

            }

        }

        protected void btnModificarMateria_Click(object sender, EventArgs e)
        {
            Session["_CodMateriaCarrera"] = null;
            //btnCrearGrupo.Enabled = false;
            Response.Redirect("FrmBuscarMateriaAbierta.aspx");
        }

        protected void lnkEliminar_Command(object sender, CommandEventArgs e)
        {
            int cantidadHorarios;
            LogicaHorarios logicaH = new LogicaHorarios(Configuracion.getConnectionString);
            cantidadHorarios = logicaH.contarHorarios(int.Parse(Session["_CodMateriaAbierta"].ToString())); //se fija primero cuantos horarios posee esa materia, si ya solo tiene uno no le permite borrarlo
            if (cantidadHorarios > 1)
            {
                int id = int.Parse(e.CommandArgument.ToString()); //obtiene el codigo del horario para eliminarlo
                logicaH.eliminarHorario(id);
                Session["_mensaje"] = $"{logicaH.Mensaje}";
                CargarDataSet(int.Parse(Session["_CodMateriaAbierta"].ToString()));
            }
            else
            {
                Session["_mensaje"] = "No puede eliminar este horario, porque la materia no puede estar registrada sin horarios.";
            }

        }

        protected void btnSiguiente_Click(object sender, EventArgs e)
        {
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            MateriasAbiertas materiaA;
            materiaA = GenerarEntidadMA(); //OBTIENE LOS DATOS QUE ESTAN EN EL FORMULARIO PARA MODIFICAR LA MATERIA ABIERTA
            logicaMA.modificarMateriaAbierta(materiaA);
            Session["_mensaje"] = null;
            Response.Redirect("frmAgregarProfe.aspx");
        }

        protected void GrdVerHorarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            try
            {
                GrdVerHorarios.PageIndex = e.NewPageIndex;
                CargarDataSet(Convert.ToInt32(Session["_CodMateriaAbierta"]));

            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"Error al cargar las Materias {ex.Message}";
            }
        }
    }
}