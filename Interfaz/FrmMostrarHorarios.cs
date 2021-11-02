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
    public partial class FrmMostrarHorarios : Form
    {
        int codMA;
        public FrmMostrarHorarios(int codMateriaAbierta)
        {
            codMA = codMateriaAbierta;
            InitializeComponent();
        }

        private void CargarDataSet()
        { //carga el datagridview con el dataset
            LogicaHorarios logicaH = new LogicaHorarios(Configuracion.getConnectionString);
            DataSet DSAU;

            try
            {
                DSAU = logicaH.ListarHorarios(codMA);
                if (DSAU.Tables[0].Rows.Count > 0) //si tiene algo el data set entonces carguelo en el datagridview
                {
                    dgvVerHorarios.DataSource = DSAU;
                    dgvVerHorarios.DataMember = DSAU.Tables[0].TableName;//en la tabla con nombre Clientes del dataset
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void FrmMostrarHorarios_Load(object sender, EventArgs e)
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
