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
    public partial class FrmBuscarProfesor : Form
    {
        public FrmBuscarProfesor()
        {
            InitializeComponent();
        }

        public event EventHandler MandarProfe;//se crea el evento nuevo

        int CodigoProfe = 0;//variable que se usara para mandar el id al evento

        private void SeleccionarProfe()
        {  //metodo que permite seleccionar el id de la fila del datagridview que se escoja

            if (dgvBuscarProfesor.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                CodigoProfe = (int)dgvBuscarProfesor.SelectedRows[0].Cells[0].Value;////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                MandarProfe(CodigoProfe, null);//le manda el id al evento  que esta en el otro form
                Close();//se cierra la ventana
            }
        }

        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaProfesores logicaPR = new LogicaProfesores(Configuracion.getConnectionString);
            DataSet DSProfesores;

            try
            {
                DSProfesores = logicaPR.ListarProfesores(condicion);
                if (DSProfesores.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvBuscarProfesor.DataSource = DSProfesores;
                    dgvBuscarProfesor.DataMember = DSProfesores.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        private void FrmBuscarProfesor_Load(object sender, EventArgs e)
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

        private void btnBuscarProfe_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty; //condicion que se usara para realizar el filtrado en los datos para recuperar el profesor deseado
            try
            {
                if (!string.IsNullOrEmpty(txtCondicionProfesor.Text))//si no esta vacio
                {
                    if (rdnCodProfe.Checked)
                    {
                        condicion = string.Format("CodigoProfesor like '%{0}%'", txtCondicionProfesor.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnNombreProfe.Checked)
                    {
                        condicion = string.Format("NombreProfesor like '%{0}%'", txtCondicionProfesor.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    CargarDataSet(condicion);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBuscarProfesor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarProfe();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            SeleccionarProfe();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MandarProfe(-1, null);//evento aceptar
            Close();
        }

        private void txtCondicionProfesor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdnNombreProfe.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionProfesor, "Debe ingresar solamente letras");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionProfesor, string.Empty);
                }
            }

            if (rdnCodProfe.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicionProfesor, "Debe ingresar un valor numerico");
                }
                else
                {
                    errorProvider1.SetError(txtCondicionProfesor, string.Empty);
                }
            }
        }

        private void rdnCodProfe_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicionProfesor.Enabled = true;
        }

        private void rdnNombreProfe_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicionProfesor.Enabled = true;
        }
    }
}
