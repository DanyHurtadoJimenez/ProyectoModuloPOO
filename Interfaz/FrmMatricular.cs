using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Entidades;
using LogicaNegocio;

namespace Interfaz
{
    public partial class FrmMatricular : Form
    {

        //variables globales 

        Matricula matriculaERegistrado;

        List<MateriasAbiertas> listaMateriasA = new List<MateriasAbiertas>();
        List<Horarios> horariosMaterias = new List<Horarios>();

        public FrmMatricular()
        {

            InitializeComponent();
        }

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            FrmBuscarEstudiante frmEstudiantes = new FrmBuscarEstudiante();
            frmEstudiantes.MandarEstudiante += new EventHandler(TraerEstudiante);
            frmEstudiantes.ShowDialog();
        }

        private void TraerEstudiante(object codEstudiante, EventArgs e)
        {
            try
            {
                string codAlumno = codEstudiante.ToString();
                if (codAlumno != string.Empty)
                {
                    Estudiantes estudiante;
                    LogicaEstudiante logicaAlumno = new LogicaEstudiante(Configuracion.getConnectionString);
                    estudiante = logicaAlumno.ObtenerEstudiante(codAlumno);

                    if (estudiante != null)
                    {
                        txtCarnetEstudiante.Text = estudiante.CarnetEstudiante;
                        txtCedulaEstudiante.Text = estudiante.Cedula;
                        txtNombreEstudiante.Text = string.Format("{0} {1} {2}", estudiante.Nombre,estudiante.Apellido1,estudiante.Apellido2);
                        txtEmailE.Text = estudiante.CorreoElectronico;
                        txtDescuentoE.Text = estudiante.Descuento.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El estudiante no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }



        private void TraerMateria(object codMateriaAbierta, EventArgs e)
        {

            try
            {
                int codMA = (int)codMateriaAbierta;
                if (codMA != -1)
                {
                    MateriasAbiertas materiaAbierta;
                    DataSet horario;
                    LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                    LogicaHorarios logicaH = new LogicaHorarios(Configuracion.getConnectionString);
                    materiaAbierta = logicaMA.ObtenerMateriaAbierta(codMA); //se busca la materia para pasarla a la lista y guardarla y para mostrarla en el datagrid

                    if (materiaAbierta != null)
                    {

                        if (logicaMA.verificarChoquesMaterias(txtCarnetEstudiante.Text,materiaAbierta.CodigoMateriaCarrera.Requisito.CodigoMateria) ==1 )
                        {
                            if (listaMateriasA.Count > 0)
                            {
                                int i = 0;
                                int contador = 0;

                                while (i < listaMateriasA.Count) //con este while se impide que el usuario escoja otra materia igual a la que ya tiene escogida
                                {
                                    if (listaMateriasA[i].CodigoMateriaCarrera.CodigoMateriaCarrera == materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera)//se fija si ya escogio esa materia
                                    {
                                        contador += 1;
                                    }
                                    i++;
                                }

                                if (contador == 0)
                                {
                                    horario = logicaH.ListarHorarios(materiaAbierta.CodigoMateriaAbierta);//crea un dataset con los horarios de la materia abierta
                                    if (logicaH.verificarChoqueMateria(horario, txtCarnetEstudiante.Text) != 1)
                                    {
                                        listaMateriasA.Add(materiaAbierta);


                                        DataSet datos = new DataSet();

                                        datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                                        dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                                        dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
                                    }
                                    else
                                    {
                                        MessageBox.Show("No puede matricular esta materia porque tiene un choque de horarios con otra materia ya matriculada", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Debe ingresar una materia diferente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                horario = logicaH.ListarHorarios(materiaAbierta.CodigoMateriaAbierta);
                                if (logicaH.verificarChoqueMateria(horario, txtCarnetEstudiante.Text) != 1)
                                {
                                    listaMateriasA.Add(materiaAbierta);


                                    DataSet datos = new DataSet();

                                    datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                                    dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                                    dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
                                }
                                else
                                {
                                    MessageBox.Show(logicaH.Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }

                            }
                        }
                        else
                        {
                            MessageBox.Show(logicaMA.Mensaje, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        calcularCostos();
                    }
                    else
                    {
                        MessageBox.Show("La materia no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMatricular_Load(object sender, EventArgs e)
        {
            dtpFechaMatricula.Value = DateTime.Today;
            LogicaValoresReferencia logicaValores = new LogicaValoresReferencia(Configuracion.getConnectionString);
            ValoresReferencia valoresR = new ValoresReferencia();
            valoresR =  logicaValores.RecuperarPeriodoAnio();
            txtPeriodo.Text = valoresR.Periodo.ToString();
            txtAnio.Text = valoresR.Anio.ToString();
            lblMontoMatricula.Text = valoresR.MontoMatricula.ToString();
        }

        public DataSet GenerarDataSet(List<MateriasAbiertas> materiasAbiertas) //genera un dataset con el horario que se le manda
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataSet.Tables.Add(dataTable);
            dataTable.Columns.Add("CodMateriaAbierta");
            dataTable.Columns.Add("CodigoMateria");
            dataTable.Columns.Add("NombreMateria");
            dataTable.Columns.Add("Requisito");
            dataTable.Columns.Add("nombreRequisito");
            dataTable.Columns.Add("corequisito");
            dataTable.Columns.Add("nombreCoRequisito");
            dataTable.Columns.Add("nombreProfesor");
            dataTable.Columns.Add("NumeroAula");
            dataTable.Columns.Add("Grupo");
            dataTable.Columns.Add("Costo");

            foreach (var Item in materiasAbiertas)
            {
                dataTable.Rows.Add(new object[] { 
                    Item.CodigoMateriaAbierta, 
                    Item.CodigoMateriaCarrera.CodigoMateria.CodigoMateria, 
                    Item.CodigoMateriaCarrera.CodigoMateria.NombreMateria,
                    Item.CodigoMateriaCarrera.Requisito.CodigoMateria,
                    Item.CodigoMateriaCarrera.Requisito.NombreMateria,
                    Item.CodigoMateriaCarrera.Corequisito.CodigoMateria,
                    Item.CodigoMateriaCarrera.Corequisito.NombreMateria,
                    Item.CodigoProfesor.Nombre,
                    Item.CodigoAula.NumeroAula,
                    Item.Grupo,
                    Item.Costo
                });
            }

            return dataSet;
        }

        private void dtgvVerMateriaAbierta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dtgvVerMateriaAbierta.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                int codMateriaAbierta;
                codMateriaAbierta = Convert.ToInt32((dtgvVerMateriaAbierta.SelectedRows[0].Cells[0].Value));//se obtiene el codigo de la materia carrera de la materia seleccionada
                FrmMostrarHorarios mostrarHorarios = new FrmMostrarHorarios(codMateriaAbierta);
                mostrarHorarios.ShowDialog();
            }
        }

        private void btnQuitarMateria_Click(object sender, EventArgs e)
        {
            if (dtgvVerMateriaAbierta.Rows.Count > 0)
            {
                int indiceMateria = dtgvVerMateriaAbierta.SelectedRows[0].Cells[0].RowIndex; //selecciona el indice de la fila del datagrid para poder quitar la materia
                listaMateriasA.RemoveAt(indiceMateria);//remueve la materia de la lista
                DataSet datos = new DataSet();

                datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
                calcularCostos();
            }
           
        }

        private void calcularCostos() { //esta funcion permite calcular los costos de la matricula

            LogicaMatricula costosM = new LogicaMatricula();
            lblTotalPagar.Text = costosM.calcularCostos(Convert.ToDecimal(txtDescuentoE.Text), listaMateriasA, Convert.ToDouble(lblMontoMatricula.Text)).ToString();///////////////////////////////////////////////////////////////
            lblSubtotal.Text = costosM.Subtotal.ToString();
            lblDescuento.Text = txtDescuentoE.Text;
            lblMontoDescuento.Text = costosM.MontoDescuento.ToString();
            lblMontoIva.Text = costosM.MontoIVA.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            LogicaMatricula logicaM = new LogicaMatricula(Configuracion.getConnectionString);
            Matricula matricula;
            int numFactura;

            try
            {
                if (!string.IsNullOrEmpty(txtCarnetEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtCedulaEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtNombreEstudiante.Text) &&
                    !string.IsNullOrEmpty(txtEmailE.Text) &&
                    !string.IsNullOrEmpty(txtDescuentoE.Text))
                {
                    if (listaMateriasA.Count > 0)
                    {
                        if (comboTipoPago.SelectedIndex != -1)
                        {
                            matricula = generarEntidad();
                            if (!matricula.Existe)
                            {
                                numFactura = logicaM.Insertar(matricula, listaMateriasA); //inserta matricula
                            }
                            else
                            {
                                numFactura = logicaM.Modificar(matricula.NumeroFactura,listaMateriasA);////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                            }

                            if (numFactura > 0)
                            {
                                MessageBox.Show(logicaM.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();    //Limpia el form
                            }
                            else
                            {
                                MessageBox.Show("No se realizó ninguna modificación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Debe escoger un tipo de pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show("Para poder matricular debe de escoger al menos 1 materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Primero debe buscar al estudiante para poder matricular", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private Matricula generarEntidad() {
            LogicaValoresReferencia logicaVR = new LogicaValoresReferencia(Configuracion.getConnectionString);

            Matricula matricula;
            if (!string.IsNullOrEmpty(txtNumFactura.Text))
            {
                matricula = matriculaERegistrado;
                matricula.Existe = true;
            }
            else
            {
                matricula = new Matricula();
                matricula.CarnetEstudiante = new Estudiantes();
            }

            matricula.CarnetEstudiante.CarnetEstudiante = txtCarnetEstudiante.Text;
            matricula.FechaMatricula = dtpFechaMatricula.Value;
            matricula.MontoMatricula = Convert.ToDecimal(lblTotalPagar.Text);
            matricula.TipoPago = comboTipoPago.SelectedItem.ToString();

            return matricula;
        }

        private void Limpiar() {
            txtNumFactura.Text = string.Empty;
            txtCarnetEstudiante.Text = string.Empty;
            txtCedulaEstudiante.Text = string.Empty;
            txtNombreEstudiante.Text = string.Empty;
            txtEmailE.Text = string.Empty;
            txtDescuentoE.Text = string.Empty;
            comboTipoPago.SelectedIndex = -1;
            listaMateriasA.Clear();
            dtgvVerMateriaAbierta.Columns.Clear();
            txtDescuentoE.Text = "0";
            lblSubtotal.Text = string.Empty;
            lblDescuento.Text = string.Empty;
            lblMontoDescuento.Text = string.Empty;
            lblMontoIva.Text = string.Empty;
            lblTotalPagar.Text = string.Empty;
        }

        private void btnBuscarMatriculas_Click(object sender, EventArgs e)
        {
            FrmBuscarMatriculas frmBuscarMatricula = new FrmBuscarMatriculas();
            frmBuscarMatricula.MandarMatricula += new EventHandler(TraerMatricula);
            frmBuscarMatricula.ShowDialog();
            btnBuscarEstudiante.Enabled = false;
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
                    dtpFechaMatricula.Value = matriculaEstudiante.FechaMatricula;
                    txtCarnetEstudiante.Text = matriculaEstudiante.CarnetEstudiante.CarnetEstudiante;
                    txtCedulaEstudiante.Text = matriculaEstudiante.CarnetEstudiante.Cedula;
                    txtNombreEstudiante.Text = matriculaEstudiante.CarnetEstudiante.Nombre;
                    txtEmailE.Text = matriculaEstudiante.CarnetEstudiante.CorreoElectronico;
                    txtDescuentoE.Text = matriculaEstudiante.CarnetEstudiante.Descuento.ToString();
                    comboTipoPago.SelectedItem = matriculaEstudiante.TipoPago.ToString();
                    materias = traerMatricula.ListarMateriasMatriculadas(matriculaEstudiante.NumeroFactura); //obtiene en un dataset las materias matriculadas pertenecientes al numero de factura respectivo

                    if (materias.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                    {
                        MateriasAbiertas materiaAbierta;
                        LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                        int codMateriaAbierta = 0;

                        dtgvVerMateriaAbierta.DataSource = materias;
                        dtgvVerMateriaAbierta.DataMember = materias.Tables[0].TableName; //se carga el dataset

                        for (int i = 0; i < dtgvVerMateriaAbierta.Rows.Count; i++)
                        {
                            codMateriaAbierta = (int)(dtgvVerMateriaAbierta.Rows[i].Cells[0].Value); //tome el primer valor del data grid que son los codigos de materiasAbiertas y busquelos para insertarlos en el arreglo de materias abiertas

                            materiaAbierta = logicaMA.ObtenerMateriaAbierta(codMateriaAbierta);
                            listaMateriasA.Add(materiaAbierta);//se ingresa la materia abierta dentro del arreglo
                        }
                    }

                    matriculaERegistrado = matriculaEstudiante; //se setea la matricula del estudiante registrado para poder darle la opcion al usuario de modificar la informacion de la matricula
                    calcularCostos(); // se vuelven a calcular los costos
                }
                else
                {
                    MessageBox.Show("La matricula no existe en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void TraerMatricula(object numeroFactura, EventArgs e)
        {
            try
            {
                int numFactura = (int)numeroFactura;
                if (numFactura != -1)
                {
                    CargarMatricula(numFactura);
                }
                else
                {
                    Limpiar();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCarnetEstudiante.Text) && !string.IsNullOrEmpty(txtCedulaEstudiante.Text) &&
                !string.IsNullOrEmpty(txtNombreEstudiante.Text) && !string.IsNullOrEmpty(txtEmailE.Text) &&
                !string.IsNullOrEmpty(txtDescuentoE.Text))
            {
                FrmBuscarMateriaAbierta FrmBuscarMateriaA = new FrmBuscarMateriaAbierta(int.Parse(txtPeriodo.Text), int.Parse(txtAnio.Text));
                FrmBuscarMateriaA.MandarMateria += new EventHandler(TraerMateria);
                FrmBuscarMateriaA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Para buscar una materia debe primero buscar un estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (txtNumFactura.Text == string.Empty) //significa que se esta creando la factura en ese mismo momento y la quiere cancelar de una vez no quiere guardarla
            {
                if ((!string.IsNullOrEmpty(txtCarnetEstudiante.Text) && !string.IsNullOrEmpty(txtCedulaEstudiante.Text) &&
                !string.IsNullOrEmpty(txtNombreEstudiante.Text) && !string.IsNullOrEmpty(txtEmailE.Text) &&
                !string.IsNullOrEmpty(txtDescuentoE.Text)))
                {
                    if (listaMateriasA.Count > 0)
                    {
                        if (comboTipoPago.SelectedIndex != -1)
                        {
                            LogicaMatricula logicaM = new LogicaMatricula(Configuracion.getConnectionString);
                            Matricula matricula;
                            int numFactura = -1;
                            int resultadoFacturar = -1;
                            matricula = generarEntidad();

                            numFactura = logicaM.Insertar(matricula, listaMateriasA); //como esta facturando de manera inmediata entonces debe primero crear la matricula para poder facturarla
                            resultadoFacturar = logicaM.Facturar(numFactura);

                            if (numFactura > 0 && resultadoFacturar > 0)
                            {
                                MessageBox.Show(logicaM.Mensaje+" "+" y ha sido facturada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Limpiar();    //Limpia el form
                            }
                            else
                            {
                                MessageBox.Show("No se pudo guardar la matricula ni realizar la facturación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Para facturar debe de escoger un tipo de pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Para facturar una matricula debe de escoger al menos una materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Para facturar una matricula debe de buscar primero un estudiante", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else //sino significa que se desea facturar una matricula que fue recuperada
            {
                if (listaMateriasA.Count > 0)
                {
                    if (comboTipoPago.SelectedIndex != -1)
                    {
                        LogicaMatricula logicaM = new LogicaMatricula(Configuracion.getConnectionString);
                        Matricula matricula;
                        int resultadoModificar = -1;
                        int resultadoFacturar = -1;
                        matricula = generarEntidad();

                        resultadoModificar = logicaM.Modificar(matricula.NumeroFactura, listaMateriasA); //esta facturando de una matricula recuperada entonces vuelve a cambiar la informacion y psa a facturar
                        resultadoFacturar = logicaM.Facturar(matricula.NumeroFactura);

                        if (resultadoModificar > 0 && resultadoFacturar > 0)
                        {
                            MessageBox.Show("La Matricula ha sido cancelada con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Limpiar();    //Limpia el form
                        }
                        else
                        {
                            MessageBox.Show("No se pudo realizar la cancelación de la matrícula", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    else
                    {
                        MessageBox.Show("Para facturar debe de escoger un tipo de pago", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Para facturar una matricula debe de haber al menos una materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }//fin del form
}//fin del namespace
