using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void abrirMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAperturaCursos formularioAperturaCursos = new FrmAperturaCursos();
            formularioAperturaCursos.ShowDialog(this);
        }

        private void matricularEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMatricular formularioMatricular = new FrmMatricular();
            formularioMatricular.ShowDialog(this);
        }
    }
}
