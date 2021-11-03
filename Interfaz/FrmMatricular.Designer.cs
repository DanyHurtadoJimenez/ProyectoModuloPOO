
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
            this.button1 = new System.Windows.Forms.Button();
            this.dtgvVerMateriaAbierta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPeriodo = new System.Windows.Forms.TextBox();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMontoMatricula = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVerMateriaAbierta)).BeginInit();
            this.grbMateriasMatriculadas.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(849, 96);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Estudiante";
            // 
            // txtDescuentoE
            // 
            this.txtDescuentoE.Enabled = false;
            this.txtDescuentoE.Location = new System.Drawing.Point(483, 58);
            this.txtDescuentoE.Name = "txtDescuentoE";
            this.txtDescuentoE.ReadOnly = true;
            this.txtDescuentoE.Size = new System.Drawing.Size(95, 23);
            this.txtDescuentoE.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(414, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Descuento";
            // 
            // txtEmailE
            // 
            this.txtEmailE.Enabled = false;
            this.txtEmailE.Location = new System.Drawing.Point(260, 58);
            this.txtEmailE.Name = "txtEmailE";
            this.txtEmailE.ReadOnly = true;
            this.txtEmailE.Size = new System.Drawing.Size(148, 23);
            this.txtEmailE.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "E-mail";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.Enabled = false;
            this.txtNombreEstudiante.Location = new System.Drawing.Point(260, 32);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.ReadOnly = true;
            this.txtNombreEstudiante.Size = new System.Drawing.Size(318, 23);
            this.txtNombreEstudiante.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre  ";
            // 
            // txtCedulaEstudiante
            // 
            this.txtCedulaEstudiante.Enabled = false;
            this.txtCedulaEstudiante.Location = new System.Drawing.Point(61, 58);
            this.txtCedulaEstudiante.Name = "txtCedulaEstudiante";
            this.txtCedulaEstudiante.ReadOnly = true;
            this.txtCedulaEstudiante.Size = new System.Drawing.Size(125, 23);
            this.txtCedulaEstudiante.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 61);
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
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(679, 44);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(148, 23);
            this.btnBuscarEstudiante.TabIndex = 1;
            this.btnBuscarEstudiante.Text = "Buscar Estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtCarnetEstudiante
            // 
            this.txtCarnetEstudiante.Enabled = false;
            this.txtCarnetEstudiante.Location = new System.Drawing.Point(61, 32);
            this.txtCarnetEstudiante.Name = "txtCarnetEstudiante";
            this.txtCarnetEstudiante.ReadOnly = true;
            this.txtCarnetEstudiante.Size = new System.Drawing.Size(125, 23);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Buscar Materia";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8});
            this.dtgvVerMateriaAbierta.Location = new System.Drawing.Point(11, 22);
            this.dtgvVerMateriaAbierta.Name = "dtgvVerMateriaAbierta";
            this.dtgvVerMateriaAbierta.RowTemplate.Height = 25;
            this.dtgvVerMateriaAbierta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvVerMateriaAbierta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvVerMateriaAbierta.Size = new System.Drawing.Size(816, 187);
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
            this.Column1.DataPropertyName = "CodMateria";
            this.Column1.HeaderText = "Cod Materia";
            this.Column1.Name = "Column1";
            this.Column1.ToolTipText = "Da doble click para ver el horario de esta materia";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombreMateria";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre Materia";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nombreProfesor";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nombre Profesor";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn4.Width = 235;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "numAula";
            this.dataGridViewTextBoxColumn5.HeaderText = "Número Aula";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "grupo";
            this.dataGridViewTextBoxColumn6.HeaderText = "Grupo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "costo";
            this.dataGridViewTextBoxColumn8.HeaderText = "Costo";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ToolTipText = "Da doble click para ver el horario de esta materia";
            this.dataGridViewTextBoxColumn8.Width = 80;
            // 
            // grbMateriasMatriculadas
            // 
            this.grbMateriasMatriculadas.Controls.Add(this.button1);
            this.grbMateriasMatriculadas.Controls.Add(this.btnQuitarMateria);
            this.grbMateriasMatriculadas.Controls.Add(this.dtgvVerMateriaAbierta);
            this.grbMateriasMatriculadas.Location = new System.Drawing.Point(12, 172);
            this.grbMateriasMatriculadas.Name = "grbMateriasMatriculadas";
            this.grbMateriasMatriculadas.Size = new System.Drawing.Size(849, 263);
            this.grbMateriasMatriculadas.TabIndex = 3;
            this.grbMateriasMatriculadas.TabStop = false;
            this.grbMateriasMatriculadas.Text = "Materias Escogidas";
            // 
            // btnQuitarMateria
            // 
            this.btnQuitarMateria.Location = new System.Drawing.Point(670, 215);
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
            this.label7.Location = new System.Drawing.Point(352, 456);
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
            this.comboTipoPago.Location = new System.Drawing.Point(471, 453);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(121, 23);
            this.comboTipoPago.TabIndex = 32;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(142, 479);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(137, 23);
            this.txtTotalPagar.TabIndex = 30;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 15);
            this.label9.TabIndex = 29;
            this.label9.Text = "Total a Pagar: ";
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(741, 446);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(120, 34);
            this.btnPagar.TabIndex = 17;
            this.btnPagar.Text = "Guardar Matrícula";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // btnFacturar
            // 
            this.btnFacturar.Location = new System.Drawing.Point(605, 446);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(120, 34);
            this.btnFacturar.TabIndex = 34;
            this.btnFacturar.Text = "Facturar Matricula";
            this.btnFacturar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPeriodo);
            this.groupBox3.Controls.Add(this.txtAnio);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.dtpFechaMatricula);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
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
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(86, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(42, 23);
            this.textBox1.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 446);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Monto de la Matrícula";
            // 
            // txtMontoMatricula
            // 
            this.txtMontoMatricula.Enabled = false;
            this.txtMontoMatricula.Location = new System.Drawing.Point(142, 443);
            this.txtMontoMatricula.Name = "txtMontoMatricula";
            this.txtMontoMatricula.ReadOnly = true;
            this.txtMontoMatricula.Size = new System.Drawing.Size(137, 23);
            this.txtMontoMatricula.TabIndex = 37;
            // 
            // FrmMatricular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(873, 509);
            this.Controls.Add(this.txtMontoMatricula);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboTipoPago);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnPagar);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TextBox txtCarnetEstudiante;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnQuitarMateria;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMontoMatricula;
        private System.Windows.Forms.TextBox txtPeriodo;
        private System.Windows.Forms.TextBox txtAnio;
    }
}