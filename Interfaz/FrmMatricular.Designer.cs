
namespace Interfaz
{
    partial class FrmMatricular
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDescuentoE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmailE = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCedulaEstudiante = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtCarnetEstudiante = new System.Windows.Forms.TextBox();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.dtgvVerMateriaAbierta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbMateriasMatriculadas = new System.Windows.Forms.GroupBox();
            this.btnQuitarMateria = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.comboTipoPago = new System.Windows.Forms.ComboBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lblMontoMatricula = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblMontoDescuento = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblMontoIva = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.btnBuscarMatriculas = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerMateriaAbierta)).BeginInit();
            this.grbMateriasMatriculadas.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtDescuentoE);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmailE);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNombreEstudiante);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCedulaEstudiante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox1.Controls.Add(this.txtCarnetEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(12, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 71);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Estudiante";
            // 
            // txtDescuentoE
            // 
            this.txtDescuentoE.Enabled = false;
            this.txtDescuentoE.Location = new System.Drawing.Point(829, 33);
            this.txtDescuentoE.Name = "txtDescuentoE";
            this.txtDescuentoE.ReadOnly = true;
            this.txtDescuentoE.Size = new System.Drawing.Size(95, 23);
            this.txtDescuentoE.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(763, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descuento";
            // 
            // txtEmailE
            // 
            this.txtEmailE.Enabled = false;
            this.txtEmailE.Location = new System.Drawing.Point(650, 32);
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.ReadOnly = true;
            this.txtEmailE.Size = new System.Drawing.Size(107, 23);
            this.txtEmailE.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(603, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Enabled = false;
            this.txtNombreEstudiante.Location = new System.Drawing.Point(402, 32);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.ReadOnly = true;
            this.txtNombreEstudiante.Size = new System.Drawing.Size(195, 23);
            this.txtNombreEstudiante.TabIndex = 7;
            this.txtNombreEstudiante.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre  ";
            // 
            // txtCedulaEstudiante
            // 
            this.txtCedulaEstudiante.Enabled = false;
            this.txtCedulaEstudiante.Location = new System.Drawing.Point(220, 32);
            this.txtCedulaEstudiante.Name = "txtCedulaEstudiante";
            this.txtCedulaEstudiante.ReadOnly = true;
            this.txtCedulaEstudiante.Size = new System.Drawing.Size(125, 23);
            this.txtCedulaEstudiante.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cédula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Carnet";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(940, 22);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(99, 38);
            this.btnBuscarEstudiante.TabIndex = 1;
            this.btnBuscarEstudiante.Text = "Buscar Estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtCarnetEstudiante
            // 
            this.txtCarnetEstudiante.Enabled = false;
            this.txtCarnetEstudiante.Location = new System.Drawing.Point(59, 33);
            this.txtCarnetEstudiante.Name = "txtCarnetEstudiante";
            this.txtCarnetEstudiante.ReadOnly = true;
            this.txtCarnetEstudiante.Size = new System.Drawing.Size(114, 23);
            this.txtCarnetEstudiante.TabIndex = 0;
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.CustomFormat = "ddd dd MMM yyyy";
            this.dtpFechaMatricula.Enabled = false;
            this.dtpFechaMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaMatricula.Location = new System.Drawing.Point(254, 19);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(154, 23);
            this.dtpFechaMatricula.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(151, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 15);
            this.label11.TabIndex = 26;
            this.label11.Text = "Fecha Matricula: ";
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(11, 215);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(110, 42);
            this.btnBuscarMateria.TabIndex = 1;
            this.btnBuscarMateria.Text = "Buscar Materia";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.btnBuscarMateria_Click);
            // 
            // dtgvVerMateriaAbierta
            // 
            this.dtgvVerMateriaAbierta.AllowUserToAddRows = false;
            this.dtgvVerMateriaAbierta.AllowUserToDeleteRows = false;
            this.dtgvVerMateriaAbierta.AllowUserToResizeColumns = false;
            this.dtgvVerMateriaAbierta.AllowUserToResizeRows = false;
            this.dtgvVerMateriaAbierta.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgvVerMateriaAbierta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVerMateriaAbierta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column1,
            this.dataGridViewTextBoxColumn2,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.dtgvVerMateriaAbierta.Location = new System.Drawing.Point(11, 22);
            this.dtgvVerMateriaAbierta.Name = "dtgvVerMateriaAbierta";
            this.dtgvVerMateriaAbierta.RowTemplate.Height = 25;
            this.dtgvVerMateriaAbierta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvVerMateriaAbierta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVerMateriaAbierta.Size = new System.Drawing.Size(1023, 187);
            this.dtgvVerMateriaAbierta.TabIndex = 2;
            this.toolTip1.SetToolTip(this.dtgvVerMateriaAbierta, "Da doble click en cualquiera de las materias para ver su respectivo horario");
            this.dtgvVerMateriaAbierta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvVerMateriaAbierta_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CodMateriaAbierta";
            this.dataGridViewTextBoxColumn1.HeaderText = "codMA";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodigoMateria";
            this.Column1.HeaderText = "Cod Materia";
            this.Column1.Name = "Column1";
            this.Column1.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.Column1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NombreMateria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Materia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Requisito";
            this.Column2.HeaderText = "Cod Requisito";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nombreRequisito";
            this.Column3.HeaderText = "Nombre Requisito";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "corequisito";
            this.Column4.HeaderText = "Cod Corequisito";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "nombreCoRequisito";
            this.Column5.HeaderText = "Nombre Corequisito";
            this.Column5.Name = "Column5";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombreProfesor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre Profesor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "NumeroAula";
            this.dataGridViewTextBoxColumn5.HeaderText = "Número Aula";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Grupo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Costo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // grbMateriasMatriculadas
            // 
            this.grbMateriasMatriculadas.Controls.Add(this.btnBuscarMateria);
            this.grbMateriasMatriculadas.Controls.Add(this.btnQuitarMateria);
            this.grbMateriasMatriculadas.Controls.Add(this.dtgvVerMateriaAbierta);
            this.grbMateriasMatriculadas.Location = new System.Drawing.Point(12, 147);
            this.grbMateriasMatriculadas.Name = "grbMateriasMatriculadas";
            this.grbMateriasMatriculadas.Size = new System.Drawing.Size(1045, 263);
            this.grbMateriasMatriculadas.TabIndex = 3;
            this.grbMateriasMatriculadas.TabStop = false;
            this.grbMateriasMatriculadas.Text = "Materias Escogidas";
            // 
            // btnQuitarMateria
            // 
            this.btnQuitarMateria.Location = new System.Drawing.Point(877, 215);
            this.btnQuitarMateria.Name = "btnQuitarMateria";
            this.btnQuitarMateria.Size = new System.Drawing.Size(157, 42);
            this.btnQuitarMateria.TabIndex = 3;
            this.btnQuitarMateria.Text = "Quitar Materia de la lista";
            this.btnQuitarMateria.UseVisualStyleBackColor = true;
            this.btnQuitarMateria.Click += new System.EventHandler(this.btnQuitarMateria_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(425, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Periodo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(636, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Año";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 425);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Escojer Tipo Pago:";
            // 
            // comboTipoPago
            // 
            this.comboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPago.FormattingEnabled = true;
            this.comboTipoPago.Items.AddRange(new object[] {
            "Efectivo",
            "Tarjeta",
            "Transferencia",
            "Sinpe"});
            this.comboTipoPago.Location = new System.Drawing.Point(147, 421);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(121, 23);
            this.comboTipoPago.TabIndex = 32;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(294, 414);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 34);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar Matrícula";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(433, 415);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(120, 34);
            this.btnFacturar.TabIndex = 34;
            this.btnFacturar.Text = "Facturar Matricula";
            this.btnFacturar.UseVisualStyleBackColor = true;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPeriodo);
            this.groupBox3.Controls.Add(this.txtAnio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.txtNumFactura);
            this.groupBox3.Controls.Add(this.dtpFechaMatricula);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(109, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(849, 52);
            this.groupBox3.TabIndex = 35;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Información Matrícula";
            // 
            // txtPeriodo
            // 
            this.txtPeriodo.Enabled = false;
            this.txtPeriodo.Location = new System.Drawing.Point(483, 19);
            this.txtPeriodo.Name = "txtPeriodo";
            this.txtPeriodo.ReadOnly = true;
            this.txtPeriodo.Size = new System.Drawing.Size(121, 23);
            this.txtPeriodo.TabIndex = 38;
            // 
            // txtAnio
            // 
            this.txtAnio.Enabled = false;
            this.txtAnio.Location = new System.Drawing.Point(679, 19);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.ReadOnly = true;
            this.txtAnio.Size = new System.Drawing.Size(148, 23);
            this.txtAnio.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 15);
            this.label10.TabIndex = 36;
            this.label10.Text = "No.Factura";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.Enabled = false;
            this.txtNumFactura.Location = new System.Drawing.Point(86, 19);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.ReadOnly = true;
            this.txtNumFactura.Size = new System.Drawing.Size(42, 23);
            this.txtNumFactura.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(788, 424);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(127, 15);
            this.label13.TabIndex = 38;
            this.label13.Text = "Monto de la Matricula:";
            // 
            // lblMontoMatricula
            // 
            this.lblMontoMatricula.AutoSize = true;
            this.lblMontoMatricula.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoMatricula.Location = new System.Drawing.Point(948, 424);
            this.lblMontoMatricula.Name = "lblMontoMatricula";
            this.lblMontoMatricula.Size = new System.Drawing.Size(0, 20);
            this.lblMontoMatricula.TabIndex = 39;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(788, 466);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 15);
            this.label15.TabIndex = 40;
            this.label15.Text = "Subtotal:";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtotal.Location = new System.Drawing.Point(948, 464);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(0, 20);
            this.lblSubtotal.TabIndex = 41;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(788, 510);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(124, 15);
            this.label17.TabIndex = 42;
            this.label17.Text = "Descuento Estudiante:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescuento.Location = new System.Drawing.Point(948, 510);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(0, 20);
            this.lblDescuento.TabIndex = 43;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(788, 553);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 15);
            this.label19.TabIndex = 44;
            this.label19.Text = "Monto Descuento";
            // 
            // lblMontoDescuento
            // 
            this.lblMontoDescuento.AutoSize = true;
            this.lblMontoDescuento.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoDescuento.Location = new System.Drawing.Point(948, 553);
            this.lblMontoDescuento.Name = "lblMontoDescuento";
            this.lblMontoDescuento.Size = new System.Drawing.Size(0, 20);
            this.lblMontoDescuento.TabIndex = 45;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(788, 597);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(85, 15);
            this.label21.TabIndex = 46;
            this.label21.Text = "Monto IVA 2%:";
            // 
            // lblMontoIva
            // 
            this.lblMontoIva.AutoSize = true;
            this.lblMontoIva.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMontoIva.Location = new System.Drawing.Point(948, 597);
            this.lblMontoIva.Name = "lblMontoIva";
            this.lblMontoIva.Size = new System.Drawing.Size(0, 20);
            this.lblMontoIva.TabIndex = 47;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(788, 637);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(77, 15);
            this.label23.TabIndex = 48;
            this.label23.Text = "Total a pagar:";
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalPagar.Location = new System.Drawing.Point(948, 637);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 20);
            this.lblTotalPagar.TabIndex = 49;
            // 
            // btnBuscarMatriculas
            // 
            this.btnBuscarMatriculas.Location = new System.Drawing.Point(583, 415);
            this.btnBuscarMatriculas.Name = "btnBuscarMatriculas";
            this.btnBuscarMatriculas.Size = new System.Drawing.Size(120, 34);
            this.btnBuscarMatriculas.TabIndex = 50;
            this.btnBuscarMatriculas.Text = "Buscar Matriculas";
            this.btnBuscarMatriculas.UseVisualStyleBackColor = true;
            this.btnBuscarMatriculas.Click += new System.EventHandler(this.btnBuscarMatriculas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interfaz.Properties.Resources.matricula;
            this.pictureBox1.Location = new System.Drawing.Point(12, 464);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(691, 188);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMatricular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1063, 665);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBuscarMatriculas);
            this.Controls.Add(this.lblTotalPagar);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblMontoIva);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.lblMontoDescuento);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lblMontoMatricula);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboTipoPago);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.grbMateriasMatriculadas);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FrmMatricular";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matricular un estudiante";
            this.Load += new System.EventHandler(this.FrmMatricular_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerMateriaAbierta)).EndInit();
            this.grbMateriasMatriculadas.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TextBox txtCarnetEstudiante;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.DataGridView dtgvVerMateriaAbierta;
        private System.Windows.Forms.GroupBox grbMateriasMatriculadas;
        private System.Windows.Forms.TextBox txtDescuentoE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmailE;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCedulaEstudiante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnQuitarMateria;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblMontoMatricula;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblMontoDescuento;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMontoIva;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Button btnBuscarMatriculas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}