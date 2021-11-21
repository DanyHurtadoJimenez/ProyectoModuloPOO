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
            // MateriasAbiertas materiaAbierta;
            // LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            try
            {
                if (!IsPostBack)
                {
                    DropDownAnios.Items.Add(DateTime.Today.Year.ToString());
                    DropDownAnios.Items.Add(DateTime.Today.AddYears(1).Year.ToString());

                    Session["_mensaje"] = null;
                    if (Session["_CodMateriaCarrera"] != null)
                    {
                        MateriasCarreras materiaCarrera;
                        LogicaMateriaCarrera logicaMAC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
                        materiaCarrera = logicaMAC.ObtenerMateriaCarrera(Convert.ToInt32(Session["_CodMateriaCarrera"]));
                        txtCodigoMateria.Text = materiaCarrera.CodigoMateria.CodigoMateria.ToString();
                        txtNombreMateria.Text = materiaCarrera.CodigoMateria.NombreMateria;
                        txtCreditos.Text = materiaCarrera.CodigoMateria.CreditosMateria.ToString();
                        txtNombreCarrera.Text = materiaCarrera.CodigoCarreras.NombreCarrera;
                    }
                    //if (Session["_CodMateriaAbierta"] != null)
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


        //        int id = int.Parse(e.CommandArgument.ToString());
        //        MateriasCarreras materiaCarr;
        //        LogicaMateriaCarrera logicaMAC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
        //            try
        //            {
        //                materiaCarr = logicaMAC.ObtenerMateriaCarrera(id);
        //                if (materiaCarr != null)
        //                {
        //                    txtCodigoMateria.Text = materiaCarr.CodigoMateria.CodigoMateria.ToString();
        //                    txtNombreMateria.Text = materiaCarr.CodigoMateria.NombreMateria;
        //                    txtCreditos.Text = materiaCarr.CodigoMateria.CreditosMateria.ToString();
        //                    txtNombreCarrera.Text = materiaCarr.CodigoCarreras.NombreCarrera;
        //                }
        //}
        //            catch (Exception)
        //{

        //    Session["_mensaje"] = "Error al Seleccionar la materia";
        //}


        protected void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmBuscarMateria.aspx");
        }

        protected void btnCrearGrupo_Click(object sender, EventArgs e)
        {
            if (txtCodigoMateria.Text != string.Empty && DropDownAnios.SelectedIndex != -1 && nudPeriodo.Text != string.Empty)
            {
                try
                {
                    LogicaMateriaAbierta crearGrupo = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                    int numeroGrupo = crearGrupo.generarGrupo(Convert.ToInt32(Session["_CodMateriaCarrera"]), Convert.ToInt32(DropDownAnios.SelectedItem.ToString()), Convert.ToInt32(nudPeriodo.Text)); //se genera el numero del grupo
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
                materiaA.Existe = true;
            }
            else
            {
                materiaA.CodigoMateriaAbierta = -1;
                materiaA.Existe = false;
            }

            materiaA.CodigoMateriaCarrera.CodigoMateriaCarrera = int.Parse(Session["_CodMateriaCarrera"].ToString());
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



        protected void btnAniadirHorario_Click(object sender, EventArgs e) //cuando se le da a agregar horario se esta abriendo una materia abierta con su respectivo horario, si ya esta existe entonces lo que se realiza es aniadir un horario a la materia sin crearla
        {

            if (!string.IsNullOrEmpty(txtCodigoMateria.Text) && !string.IsNullOrEmpty(txtNombreMateria.Text) && !string.IsNullOrEmpty(txtCreditos.Text) && //vuelve a verificar que todo este lleno
                !string.IsNullOrEmpty(txtNombreCarrera.Text) && !string.IsNullOrEmpty(txtGrupo.Text) && !string.IsNullOrEmpty(nudCupo.Text) &&
                !string.IsNullOrEmpty(txtCosto.Text) && !string.IsNullOrEmpty(nudPeriodo.Text) && DropDownAnios.SelectedIndex != -1 &&
                DropDownListDias.SelectedIndex != -1 && !string.IsNullOrEmpty(txtHoraInicio.Text) && !string.IsNullOrEmpty(txtHoraFin.Text))
            {                                           //aqui estamos creando la materia con el horario hay que verificar primero si esa materia ya existe, si ya existe debe tener un horario por lo que los siguientes horarios que se agregen deben de ser solamente insertados en las tablas de horarios
                LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                MateriasAbiertas materiaA;
                Horarios horario;
                int resultado;

                try
                {
                    materiaA = GenerarEntidadMA();
                    if (materiaA.Existe)
                    {
                        resultado = -1;//aqui se debe de modificar la materia aun se debe de hacer esto *****************************************************************************************************************
                    }
                    else
                    {
                        horario = GenerarEntidadH(materiaA.CodigoMateriaAbierta);
                        resultado = logicaMA.InsertarMateriaAbierta(materiaA,horario);

                        if (resultado > 0)
                        {
                            Session["_mensaje"] = $"Operación realizada satisfactoriamente {logicaMA.Mensaje}";
                        }
                        else
                        {
                            Session["_mensaje"] = $"Hubo un error al insertar la materia y el horario {logicaMA.Mensaje}";
                        }
                    }
                    

                }
                catch (Exception ex)
                {

                    Session["_mensaje"] = $"Error al insertar la materia con el horario {ex.Message}";
                }

            }

        }
    }
}