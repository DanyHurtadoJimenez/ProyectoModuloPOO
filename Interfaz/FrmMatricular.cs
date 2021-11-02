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

        List<MateriasAbiertas> listaMateriasA = new List<MateriasAbiertas>();

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
                        MessageBox.Show("El profesor no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (nudPeriodo.Value != 0 && comboAnio.SelectedIndex != -1)
            {
                FrmBuscarMateriaAbierta FrmBuscarMateriaA = new FrmBuscarMateriaAbierta(Convert.ToInt32(nudPeriodo.Value),Convert.ToInt32(comboAnio.SelectedItem));
                FrmBuscarMateriaA.MandarMateria += new EventHandler(TraerMateria);
                nudPeriodo.Enabled = false;
                comboAnio.Enabled = false;
                FrmBuscarMateriaA.ShowDialog();
            }
            else
            {
                MessageBox.Show("Debe escoger primero el periodo y el año para buscar las materias disponibles en ese periodo y año", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TraerMateria(object codMateriaAbierta, EventArgs e)///////////////////////////////////////////////////////////////////////////////////////////
        {
            try
            {
                int codMA = (int)codMateriaAbierta;
                if (codMA != -1)
                {
                    MateriasAbiertas materiaAbierta;
                    LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                    materiaAbierta = logicaMA.ObtenerMateriaAbierta(codMA);

                    if (materiaAbierta != null)
                    {
                        listaMateriasA.Add(materiaAbierta);
                        DataSet datos = new DataSet();

                        datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                        dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                        dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
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
            comboAnio.Items.Add(DateTime.Today.Year.ToString());
            comboAnio.Items.Add(DateTime.Today.AddYears(1).Year.ToString());
        }

        public DataSet GenerarDataSet(List<MateriasAbiertas> materiasAbiertas) //genera un dataset con el horario que se le manda
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataSet.Tables.Add(dataTable);
            dataTable.Columns.Add("CodMateriaAbierta");
            dataTable.Columns.Add("CodMateria");
            dataTable.Columns.Add("nombreMateria");
            dataTable.Columns.Add("nombreProfesor");
            dataTable.Columns.Add("numAula");
            dataTable.Columns.Add("grupo");
            dataTable.Columns.Add("costo");

            foreach (var Item in materiasAbiertas)
            {
                dataTable.Rows.Add(new object[] { 
                    Item.CodigoMateriaAbierta, 
                    Item.CodigoMateriaCarrera.CodigoMateria.CodigoMateria, 
                    Item.CodigoMateriaCarrera.CodigoMateria.NombreMateria,
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




    }//fin del form
}//fin del namespace
