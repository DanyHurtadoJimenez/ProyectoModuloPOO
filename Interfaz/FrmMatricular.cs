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
                        txtCedulaEstudiante.Text = estudiante.Cedula;
                        txtNombreEstudiante.Text = string.Format("{0} {1} {2}", estudiante.Nombre,estudiante.Apellido1,estudiante.Apellido2);
                        txtEmailE.Text = estudiante.CorreoElectronico;
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
                FrmBuscarMateriaAbierta FrmBuscarMateriaA = new FrmBuscarMateriaAbierta(int.Parse(txtPeriodo.Text),int.Parse(txtAnio.Text));
                FrmBuscarMateriaA.MandarMateria += new EventHandler(TraerMateria);
                FrmBuscarMateriaA.ShowDialog();
        }

        private void TraerMateria(object codMateriaAbierta, EventArgs e)
        {
            try
            {
                int codMA = (int)codMateriaAbierta;
                if (codMA != -1)
                {
                    MateriasAbiertas materiaAbierta;
                    LogicaMateriaAbierta logicaMA = new LogicaMateriaAbierta(Configuracion.getConnectionString);
                    materiaAbierta = logicaMA.ObtenerMateriaAbierta(codMA);

                    if (materiaAbierta != null)
                    {

                        if (listaMateriasA.Count > 0)
                        {
                            int i = 0;
                            int contador = 0;

                            while (i < listaMateriasA.Count) //con este while se impide que el usuario escoja otra materia igual a la que ya tiene escogida
                            {
                                if (listaMateriasA[i].CodigoMateriaCarrera.CodigoMateriaCarrera == materiaAbierta.CodigoMateriaCarrera.CodigoMateriaCarrera)//se fija si ya escogio esa materia
                                {
                                    contador += 1;
                                }
                                i++;
                            }

                            if (contador == 0)
                            {
                                listaMateriasA.Add(materiaAbierta);
                                DataSet datos = new DataSet();

                                datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                                dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                                dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
                            }
                            else
                            {
                                MessageBox.Show("Debe ingresar una materia diferente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            listaMateriasA.Add(materiaAbierta);
                            DataSet datos = new DataSet();

                            datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                            dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                            dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
                        }

                        txtTotalPagar.Text = string.Format("₡ {0}", calcularCostos(Convert.ToDecimal(txtDescuentoE.Text), listaMateriasA));///////////////////////////////////////////////////////////////

                    }
                    else
                    {
                        MessageBox.Show("La materia no se encuentra en la base de datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmMatricular_Load(object sender, EventArgs e)
        {
            dtpFechaMatricula.Value = DateTime.Today;
            LogicaValoresReferencia logicaValores = new LogicaValoresReferencia(Configuracion.getConnectionString);
            ValoresReferencia valoresR = new ValoresReferencia();
            valoresR =  logicaValores.RecuperarPeriodoAnio();
            txtPeriodo.Text = valoresR.Periodo.ToString();
            txtAnio.Text = valoresR.Anio.ToString();
            txtMontoMatricula.Text = valoresR.MontoMatricula.ToString();
        }

        public DataSet GenerarDataSet(List<MateriasAbiertas> materiasAbiertas) //genera un dataset con el horario que se le manda
        {
            DataSet dataSet = new DataSet();
            DataTable dataTable = new DataTable();

            dataSet.Tables.Add(dataTable);
            dataTable.Columns.Add("CodMateriaAbierta");
            dataTable.Columns.Add("CodMateria");
            dataTable.Columns.Add("nombreMateria");
            dataTable.Columns.Add("nombreProfesor");
            dataTable.Columns.Add("numAula");
            dataTable.Columns.Add("grupo");
            dataTable.Columns.Add("costo");

            foreach (var Item in materiasAbiertas)
            {
                dataTable.Rows.Add(new object[] { 
                    Item.CodigoMateriaAbierta, 
                    Item.CodigoMateriaCarrera.CodigoMateria.CodigoMateria, 
                    Item.CodigoMateriaCarrera.CodigoMateria.NombreMateria,
                    Item.CodigoProfesor.Nombre,
                    Item.CodigoAula.NumeroAula,
                    Item.Grupo,
                    Item.Costo
                });
            }

            return dataSet;
        }

        private void dtgvVerMateriaAbierta_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (dtgvVerMateriaAbierta.SelectedRows.Count > 0) //si ha seleccionado una fila
            {
                int codMateriaAbierta;
                codMateriaAbierta = Convert.ToInt32((dtgvVerMateriaAbierta.SelectedRows[0].Cells[0].Value));//se obtiene el codigo de la materia carrera de la materia seleccionada
                FrmMostrarHorarios mostrarHorarios = new FrmMostrarHorarios(codMateriaAbierta);
                mostrarHorarios.ShowDialog();
            }
        }

        private void btnQuitarMateria_Click(object sender, EventArgs e)
        {
            if (dtgvVerMateriaAbierta.Rows.Count > 0)
            {
                int indiceMateria = dtgvVerMateriaAbierta.SelectedRows[0].Cells[0].RowIndex; //selecciona el indice de la fila del datagrid para poder quitar la materia
                listaMateriasA.RemoveAt(indiceMateria);//remueve la materia de la lista
                DataSet datos = new DataSet();

                datos = GenerarDataSet(listaMateriasA); //llena el data grid view con la lista que se le envía

                dtgvVerMateriaAbierta.DataSource = datos; //se carga el datagrid con el dataset
                dtgvVerMateriaAbierta.DataMember = datos.Tables[0].TableName;
                txtTotalPagar.Text = string.Format("₡ {0}", calcularCostos(Convert.ToDecimal(txtDescuentoE.Text), listaMateriasA));//vuelve a calcular los costos///////////////////////////////////////////////////////
            }
           
        }
    }//fin del form
}//fin del namespace
