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
                        txtCedulaEstudiante.Text = estudiante.IdEstudiante;
                        txtNombreEstudiante.Text = string.Format("{0} {1} {2}", estudiante.NombreEstudiante,estudiante.Apellido1Estudiante,estudiante.Apellido2Estudiante);
                        txtEmailE.Text = estudiante.CorreoEstudiante;
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
    }
}
