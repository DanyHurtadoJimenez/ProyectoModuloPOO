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
                        txtNombreEstudiante.Text = estudiante.NombreEstudiante;
                        txtApellido1E.Text = estudiante.Apellido1Estudiante;
                        txtApellido2E.Text = estudiante.Apellido2Estudiante;
                        txtEmailE.Text = estudiante.CorreoEstudiante;
                        txtProvinciaE.Text = estudiante.ProvinciaEstudiante;
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
            FrmBuscarMateriaAbierta  FrmBuscarMateriaA = new FrmBuscarMateriaAbierta();
            FrmBuscarMateriaA.MandarMateria += new EventHandler(TraerMateria);
            FrmBuscarMateriaA.ShowDialog();
        }

        private void TraerMateria(object sender, EventArgs e)///////////////////////////////////////////////////////////////////////////////////////////
        {
            //try
            //{
            //    int codProfesor = (int)codProfe;
            //    if (codProfesor != -1)
            //    {
            //        Profesores profe;
            //        LogicaProfesores traerProfe = new LogicaProfesores(Configuracion.getConnectionString);
            //        profe = traerProfe.ObtenerProfesor(codProfesor);

            //        if (profe != null)
            //        {
            //            txtCodProfe.Text = profe.CodigoProfesor.ToString();
            //            txtNombreProfe.Text = profe.NombreProfesor;
            //            txtIdProfe.Text = profe.IdProfesor.ToString();
            //            txtApellido1.Text = profe.Apellido1Profesor;
            //            txtApellido2.Text = profe.Apellido2Profesor;
            //        }
            //        else
            //        {
            //            MessageBox.Show("El profesor no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }
    }
}
