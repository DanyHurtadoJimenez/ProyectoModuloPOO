using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicaNegocio;

namespace Interfaz
{
    public partial class FrmBuscarMatriculas : Form
    {


        public event EventHandler MandarMatricula;//se crea el evento nuevo

        int numFactura = 0;//variable que se usara para mandar el id al evento


        public FrmBuscarMatriculas()
        {
            InitializeComponent();
        }

        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaMatricula logicaMTR = new LogicaMatricula(Configuracion.getConnectionString);
            DataSet DSMatriculas;

            try
            {
                DSMatriculas = logicaMTR.ListarMatriculas(condicion);
                if (DSMatriculas.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvBuscarMatriculas.DataSource = DSMatriculas;
                    dgvBuscarMatriculas.DataMember = DSMatriculas.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }


        private void SeleccionarMatricula()
        {  //metodo que permite seleccionar el id de la fila del datagridview que se escoja

            if (dgvBuscarMatriculas.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                numFactura = (int)(dgvBuscarMatriculas.SelectedRows[0].Cells[0].Value);////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                MandarMatricula(numFactura, null);//le manda el id al evento  que esta en el otro form
                Close();//se cierra la ventana
            }
        }


        private void FrmBuscarMatriculas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MandarMatricula(-1, null);//evento aceptar
            Close();
        }

        private void btnBuscarMatricula_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty; //condicion que se usara para realizar el filtrado en los datos para recuperar el profesor deseado
            try
            {
                if (!string.IsNullOrEmpty(txtCondicionMatricula.Text))//si no esta vacio
                {
                    if (rdnCarnetEstudiante.Checked)
                    {
                        condicion = string.Format("CarnetEstudiante like '%{0}%'", txtCondicionMatricula.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnCedulaEstudiante.Checked)
                    {
                        condicion = string.Format("IdEstudiante like '%{0}%'", txtCondicionMatricula.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnNombreEstudiante.Checked)
                    {
                        condicion = string.Format("NombreEstudiante like '%{0}%'", txtCondicionMatricula.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    CargarDataSet(condicion);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSeleccionarMatricula_Click(object sender, EventArgs e)
        {
            SeleccionarMatricula();
        }

        private void txtCondicionMatricula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdnCarnetEstudiante.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionMatricula, "Debe ingresar valores alfanumericos");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionMatricula, string.Empty);
                }
            }

            if (rdnCedulaEstudiante.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionMatricula, "Debe ingresar un valor numerico");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionMatricula, string.Empty);
                }
            }

            if (rdnNombreEstudiante.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionMatricula, "Debe ingresar un valor numerico");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionMatricula, string.Empty);
                }
            }

        }

        private void rdnCarnetEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicionMatricula.Enabled = true;
            btnBuscarMatricula.Enabled = true;
        }

        private void rdnCedulaEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicionMatricula.Enabled = true;
            btnBuscarMatricula.Enabled = true;
        }

        private void rdnNombreEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicionMatricula.Enabled = true;
            btnBuscarMatricula.Enabled = true;
        }
    }
}
