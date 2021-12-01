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
                    lblMontoMatricula.Text = valoresR.ValorMatricula.ToString();

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

                    if (Session["_codCurso"] != null) // se fija si existe un codigo de curso en la session el cual proviene de haber escogido cursos, si es asi entonces llame al metodo de matricular, para matricular ese curso escogido
                    {

                        matricular();
                    }

                }
            }
            catch (Exception ex)
            {
                Session["_mensaje"] = $"{ex.Message}";
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

        private void CargarMateriasGridView(DataSet DS)
        {

            if (DS.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
            {
                GrdVerMaterias.DataSource = DS;
                GrdVerMaterias.DataMember = DS.Tables[0].TableName; //se carga el dataset
                GrdVerMaterias.DataBind();
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
                    CargarMateriasGridView(materias);

                    calcularCostos(materias); // se vuelven a calcular los costos
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

        private void calcularCostos(DataSet materias)
        { //esta funcion permite calcular los costos de la matricula

            LogicaMatricula costosM = new LogicaMatricula();
            lblTotalPagar.Text = costosM.calcularCostos(Convert.ToDecimal(txtDescuento.Text), materias, Convert.ToDouble(lblMontoMatricula.Text)).ToString();///////////////////////////////////////////////////////////////
            lblSubtotal.Text = costosM.Subtotal.ToString();
            lblDescuentoEstudiante.Text = txtDescuento.Text;
            lblMontoDescuento.Text = costosM.MontoDescuento.ToString();
            lblMontoIva.Text = costosM.MontoIVA.ToString();
        }

        protected void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmBuscarAlumnos.aspx");
        }

        protected void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            Response.Redirect("FrmBuscarCursosAbiertos.aspx");

        }

        private Matricula generarEntidad()
        {
            LogicaMatricula traerMatricula = new LogicaMatricula(Configuracion.getConnectionString);
            Matricula matricula;

            if (!string.IsNullOrEmpty(txtNumFactura.Text))
            {
                matricula = traerMatricula.ObtenerMatricula(Convert.ToInt32(txtNumFactura.Text));
                matricula.Existe = true;
            }
            else
            {
                matricula = new Matricula();
                matricula.CarnetEstudiante = new Estudiantes();
                matricula.NumeroFactura = -1;
                matricula.CarnetEstudiante.CarnetEstudiante = txtCarnet.Text;
                matricula.FechaMatricula = Convert.ToDateTime(txtFechaMatricula.Text);
                matricula.MontoMatricula = Convert.ToDecimal(lblTotalPagar.Text);
            }
            return matricula;
        }


        private void matricular()
        {
            try
            {
                MateriasAbiertas materiaAbierta;
                DataSet materias;
                LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                LogicaMatricula logicaMatricula = new LogicaMatricula(Configuracion.getConnectionString);
                LogicaHorarios logicaH = new LogicaHorarios(Configuracion.getConnectionString);

                int estudianteCumple = 1;
                if (Session["_codCurso"] != null)
                {
                    materiaAbierta = logicaMA.ObtenerMateriaAbierta(Convert.ToInt32(Session["_codCurso"]));

                    if (materiaAbierta != null)
                    {
                        if (materiaAbierta.CodigoMateriaCarrera.Requisito.CodigoMateria != string.Empty) //verifica si la materia posee requisito, si tiene requisito entonces se debe revisar si el estudiante posee ese requisito
                        {
                            estudianteCumple = logicaMA.verificarRequisitos(txtCarnet.Text, materiaAbierta.CodigoMateriaCarrera.Requisito.CodigoMateria);
                        }

                        if (estudianteCumple == 1) //verifica si el estudiante cuenta con el requisito para matricular la materia escogida
                        {
                            if (!string.IsNullOrEmpty(txtNumFactura.Text)) //si no esta vacio quiere decir que se esta modificando una matricula, porque ya se busco anteriormente y se quieren agregar o eliminar materias
                            {
                                if (logicaMatricula.verificarMateriasRepetidas(materiaAbierta.CodigoMateriaAbierta, Convert.ToInt32(txtNumFactura.Text)) == 0)//verifica si la materia escogida se repite en las que ya tiene matriculadas
                                {
                                    if (logicaH.verificarChoqueMateria(txtCarnet.Text, materiaAbierta.CodigoMateriaAbierta) == 0) //verifica que las materias que escoje el usuario no choquen en sus horarios
                                    {
                                        LogicaMatricula logicaM = new LogicaMatricula(Configuracion.getConnectionString);
                                        Matricula matricula;
                                        int numFactura;

                                        matricula = generarEntidad();
                                        numFactura = logicaM.Insertar(matricula, Convert.ToInt32(Session["_codCurso"]), Convert.ToInt32(txtNumFactura.Text));

                                        materias = logicaMatricula.ListarMateriasMatriculadas(numFactura); //obtiene en un dataset las materias matriculadas pertenecientes al numero de factura respectivo
                                        CargarMateriasGridView(materias);//se carga la materia en el datagrid para poder verla
                                        calcularCostos(materias); // se calculan los costos
                                        Session["_codCurso"] = null; //borra la variable en session para evitar que vuelva a matricular la misma la proxima vez que cargue el forms

                                    }
                                    else
                                    {
                                        Session["_mensaje"] = $"{logicaH.Mensaje}";
                                        Session["_codCurso"] = null;
                                    }
                                }
                                else
                                {
                                    Session["_mensaje"] = $"{logicaMatricula.Mensaje}";
                                    Session["_codCurso"] = null;
                                }
                            }
                            else //si esta vacio ese espacio quiere decir que se esta creando una matricula desde 0 entonces no se debe verificar ni choques de horas ni materias repetidas
                            {
                                Matricula matricula;

                                materias = llenarDataset(materiaAbierta); //llena el dataset con la materia seleccionada para poder pasarla a calcular costos que necesita un dataset para calcular y mostrar montos
                                calcularCostos(materias); // se calculan los costos
                                matricula = generarEntidad();

                                int numFactura;
                                numFactura = logicaMatricula.Insertar(matricula, Convert.ToInt32(Session["_codCurso"]), matricula.NumeroFactura); //inserta matricula
                                txtNumFactura.Text = numFactura.ToString();

                                materias = logicaMatricula.ListarMateriasMatriculadas(numFactura); //obtiene en un dataset las materias matriculadas pertenecientes al numero de factura respectivo
                                CargarMateriasGridView(materias);//se carga la materia en el datagrid para poder verla
                                Session["_codCurso"] = null;
                            }
                        }
                        else
                        {
                            Session["_mensaje"] = $"{logicaMA.Mensaje}";
                        }
                    }
                    else
                    {
                        Session["_mensaje"] = "Error La materia no se encuentra en la base de datos";
                        Session["_codCurso"] = null;
                    }

                }

            }
            catch (Exception)
            {

                throw;
            }

        }

        private DataSet llenarDataset(MateriasAbiertas materia)
        {
            DataSet DS = new DataSet();

            DataTable DT = new DataTable();
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.Decimal");
            column.ColumnName = "Costo";
            DT.Columns.Add(column);

            DT.Rows.Add(new object[] { materia.Costo });

            DS.Tables.Add(DT);

            return DS;

        }

        protected void lnkEliminar_Command(object sender, CommandEventArgs e)
        {
            LogicaMatricula matricula = new LogicaMatricula(Configuracion.getConnectionString);
            DataSet materias;
            int id = int.Parse(e.CommandArgument.ToString());//obtiene el id
            matricula.EliminarMateriasE(Convert.ToInt32(txtNumFactura.Text), id);
            Session["_mensaje"] = $"{matricula.Mensaje}";
            materias = matricula.ListarMateriasMatriculadas(Convert.ToInt32(txtNumFactura.Text)); //obtiene en un dataset las materias matriculadas pertenecientes al numero de factura respectivo
            CargarMateriasGridView(materias);//se carga la materia en el datagrid para poder verla
            calcularCostos(materias); // se calculan los costos
        }

        protected void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dropDownTipoPago.SelectedIndex != -1)
                {
                    int resultado;
                    LogicaMatricula logicaM = new LogicaMatricula(Configuracion.getConnectionString);
                    Matricula matricula;
                    matricula = generarEntidad();
                    resultado = logicaM.Facturar(matricula.NumeroFactura, dropDownTipoPago.SelectedValue.ToString());
                    if (resultado > 0)
                    {
                        //aqui se mostraria el formulario del recibo de la matricula
                    }
                }
                else
                {
                    Session["_mensaje"] = "Debe escoger un tipo de pago";
                }
            }
            catch (Exception ex)
            {

                Session["_mensaje"] = $"{ex.Message}";
            }

        }
    }

}








