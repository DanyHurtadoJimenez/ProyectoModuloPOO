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
    public partial class FrmBuscarMateria : Form
    {

        public event EventHandler Aceptar;//se crea el evento nuevo

        int CodMateriaCarrera;//variable que se usara para mandar el id al evento

        public FrmBuscarMateria()
        {
            InitializeComponent();
        }



        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaMateriaCarrera logicaMC = new LogicaMateriaCarrera(Configuracion.getConnectionString);
            DataSet DSMateriaCarrera;

            try
            {
                DSMateriaCarrera = logicaMC.ListarMateriasCarreras(condicion);
                if (DSMateriaCarrera.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvBuscarMateria.DataSource = DSMateriaCarrera;
                    dgvBuscarMateria.DataMember = DSMateriaCarrera.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void Seleccionar()
        {  //metodo que permite seleccionar el id de la fila del datagridview que se escoja

            if (dgvBuscarMateria.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                CodMateriaCarrera = (int)dgvBuscarMateria.SelectedRows[0].Cells[0].Value;
                Aceptar(CodMateriaCarrera, null);//le manda el id al evento aceptar que esta en el otro form
                Close();//se cierra la ventana
            }
        }

        private void FrmBuscarMateria_Load(object sender, EventArgs e)
        {
            try
            {
                CargarDataSet();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnBuscarMateria_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty; //condicion que se usara para realizar el filtrado en los datos para recuperar el cliente deseado
            try
            {
                if (!string.IsNullOrEmpty(txtCondicion.Text))//si no esta vacio
                {
                    if (rdnCodMateria.Checked)
                    {
                        condicion = string.Format("M.CodigoMateria like '%{0}%'", txtCondicion.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnNombreMateria.Checked)
                    {
                        condicion = string.Format("NombreMateria like '%{0}%'", txtCondicion.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    CargarDataSet(condicion);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            Seleccionar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Aceptar(-1, null);//evento aceptar
            Close();
        }

        private void dgvBuscarMateria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }

        private void txtCondicion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rdnNombreMateria.Checked)
            {
                if (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicion, "Debe ingresar solamente letras");
                }
                else
                {
                    errorProvider1.SetError(txtCondicion, string.Empty);
                }
            }

            if (rdnCodMateria.Checked)
            {
                if (!char.IsDigit(e.KeyChar) && (!char.IsLetter(e.KeyChar) && (e.KeyChar != (char)Keys.Back)))
                {
                    e.Handled = true;
                    errorProvider1.SetError(txtCondicion, "Debe ingresar un valor alfanumérico");
                }
                else
                {
                    errorProvider1.SetError(txtCondicion, string.Empty);
                }
            }
        }

        private void rdnCodMateria_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicion.Enabled = true;
        }

        private void rdnNombreMateria_CheckedChanged(object sender, EventArgs e)
        {
            txtCondicion.Enabled = true;
        }
    }
}
