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
    public partial class FrmMatricular : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                if (!IsPostBack)
                {
                    txtFechaMatricula.Text = DateTime.Today.ToString("yyyy-MM-dd");
                    LogicaValoresReferencia logicaValores = new LogicaValoresReferencia(Configuracion.getConnectionString); //se obtiene el periodo y el anio correspondiente
                    ValoresReferencia valoresR = new ValoresReferencia();
                    valoresR = logicaValores.RecuperarPeriodoAnio();
                    txtPeriodo.Text = valoresR.Periodo.ToString();
                    txtAnio.Text = valoresR.Anio.ToString();
                    //lblMontoMatricula.Text = valoresR.ValorMatricula.ToString();

                    if (Session["_CarnetEstudiante"] != null)
                    {
                        LogicaMatricula logicaM = new LogicaMatricula(Configuracion.getConnectionString);
                        int numFactura = logicaM.VerificarMatriculaPendiente(Session["_CarnetEstudiante"].ToString());

                        if (numFactura > 0) //si el estudiante posee una matricula activa y pendiente entonces carguela en la pantalla
                        {
                            CargarMatricula(numFactura); //carga la informacion en la pantalla
                        }
                        else //sino la tiene entonces debe crearla
                        {
                            cargarEstudiante(Session["_CarnetEstudiante"].ToString());
                        }
                    }
                }
                //if (!IsPostBack)
                //{
                //    DropDownAnios.Items.Add(DateTime.Today.Year.ToString());
                //    DropDownAnios.Items.Add(DateTime.Today.AddYears(1).Year.ToString());
                //    txtHoraInicio.Text = "07:00";
                //    txtHoraFin.Text = "08:00";

                //    Session["_mensaje"] = null;
                //    if (Session["_CodMateriaCarrera"] != null)
                //    {
                //        MateriasCarreras materiaCarrera;
                //        LogicaMateriaCarrera logicaMAC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
                //        materiaCarrera = logicaMAC.ObtenerMateriaCarrera(Convert.ToInt32(Session["_CodMateriaCarrera"]));
                //        txtCodMateriaCarrera.Text = Session["_CodMateriaCarrera"].ToString();
                //        txtCodigoMateria.Text = materiaCarrera.CodigoMateria.CodigoMateria.ToString();
                //        txtNombreMateria.Text = materiaCarrera.CodigoMateria.NombreMateria;
                //        txtCreditos.Text = materiaCarrera.CodigoMateria.CreditosMateria.ToString();
                //        txtNombreCarrera.Text = materiaCarrera.CodigoCarreras.NombreCarrera;
                //    }
                //    else if (Session["_CodMateriaAbierta"] != null)
                //    {
                //        MateriasAbiertas materiaAbierta;
                //        LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                //        materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_CodMateriaAbierta"]));
                //        txtCodMateriaCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera.ToString();
                //        txtCodigoMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CodigoMateria;
                //        txtNombreMateria.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.NombreMateria;
                //        txtCreditos.Text = materiaAbierta.CodigoMateriaCarrera.CodigoMateria.CreditosMateria.ToString();
                //        txtNombreCarrera.Text = materiaAbierta.CodigoMateriaCarrera.CodigoCarreras.NombreCarrera;
                //        txtGrupo.Text = materiaAbierta.Grupo.ToString();
                //        nudCupo.Text = materiaAbierta.Cupo.ToString();
                //        txtCosto.Text = Convert.ToInt32(materiaAbierta.Costo).ToString();
                //        nudPeriodo.Text = materiaAbierta.Periodo.ToString();
                //        DropDownAnios.SelectedValue = Convert.ToInt32(materiaAbierta.Anio).ToString();
                //        CargarDataSet(materiaAbierta.CodigoMateriaAbierta); //carga los horarios que la materia tenga 
                //    }
                //}
            }
            catch (Exception ex)
            {
                Session["_mensaje"] = $"Error al generar el numero de grupo {ex.Message}";
            }
        }


        private void cargarEstudiante(string codAlumno)
        {
            Estudiantes estudiante;
            LogicaEstudiante logicaAlumno = new LogicaEstudiante(Configuracion.getConnectionString);
            estudiante = logicaAlumno.ObtenerEstudiante(codAlumno);

            if (estudiante != null)
            {
                txtCarnet.Text = estudiante.CarnetEstudiante;
                txtCedula.Text = estudiante.Cedula;
                txtNombre.Text = string.Format("{0} {1} {2}", estudiante.Nombre, estudiante.Apellido1, estudiante.Apellido2);
                txtEmail.Text = estudiante.CorreoElectronico;
                txtDescuento.Text = estudiante.Descuento.ToString();
            }
            else
            {
                Session["_mensaje"] = " ERROR, El estudiante no se encuentra en la base de datos";
            }

        }

        private void CargarMatricula(int numFactura)
        {
            Matricula matriculaEstudiante;
            DataSet materias;
            LogicaMatricula traerMatricula = new LogicaMatricula(Configuracion.getConnectionString);
            try
            {
                matriculaEstudiante = traerMatricula.ObtenerMatricula(numFactura);
                if (matriculaEstudiante != null)
                {
                    txtNumFactura.Text = matriculaEstudiante.NumeroFactura.ToString();
                    txtFechaMatricula.Text = matriculaEstudiante.FechaMatricula.ToString("yyyy-MM-dd");
                    txtCarnet.Text = matriculaEstudiante.CarnetEstudiante.CarnetEstudiante;
                    txtCedula.Text = matriculaEstudiante.CarnetEstudiante.Cedula;
                    txtNombre.Text = matriculaEstudiante.CarnetEstudiante.Nombre;
                    txtEmail.Text = matriculaEstudiante.CarnetEstudiante.CorreoElectronico;
                    txtDescuento.Text = matriculaEstudiante.CarnetEstudiante.Descuento.ToString();
                    //comboTipoPago.SelectedItem = matriculaEstudiante.TipoPago.ToString();
                    materias = traerMatricula.ListarMateriasMatriculadas(matriculaEstudiante.NumeroFactura); //obtiene en un dataset las materias matriculadas pertenecientes al numero de factura respectivo

                    if (materias.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                    {
                        //MateriasAbiertas materiaAbierta;
                        //LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                        //int codMateriaAbierta = 0;

                        GrdVerMaterias.DataSource = materias;
                        GrdVerMaterias.DataMember = materias.Tables[0].TableName; //se carga el dataset
                        GrdVerMaterias.DataBind();

                        //for (int i = 0; i < dtgvVerMateriaAbierta.Rows.Count; i++)
                        //{
                        //    codMateriaAbierta = (int)(dtgvVerMateriaAbierta.Rows[i].Cells[0].Value); //tome el primer valor del data grid que son los codigos de materiasAbiertas y busquelos para insertarlos en el arreglo de materias abiertas

                        //    materiaAbierta = logicaMA.ObtenerMateriaAbierta(codMateriaAbierta);
                        //    listaMateriasA.Add(materiaAbierta);//se ingresa la materia abierta dentro del arreglo
                        //}
                    }

                    //calcularCostos(); // se vuelven a calcular los costos
                }
                else
                {
                    Session["_mensaje"] = "La matricula no existe en la base de datos";
                }
            }
            catch (Exception)
            {
                throw;
            }
        }



        protected void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmBuscarAlumnos.aspx");
        }

        protected void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmBuscarCursosAbiertos.aspx");
        }
    }
}