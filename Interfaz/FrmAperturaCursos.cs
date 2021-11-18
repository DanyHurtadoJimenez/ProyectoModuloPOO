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
    public partial class FrmAperturaCursos : Form
    {
        public FrmAperturaCursos()
        {
            InitializeComponent();
        }

        //variables globales


        int idMateriaCarrera;
        List<Horarios> listaHorarios = new List<Horarios>();//la lista donde se almacenaran los horarios de la materia

        private void CargarMateriaCarrera(int codMateriaCarrera)
        {
            MateriasCarreras MateriaC;
            LogicaMateriaCarrera traerMateriaCarrera = new LogicaMateriaCarrera(Configuracion.getConnectionString);
            
            try
            {
                MateriaC = traerMateriaCarrera.ObtenerMateriaCarrera(codMateriaCarrera);
                if (MateriaC != null)
                {
                    FrmBuscarMateria formularioBuscarM = new FrmBuscarMateria();
                    idMateriaCarrera = MateriaC.CodigoMateriaCarrera;
                    txtCodigoMateria.Text = MateriaC.CodigoMateria.CodigoMateria;
                    txtNombreMateria.Text = MateriaC.CodigoMateria.NombreMateria;
                    txtCreditos.Text = MateriaC.CodigoMateria.CreditosMateria.ToString();
                    txtNombreCarrera.Text = MateriaC.CodigoCarreras.NombreCarrera;
                    //clienteRegistrado = MateriaC; //se setea el cliente registrado para poder darle la opcion al usuario de modificar la informacion del cliente
                }
                else
                {
                    MessageBox.Show("La materia no se encuentra en la base de datos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //CargarListaDataSet(); //en el load del formulario se llama a carga el gridview con el data set //vuelve a cargar la lista para que vea que el cliente de verdad no esta
                }
            }
            catch (Exception)
            {
                throw;
            }
        }


        private MateriasAbiertas GenerarEntidad()
        { //genera entidad para crear o modificar la informacion 
            MateriasAbiertas materiaA;
            MateriasAbiertas materiaAbierta = new MateriasAbiertas();
            materiaAbierta.CodigoMateriaCarrera = new MateriasCarreras();

            if (!string.IsNullOrEmpty(txtCodigoMateria.Text))
            {
                
                materiaA = new MateriasAbiertas();
                materiaA.CodigoMateriaCarrera = new MateriasCarreras();
                materiaA = materiaAbierta;
            }
            else
            {
                materiaA = new MateriasAbiertas();
                materiaA.CodigoMateriaCarrera = new MateriasCarreras();
            }

            materiaA.CodigoMateriaCarrera.CodigoMateriaCarrera = idMateriaCarrera;
            materiaA.Grupo = Convert.ToByte(txtGrupo.Text);
            materiaA.Cupo = Convert.ToByte(nudCupo.Value);
            materiaA.Costo = Convert.ToDecimal(txtCosto.Text);
            materiaA.Periodo = Convert.ToByte(nudPeriodo.Value);
            materiaA.Anio = Int16.Parse(comboAnio.SelectedItem.ToString());
            return materiaA;
        }


        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarMateria formularioBuscarM = new FrmBuscarMateria();
            formularioBuscarM.Aceptar += new EventHandler(Aceptar);
            formularioBuscarM.ShowDialog();
        }

        private void Aceptar(object id, EventArgs e)
        {
            try
            {
                int codMateriaCarrera = (int)id;
                if (codMateriaCarrera != -1)
                {
                    CargarMateriaCarrera(codMateriaCarrera);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarHorario_Click(object sender, EventArgs e)
        {

            if ((comboDiasSemana.SelectedIndex != -1) && dtpHoraInicio.Value != null && dtpHoraFinal.Value != null)
            {
                Horarios horario = new Horarios();

                horario.CodigoMateriaAbierta = new MateriasAbiertas();
                horario.Dia = comboDiasSemana.SelectedItem.ToString();
                horario.HoraInicio = dtpHoraInicio.Value;
                horario.HoraFin = dtpHoraFinal.Value;

                if (listaHorarios.Count > 0)
                {
                    int i=0;
                    int contador = 0;

                    while (i < listaHorarios.Count) //con este while se impide que el usuario escoja horarios que choquen antes de ingresarlos al arreglo
                    {
                        if ((listaHorarios[i].HoraInicio <= horario.HoraFin) && (listaHorarios[i].HoraFin >= horario.HoraInicio) && listaHorarios[i].Dia == horario.Dia)
                        {
                            contador += 1;
                        }
                        i++;
                    }

                    if (contador == 0)
                    {
                        listaHorarios.Add(horario); //se va guardando en una lista el horario para pasarlo a un data table y poder cargar el data grid

                        DataSet datos = new DataSet();

                        datos = GenerarDataSet(listaHorarios); //llena el data grid view con la lista que se le envía

                        dtgvMostrarHorario.DataSource = datos; //se carga el datagrid con el dataset
                        dtgvMostrarHorario.DataMember = datos.Tables[0].TableName;
                    }
                    else
                    {
                        MessageBox.Show("Debe ingresar un horario diferente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    listaHorarios.Add(horario); //se va guardando en una lista el horario para pasarlo a un data table y poder cargar el data grid
                    DataSet datos = new DataSet();

                    datos = GenerarDataSet(listaHorarios); //llena el data grid view con la lista que se le envía

                    dtgvMostrarHorario.DataSource = datos; //se carga el datagrid con el dataset
                    dtgvMostrarHorario.DataMember = datos.Tables[0].TableName;
                }

            }
        }


        public DataSet GenerarDataSet(List<Horarios> horario) //genera un dataset con el horario que se le manda
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataSet.Tables.Add(dataTable);
            dataTable.Columns.Add("Dia");
            dataTable.Columns.Add("HoraInicio");
            dataTable.Columns.Add("HoraFin");

            foreach (var oItem in horario)
            {
                dataTable.Rows.Add(new object[] { oItem.Dia, oItem.HoraInicio, oItem.HoraFin });
            }

            return dataSet;
        }

        private void FormatearHoras(DateTimePicker hora)
        {
            hora.Format = DateTimePickerFormat.Custom;
            hora.CustomFormat = "HH:mm";

        }

        private void FrmAperturaCursos_Load(object sender, EventArgs e)
        {
            FormatearHoras(dtpHoraInicio);
            FormatearHoras(dtpHoraFinal);
            comboAnio.Items.Add(DateTime.Today.Year.ToString());
            comboAnio.Items.Add(DateTime.Today.AddYears(1).Year.ToString());
            dtpHoraInicio.MinDate = DateTime.Parse("7:00:00");
            dtpHoraInicio.MaxDate = DateTime.Parse("20:00:00");
            dtpHoraFinal.MinDate = DateTime.Parse("8:00:00");
            dtpHoraFinal.MaxDate = DateTime.Parse("22:00:00");
        }

        private void dtpHoraInicio_ValueChanged(object sender, EventArgs e)
        {
            dtpHoraFinal.MinDate = dtpHoraInicio.Value.AddHours(1);
            dtpHoraFinal.Value = dtpHoraInicio.Value.AddHours(1);
        }

        private void btnBuscarProfesor_Click(object sender, EventArgs e)
        {
            FrmBuscarProfesor buscarProfeForm = new FrmBuscarProfesor();
            buscarProfeForm.MandarProfe += new EventHandler(TraerProfe);
            buscarProfeForm.ShowDialog();
        }

        private void TraerProfe(object codProfe, EventArgs e)
        {
            try
            {
                int codProfesor = (int)codProfe;
                if (codProfesor != -1)
                {
                    Profesores profe;
                    LogicaProfesores traerProfe = new LogicaProfesores(Configuracion.getConnectionString);
                    profe = traerProfe.ObtenerProfesor(codProfesor);

                    if (profe != null)
                    {
                        txtCodProfe.Text = profe.CodigoProfesor.ToString();
                        txtNombreProfe.Text = string.Format("{0} {1} {2}", profe.Nombre,profe.Apellido1,profe.Apellido2);
                    }
                    else
                    {
                        MessageBox.Show("El profesor no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarAula_Click(object sender, EventArgs e)
        {
            FrmBuscarAula buscarAula = new FrmBuscarAula();
            buscarAula.MandarAula += new EventHandler(TraerAula);
            buscarAula.ShowDialog();
        }

        private void TraerAula(object codAula, EventArgs e)
        {
            try
            {
                int codA = (int)codAula;
                if (codA != -1)
                {
                    Aulas aula;
                    LogicaAula traerAula = new LogicaAula(Configuracion.getConnectionString);
                    aula = traerAula.ObtenerAula(codA);

                    if (aula != null)
                    {
                        txtCodigaAula.Text = aula.CodigoAula.ToString();
                        txtTipoAula.Text = aula.TipoAula;
                        txtNumAula.Text = aula.NumeroAula.ToString();
                        txtCapacidad.Text = aula.Capacidad.ToString();
                    }
                    else
                    {
                        MessageBox.Show("El aula no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbrirMateria_Click(object sender, EventArgs e)
        {
            LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            MateriasAbiertas materiaAB;
            int idMateriaAbierta,ingresoProfesor = -1, ingresoAula = -1;
            try
            {
                if (!string.IsNullOrEmpty(txtCodigoMateria.Text) && !string.IsNullOrEmpty(txtNombreMateria.Text) &&
                    !string.IsNullOrEmpty(txtCreditos.Text) && !string.IsNullOrEmpty(txtNombreCarrera.Text))
                {
                    if (!string.IsNullOrEmpty(txtGrupo.Text) && nudCupo.Value != 0 &&
                        !string.IsNullOrEmpty(txtCosto.Text) && nudPeriodo.Value != 0 &&
                        comboAnio.SelectedIndex != -1)
                    {
                        if (comboDiasSemana.SelectedIndex != -1 && dtgvMostrarHorario.Rows.Count > 0)
                        {
                            materiaAB = GenerarEntidad();
                            if (materiaAB.Existe)
                            {
                                idMateriaAbierta = logicaMA.InsertarMateriaAbierta(materiaAB, listaHorarios);
                            }
                            else 
                            {
                                idMateriaAbierta = -1;//se llamaria al metodo modificar                            
                            }

                            if (idMateriaAbierta > 0 )
                            {
                                MessageBox.Show(logicaMA.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                                if (!string.IsNullOrEmpty(txtCodProfe.Text))
                                {
                                    int codProfesor = int.Parse(txtCodProfe.Text);
                                    
                                    ingresoProfesor = logicaMA.AsignarProfesor(codProfesor,idMateriaAbierta); //se trata de ingresar al profesor

                                    if (ingresoProfesor == 0)
                                    {
                                        MessageBox.Show(logicaMA.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(logicaMA.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }

                                }

                                if (!string.IsNullOrEmpty(txtCodigaAula.Text))
                                {
                                    int codAula = int.Parse(txtCodigaAula.Text);

                                    ingresoAula = logicaMA.AsignarAula(codAula, idMateriaAbierta);//se trata de ingresar el aula

                                    if (ingresoAula == 0)
                                    {
                                        MessageBox.Show(logicaMA.Mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    else
                                    {
                                        MessageBox.Show(logicaMA.Mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                Limpiar();
                            }
                            else
                            {
                                MessageBox.Show("No fue posible abrir la materia", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                        else
                        {
                            MessageBox.Show("Debe introducir un horario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Debe introducir la informacion de los periodos y cupos de la materia", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Debe realizar la busqueda de la informacion de la materia primero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }


        private void Limpiar() {
            txtCodigoMateria.Text = string.Empty;
            txtCreditos.Text = string.Empty;
            txtNombreCarrera.Text = string.Empty;
            txtNombreMateria.Text = string.Empty;
            txtGrupo.Text = string.Empty;
            nudCupo.Value = 0;
            txtCosto.Text = string.Empty;
            comboAnio.SelectedIndex = -1;
            comboDiasSemana.SelectedIndex = -1;
            listaHorarios.Clear();
            dtgvMostrarHorario.Columns.Clear();
            txtCodigaAula.Text = string.Empty;
            txtTipoAula.Text = string.Empty;
            txtNumAula.Text = string.Empty;
            txtCapacidad.Text = string.Empty;
            txtCodProfe.Text = string.Empty;
            txtNombreProfe.Text = string.Empty;
            
        }
        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                errorProvider1.SetError(txtCosto, "Debe ingresar un valor numérico");
            }
            else
            {
                errorProvider1.SetError(txtCosto, string.Empty);
            }
        }

        private void comboAnio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtCodigoMateria.Text != string.Empty && nudPeriodo.Value > 0)
            {
                LogicaMateriaCarrera traerMateriaCarrera = new LogicaMateriaCarrera(Configuracion.getConnectionString);
                int numeroGrupo = traerMateriaCarrera.generarGrupo(idMateriaCarrera, Convert.ToInt32(comboAnio.SelectedItem), Convert.ToInt32(nudPeriodo.Value)); //se genera el numero del grupo
                txtGrupo.Text = numeroGrupo.ToString();
            }
        }

        private void nudPeriodo_ValueChanged(object sender, EventArgs e)
        {
            if (txtCodigoMateria.Text != string.Empty && comboAnio.SelectedIndex != -1)
            {
                LogicaMateriaCarrera traerMateriaCarrera = new LogicaMateriaCarrera(Configuracion.getConnectionString);
                int numeroGrupo = traerMateriaCarrera.generarGrupo(idMateriaCarrera, Convert.ToInt32(comboAnio.SelectedItem), Convert.ToInt32(nudPeriodo.Value)); //se genera el numero del grupo
                txtGrupo.Text = numeroGrupo.ToString();
            }
        }
    }
}
