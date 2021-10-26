
namespace Interfaz
{
    partial class FrmAperturaCursos
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
            this.GrbBuscarMateria = new System.Windows.Forms.GroupBox();
            this.dtgvMostrarMateria = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvMostrarHorario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDiasSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnQuitarProfesor = new System.Windows.Forms.Button();
            this.lblNombreCarrera = new System.Windows.Forms.Label();
            this.dtgvMostrasrProfesor = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarProfesor = new System.Windows.Forms.Button();
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnQuitarAula = new System.Windows.Forms.Button();
            this.btnBuscarAula = new System.Windows.Forms.Button();
            this.txtBuscarAula = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grbEliminarMateria = new System.Windows.Forms.GroupBox();
            this.GrbBuscarMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarMateria)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarHorario)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrasrProfesor)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbEliminarMateria.SuspendLayout();
            this.SuspendLayout();
            // 
            // GrbBuscarMateria
            // 
            this.GrbBuscarMateria.Controls.Add(this.dtgvMostrarMateria);
            this.GrbBuscarMateria.Controls.Add(this.BtnBuscar);
            this.GrbBuscarMateria.Controls.Add(this.txtBuscarMateria);
            this.GrbBuscarMateria.Location = new System.Drawing.Point(12, 12);
            this.GrbBuscarMateria.Name = "GrbBuscarMateria";
            this.GrbBuscarMateria.Size = new System.Drawing.Size(755, 135);
            this.GrbBuscarMateria.TabIndex = 0;
            this.GrbBuscarMateria.TabStop = false;
            this.GrbBuscarMateria.Text = "Buscar Materia";
            // 
            // dtgvMostrarMateria
            // 
            this.dtgvMostrarMateria.AllowUserToAddRows = false;
            this.dtgvMostrarMateria.AllowUserToDeleteRows = false;
            this.dtgvMostrarMateria.AllowUserToResizeColumns = false;
            this.dtgvMostrarMateria.AllowUserToResizeRows = false;
            this.dtgvMostrarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostrarMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtgvMostrarMateria.Location = new System.Drawing.Point(6, 51);
            this.dtgvMostrarMateria.Name = "dtgvMostrarMateria";
            this.dtgvMostrarMateria.RowTemplate.Height = 25;
            this.dtgvMostrarMateria.Size = new System.Drawing.Size(741, 71);
            this.dtgvMostrarMateria.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Materia";
            this.Column2.Name = "Column2";
            this.Column2.Width = 115;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Materia";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Creditos";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cod Carrera";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombre Carrera";
            this.Column6.Name = "Column6";
            this.Column6.Width = 180;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(203, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(100, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar Materia";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(6, 22);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(169, 23);
            this.txtBuscarMateria.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgvMostrarHorario);
            this.groupBox1.Controls.Add(this.btnModificarHorario);
            this.groupBox1.Controls.Add(this.btnAgregarHorario);
            this.groupBox1.Controls.Add(this.dtpHoraFinal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpHoraInicio);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboDiasSemana);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 224);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definir Horario para la materia";
            // 
            // dtgvMostrarHorario
            // 
            this.dtgvMostrarHorario.AllowUserToAddRows = false;
            this.dtgvMostrarHorario.AllowUserToDeleteRows = false;
            this.dtgvMostrarHorario.AllowUserToResizeColumns = false;
            this.dtgvMostrarHorario.AllowUserToResizeRows = false;
            this.dtgvMostrarHorario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostrarHorario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column8});
            this.dtgvMostrarHorario.Location = new System.Drawing.Point(99, 68);
            this.dtgvMostrarHorario.Name = "dtgvMostrarHorario";
            this.dtgvMostrarHorario.RowTemplate.Height = 25;
            this.dtgvMostrarHorario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMostrarHorario.Size = new System.Drawing.Size(553, 136);
            this.dtgvMostrarHorario.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Día";
            this.Column1.Name = "Column1";
            this.Column1.Width = 170;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Hora de Inicio";
            this.Column7.Name = "Column7";
            this.Column7.Width = 170;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Hora de Fin";
            this.Column8.Name = "Column8";
            this.Column8.Width = 170;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Enabled = false;
            this.btnModificarHorario.Location = new System.Drawing.Point(621, 28);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(112, 23);
            this.btnModificarHorario.TabIndex = 7;
            this.btnModificarHorario.Text = "Modificar Horario";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(493, 28);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarHorario.TabIndex = 6;
            this.btnAgregarHorario.Text = "Agregar Horario";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(403, 28);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(75, 23);
            this.dtpHoraFinal.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Fin";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(252, 28);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(75, 23);
            this.dtpHoraInicio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(181, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora Inicio";
            // 
            // comboDiasSemana
            // 
            this.comboDiasSemana.FormattingEnabled = true;
            this.comboDiasSemana.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.comboDiasSemana.Location = new System.Drawing.Point(54, 28);
            this.comboDiasSemana.Name = "comboDiasSemana";
            this.comboDiasSemana.Size = new System.Drawing.Size(121, 23);
            this.comboDiasSemana.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnQuitarProfesor);
            this.groupBox2.Controls.Add(this.lblNombreCarrera);
            this.groupBox2.Controls.Add(this.dtgvMostrasrProfesor);
            this.groupBox2.Controls.Add(this.btnBuscarProfesor);
            this.groupBox2.Controls.Add(this.txtBuscarProfesor);
            this.groupBox2.Location = new System.Drawing.Point(12, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 155);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Definir Profesor";
            // 
            // btnQuitarProfesor
            // 
            this.btnQuitarProfesor.Enabled = false;
            this.btnQuitarProfesor.Location = new System.Drawing.Point(323, 22);
            this.btnQuitarProfesor.Name = "btnQuitarProfesor";
            this.btnQuitarProfesor.Size = new System.Drawing.Size(100, 23);
            this.btnQuitarProfesor.TabIndex = 4;
            this.btnQuitarProfesor.Text = "Quitar Profesor";
            this.btnQuitarProfesor.UseVisualStyleBackColor = true;
            // 
            // lblNombreCarrera
            // 
            this.lblNombreCarrera.AutoSize = true;
            this.lblNombreCarrera.Location = new System.Drawing.Point(439, 25);
            this.lblNombreCarrera.Name = "lblNombreCarrera";
            this.lblNombreCarrera.Size = new System.Drawing.Size(0, 15);
            this.lblNombreCarrera.TabIndex = 3;
            // 
            // dtgvMostrasrProfesor
            // 
            this.dtgvMostrasrProfesor.AllowUserToAddRows = false;
            this.dtgvMostrasrProfesor.AllowUserToDeleteRows = false;
            this.dtgvMostrasrProfesor.AllowUserToResizeColumns = false;
            this.dtgvMostrasrProfesor.AllowUserToResizeRows = false;
            this.dtgvMostrasrProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMostrasrProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dtgvMostrasrProfesor.Location = new System.Drawing.Point(6, 61);
            this.dtgvMostrasrProfesor.Name = "dtgvMostrasrProfesor";
            this.dtgvMostrasrProfesor.RowTemplate.Height = 25;
            this.dtgvMostrasrProfesor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMostrasrProfesor.Size = new System.Drawing.Size(741, 83);
            this.dtgvMostrasrProfesor.TabIndex = 2;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "CodProfe";
            this.Column9.Name = "Column9";
            this.Column9.Width = 70;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Nombre Profesor";
            this.Column10.Name = "Column10";
            this.Column10.Width = 155;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Primer Apellido";
            this.Column11.Name = "Column11";
            this.Column11.Width = 155;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Segundo Apellido";
            this.Column12.Name = "Column12";
            this.Column12.Width = 155;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Correo Eléctronico";
            this.Column13.Name = "Column13";
            this.Column13.Width = 160;
            // 
            // btnBuscarProfesor
            // 
            this.btnBuscarProfesor.Location = new System.Drawing.Point(203, 22);
            this.btnBuscarProfesor.Name = "btnBuscarProfesor";
            this.btnBuscarProfesor.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarProfesor.TabIndex = 1;
            this.btnBuscarProfesor.Text = "Buscar Profesor";
            this.btnBuscarProfesor.UseVisualStyleBackColor = true;
            // 
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(6, 22);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(169, 23);
            this.txtBuscarProfesor.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.btnQuitarAula);
            this.groupBox3.Controls.Add(this.btnBuscarAula);
            this.groupBox3.Controls.Add(this.txtBuscarAula);
            this.groupBox3.Location = new System.Drawing.Point(12, 544);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Asignar Aula";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column14,
            this.Column15,
            this.Column16,
            this.Column17});
            this.dataGridView1.Location = new System.Drawing.Point(6, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(741, 92);
            this.dataGridView1.TabIndex = 3;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Código Aula";
            this.Column14.Name = "Column14";
            this.Column14.Width = 175;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Tipo Aula";
            this.Column15.Name = "Column15";
            this.Column15.Width = 185;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Número Aula";
            this.Column16.Name = "Column16";
            this.Column16.Width = 185;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Capacidad";
            this.Column17.Name = "Column17";
            this.Column17.Width = 185;
            // 
            // btnQuitarAula
            // 
            this.btnQuitarAula.Location = new System.Drawing.Point(323, 22);
            this.btnQuitarAula.Name = "btnQuitarAula";
            this.btnQuitarAula.Size = new System.Drawing.Size(100, 23);
            this.btnQuitarAula.TabIndex = 2;
            this.btnQuitarAula.Text = "Quitar Aula";
            this.btnQuitarAula.UseVisualStyleBackColor = true;
            // 
            // btnBuscarAula
            // 
            this.btnBuscarAula.Location = new System.Drawing.Point(203, 22);
            this.btnBuscarAula.Name = "btnBuscarAula";
            this.btnBuscarAula.Size = new System.Drawing.Size(100, 23);
            this.btnBuscarAula.TabIndex = 1;
            this.btnBuscarAula.Text = "Buscar Aula";
            this.btnBuscarAula.UseVisualStyleBackColor = true;
            // 
            // txtBuscarAula
            // 
            this.txtBuscarAula.Location = new System.Drawing.Point(6, 22);
            this.txtBuscarAula.Name = "txtBuscarAula";
            this.txtBuscarAula.Size = new System.Drawing.Size(169, 23);
            this.txtBuscarAula.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(41, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 4;
            this.button1.Text = "Eliminar Materia";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // grbEliminarMateria
            // 
            this.grbEliminarMateria.Controls.Add(this.button1);
            this.grbEliminarMateria.Location = new System.Drawing.Point(12, 709);
            this.grbEliminarMateria.Name = "grbEliminarMateria";
            this.grbEliminarMateria.Size = new System.Drawing.Size(200, 75);
            this.grbEliminarMateria.TabIndex = 5;
            this.grbEliminarMateria.TabStop = false;
            this.grbEliminarMateria.Text = "Eliminar Materia";
            // 
            // FrmAperturaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(780, 790);
            this.Controls.Add(this.grbEliminarMateria);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrbBuscarMateria);
            this.MaximizeBox = false;
            this.Name = "FrmAperturaCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Apertura de Cursos";
            this.GrbBuscarMateria.ResumeLayout(false);
            this.GrbBuscarMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarMateria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarHorario)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrasrProfesor)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbEliminarMateria.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbBuscarMateria;
        private System.Windows.Forms.DataGridView dtgvMostrarMateria;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDiasSemana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvMostrarHorario;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgvMostrasrProfesor;
        private System.Windows.Forms.Button btnBuscarProfesor;
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.Label lblNombreCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnQuitarProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnBuscarAula;
        private System.Windows.Forms.TextBox txtBuscarAula;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnQuitarAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbEliminarMateria;
    }
}