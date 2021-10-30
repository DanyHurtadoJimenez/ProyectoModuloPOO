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
    public partial class FrmBuscarAula : Form
    {
        public FrmBuscarAula()
        {
            InitializeComponent();
        }

        public event EventHandler MandarAula;//se crea el evento nuevo

        int codAula = 0;//variable que se usara para mandar el id al evento

        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaAula logicaAU = new LogicaAula(Configuracion.getConnectionString);
            DataSet DSAU;

            try
            {
                DSAU = logicaAU.ListarAulas(condicion);
                if (DSAU.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvBuscarAula.DataSource = DSAU;
                    dgvBuscarAula.DataMember = DSAU.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void SeleccionarAula()
        {  //metodo que permite seleccionar el id de la fila del datagridview que se escoja

            if (dgvBuscarAula.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                codAula = (int)(dgvBuscarAula.SelectedRows[0].Cells[0].Value);////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                MandarAula(codAula, null);//le manda el id al evento  que esta en el otro form
                Close();//se cierra la ventana
            }
        }


        private void FrmBuscarAula_Load(object sender, EventArgs e)
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

        private void btnBuscarAula_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty; //condicion que se usara para realizar el filtrado en los datos para recuperar el profesor deseado
            try
            {
                if (!string.IsNullOrEmpty(txtCondicionAula.Text))//si no esta vacio
                {
                    if (rdnCodAula.Checked)
                    {
                        condicion = string.Format("CodigoAula like '%{0}%'", txtCondicionAula.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnTipoAula.Checked)
                    {
                        condicion = string.Format("TipoAula like '%{0}%'", txtCondicionAula.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    CargarDataSet(condicion);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvBuscarAula_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarAula();
        }

        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            SeleccionarAula();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MandarAula(-1, null);//evento aceptar
            Close();
        }
    }
}
