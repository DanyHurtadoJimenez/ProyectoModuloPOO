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
    public partial class FrmBuscarEstudiante : Form
    {
        public FrmBuscarEstudiante()
        {
            InitializeComponent();
        }

        public event EventHandler MandarEstudiante;//se crea el evento nuevo

        string codEstudiante = string.Empty;//variable que se usara para mandar el id al evento


        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaEstudiante logicaEstudiante = new LogicaEstudiante(Configuracion.getConnectionString);
            DataSet dsEstudiantes;

            try
            {
                dsEstudiantes = logicaEstudiante.ListarEstudiante(condicion);
                if (dsEstudiantes.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvBuscarEstudiante.DataSource = dsEstudiantes;
                    dgvBuscarEstudiante.DataMember = dsEstudiantes.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void SeleccionarEstudiante()
        {  //metodo que permite seleccionar el id de la fila del datagridview que se escoja

            if (dgvBuscarEstudiante.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                codEstudiante = (dgvBuscarEstudiante.SelectedRows[0].Cells[0].Value).ToString();////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                MandarEstudiante(codEstudiante, null);//le manda el id al evento  que esta en el otro form
                Close();//se cierra la ventana
            }
        }

        private void FrmBuscarEstudiante_Load(object sender, EventArgs e)
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

        private void btnBuscarEstudiante_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty; //condicion que se usara para realizar el filtrado en los datos para recuperar el profesor deseado
            try
            {
                if (!string.IsNullOrEmpty(txtCondicionEstudiante.Text))//si no esta vacio
                {
                    if (rdnCodEstudiante.Checked)
                    {
                        condicion = string.Format("CarnetEstudiante like '%{0}%'", txtCondicionEstudiante.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnCedulaEstudiante.Checked)
                    {
                        condicion = string.Format("IdEstudiante like '%{0}%'", txtCondicionEstudiante.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnNombreEstudiante.Checked)
                    {
                        condicion = string.Format("NombreEstudiante like '%{0}%'", txtCondicionEstudiante.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    CargarDataSet(condicion);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rdnCodEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscarEstudiante.Enabled = true;
            txtCondicionEstudiante.Enabled = true;
        }

        private void rdnCedulaEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscarEstudiante.Enabled = true;
            txtCondicionEstudiante.Enabled = true;
        }

        private void rdnNombreEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscarEstudiante.Enabled = true;
            txtCondicionEstudiante.Enabled = true;
        }

        private void txtCondicionEstudiante_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdnCodEstudiante.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionEstudiante, "Debe ingresar un valor alfanumérico");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionEstudiante, string.Empty);
                }
            }

            if (rdnCedulaEstudiante.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '-'))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionEstudiante, "Debe ingresar un valor numérico");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionEstudiante, string.Empty);
                }
            }

            if (rdnNombreEstudiante.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionEstudiante, "Debe ingresar solamente letras");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionEstudiante, string.Empty);
                }
            }



        }

        private void dgvBuscarEstudiante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarEstudiante();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            SeleccionarEstudiante();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MandarEstudiante(-1, null);//evento aceptar
            Close();
        }
    }
}
