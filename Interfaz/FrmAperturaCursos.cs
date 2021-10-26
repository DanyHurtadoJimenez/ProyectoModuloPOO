using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmAperturaCursos : Form
    {
        public FrmAperturaCursos()
        {
            InitializeComponent();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FrmBuscarMateria formularioBuscarM = new FrmBuscarMateria();
            formularioBuscarM.ShowDialog(this);
        }
    }
}
