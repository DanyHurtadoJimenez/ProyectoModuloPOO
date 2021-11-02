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
    public partial class FrmBuscarMateriaAbierta : Form
    {
        public FrmBuscarMateriaAbierta()
        {
            InitializeComponent();
        }

        public event EventHandler MandarMateria;//se crea el evento nuevo

        int codMateriaAbierta = 0;//variable que se usara para mandar el id al evento

        private void CargarDataSet(string condicion = "")
        { //carga el datagridview con el dataset
            LogicaMateriaAbierta logicaMateriaAbierta = new LogicaMateriaAbierta(Configuracion.getConnectionString);
            DataSet dsMateriasAbiertas;

            try
            {
                dsMateriasAbiertas = logicaMateriaAbierta.ListarMateriasAbiertas(condicion);
                if (dsMateriasAbiertas.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvBuscarMateriaA.DataSource = dsMateriasAbiertas;
                    dgvBuscarMateriaA.DataMember = dsMateriasAbiertas.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void SeleccionarMateriaAbierta()
        {  //metodo que permite seleccionar el id de la fila del datagridview que se escoja

            if (dgvBuscarMateriaA.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                codMateriaAbierta = (int)(dgvBuscarMateriaA.SelectedRows[0].Cells[0].Value);////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
                MandarMateria(codMateriaAbierta, null);//le manda el id al evento  que esta en el otro form
                Close();//se cierra la ventana
            }
        }


        private void FrmBuscarMateriaAbierta_Load(object sender, EventArgs e)
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

        private void btnBuscarMateriaAbierta_Click(object sender, EventArgs e)
        {
            string condicion = string.Empty; 
            try
            {
                if (!string.IsNullOrEmpty(txtCondicionMateriaA.Text))//si no esta vacio
                {
                    if (rdnCodMateriaA.Checked)
                    {
                        condicion = string.Format("CodMateriaAbierta like '%{0}%'", txtCondicionMateriaA.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
                    }

                    if (rdnNombreMateriaA.Checked)
                    {
                        condicion = string.Format("NombreMateria like '%{0}%'", txtCondicionMateriaA.Text.Trim()); //donde en el nombre sea algo como lo que se escriba en el txtNombre el trim lo usa para quitar espacios
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
            SeleccionarMateriaAbierta();
        }

        private void dgvBuscarMateriaA_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarMateriaAbierta();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            MandarMateria(-1, null);//evento aceptar
            Close();
        }
    }
}
