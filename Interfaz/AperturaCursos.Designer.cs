
namespace Interfaz
{
    partial class AperturaCursos
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
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.dtgvMostrarMateria = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHoraFinal = new System.Windows.Forms.DateTimePicker();
            this.btnAgregarHorario = new System.Windows.Forms.Button();
            this.btnModificarHorario = new System.Windows.Forms.Button();
            this.dtgvMostrarHorario = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrbBuscarMateria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarMateria)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarHorario)).BeginInit();
            this.SuspendLayout();
            // 
            // GrbBuscarMateria
            // 
            this.GrbBuscarMateria.Controls.Add(this.dtgvMostrarMateria);
            this.GrbBuscarMateria.Controls.Add(this.BtnBuscar);
            this.GrbBuscarMateria.Controls.Add(this.txtBuscarMateria);
            this.GrbBuscarMateria.Location = new System.Drawing.Point(12, 12);
            this.GrbBuscarMateria.Name = "GrbBuscarMateria";
            this.GrbBuscarMateria.Size = new System.Drawing.Size(889, 135);
            this.GrbBuscarMateria.TabIndex = 0;
            this.GrbBuscarMateria.TabStop = false;
            this.GrbBuscarMateria.Text = "Buscar Materia";
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(6, 22);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(169, 23);
            this.txtBuscarMateria.TabIndex = 1;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(203, 21);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscar.TabIndex = 2;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
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
            this.dtgvMostrarMateria.Size = new System.Drawing.Size(877, 71);
            this.dtgvMostrarMateria.TabIndex = 1;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Materia";
            this.Column2.Name = "Column2";
            this.Column2.Width = 170;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Materia";
            this.Column3.Name = "Column3";
            this.Column3.Width = 170;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Creditos";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Cod Carrera";
            this.Column5.Name = "Column5";
            this.Column5.Width = 170;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Nombre Carrera";
            this.Column6.Name = "Column6";
            this.Column6.Width = 170;
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
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Definir Horario para la materia";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Día";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.comboBox1.Location = new System.Drawing.Point(85, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 23);
            this.comboBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hora Inicio";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraInicio.Location = new System.Drawing.Point(296, 25);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(75, 23);
            this.dtpHoraInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(396, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hora Fin";
            // 
            // dtpHoraFinal
            // 
            this.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHoraFinal.Location = new System.Drawing.Point(454, 25);
            this.dtpHoraFinal.Name = "dtpHoraFinal";
            this.dtpHoraFinal.ShowUpDown = true;
            this.dtpHoraFinal.Size = new System.Drawing.Size(75, 23);
            this.dtpHoraFinal.TabIndex = 5;
            // 
            // btnAgregarHorario
            // 
            this.btnAgregarHorario.Location = new System.Drawing.Point(572, 24);
            this.btnAgregarHorario.Name = "btnAgregarHorario";
            this.btnAgregarHorario.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarHorario.TabIndex = 6;
            this.btnAgregarHorario.Text = "Agregar Horario";
            this.btnAgregarHorario.UseVisualStyleBackColor = true;
            // 
            // btnModificarHorario
            // 
            this.btnModificarHorario.Enabled = false;
            this.btnModificarHorario.Location = new System.Drawing.Point(736, 25);
            this.btnModificarHorario.Name = "btnModificarHorario";
            this.btnModificarHorario.Size = new System.Drawing.Size(112, 23);
            this.btnModificarHorario.TabIndex = 7;
            this.btnModificarHorario.Text = "Modificar Horario";
            this.btnModificarHorario.UseVisualStyleBackColor = true;
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
            this.dtgvMostrarHorario.Location = new System.Drawing.Point(180, 54);
            this.dtgvMostrarHorario.Name = "dtgvMostrarHorario";
            this.dtgvMostrarHorario.RowTemplate.Height = 25;
            this.dtgvMostrarHorario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvMostrarHorario.Size = new System.Drawing.Size(553, 157);
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
            // AperturaCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.GrbBuscarMateria);
            this.Name = "AperturaCursos";
            this.Text = "Apertura de Cursos";
            this.GrbBuscarMateria.ResumeLayout(false);
            this.GrbBuscarMateria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarMateria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMostrarHorario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrbBuscarMateria;
        private System.Windows.Forms.DataGridView dtgvMostrarMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtpHoraFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvMostrarHorario;
        private System.Windows.Forms.Button btnModificarHorario;
        private System.Windows.Forms.Button btnAgregarHorario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}