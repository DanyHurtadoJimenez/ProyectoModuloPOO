
namespace Interfaz
{
    partial class FrmBuscarMatriculas
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnNombreEstudiante = new System.Windows.Forms.RadioButton();
            this.btnBuscarMatricula = new System.Windows.Forms.Button();
            this.txtCondicionMatricula = new System.Windows.Forms.TextBox();
            this.rdnCedulaEstudiante = new System.Windows.Forms.RadioButton();
            this.rdnCarnetEstudiante = new System.Windows.Forms.RadioButton();
            this.btnSeleccionarMatricula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarMatriculas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMatriculas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(722, 566);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnNombreEstudiante);
            this.groupBox1.Controls.Add(this.btnBuscarMatricula);
            this.groupBox1.Controls.Add(this.txtCondicionMatricula);
            this.groupBox1.Controls.Add(this.rdnCedulaEstudiante);
            this.groupBox1.Controls.Add(this.rdnCarnetEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(845, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // rdnNombreEstudiante
            // 
            this.rdnNombreEstudiante.AutoSize = true;
            this.rdnNombreEstudiante.Location = new System.Drawing.Point(267, 25);
            this.rdnNombreEstudiante.Name = "rdnNombreEstudiante";
            this.rdnNombreEstudiante.Size = new System.Drawing.Size(127, 19);
            this.rdnNombreEstudiante.TabIndex = 7;
            this.rdnNombreEstudiante.TabStop = true;
            this.rdnNombreEstudiante.Text = "Nombre Estudiante";
            this.rdnNombreEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMatricula
            // 
            this.btnBuscarMatricula.Location = new System.Drawing.Point(642, 24);
            this.btnBuscarMatricula.Name = "btnBuscarMatricula";
            this.btnBuscarMatricula.Size = new System.Drawing.Size(166, 23);
            this.btnBuscarMatricula.TabIndex = 6;
            this.btnBuscarMatricula.Text = "Buscar Matricula Estudiante";
            this.btnBuscarMatricula.UseVisualStyleBackColor = true;
            this.btnBuscarMatricula.Click += new System.EventHandler(this.btnBuscarMatricula_Click);
            // 
            // txtCondicionMatricula
            // 
            this.txtCondicionMatricula.Enabled = false;
            this.txtCondicionMatricula.Location = new System.Drawing.Point(430, 24);
            this.txtCondicionMatricula.Name = "txtCondicionMatricula";
            this.txtCondicionMatricula.Size = new System.Drawing.Size(191, 23);
            this.txtCondicionMatricula.TabIndex = 5;
            // 
            // rdnCedulaEstudiante
            // 
            this.rdnCedulaEstudiante.AutoSize = true;
            this.rdnCedulaEstudiante.Location = new System.Drawing.Point(140, 25);
            this.rdnCedulaEstudiante.Name = "rdnCedulaEstudiante";
            this.rdnCedulaEstudiante.Size = new System.Drawing.Size(120, 19);
            this.rdnCedulaEstudiante.TabIndex = 4;
            this.rdnCedulaEstudiante.TabStop = true;
            this.rdnCedulaEstudiante.Text = "Cédula Estudiante";
            this.rdnCedulaEstudiante.UseVisualStyleBackColor = true;
            // 
            // rdnCarnetEstudiante
            // 
            this.rdnCarnetEstudiante.AutoSize = true;
            this.rdnCarnetEstudiante.Location = new System.Drawing.Point(16, 25);
            this.rdnCarnetEstudiante.Name = "rdnCarnetEstudiante";
            this.rdnCarnetEstudiante.Size = new System.Drawing.Size(118, 19);
            this.rdnCarnetEstudiante.TabIndex = 4;
            this.rdnCarnetEstudiante.TabStop = true;
            this.rdnCarnetEstudiante.Text = "Carnet Estudiante";
            this.rdnCarnetEstudiante.UseVisualStyleBackColor = true;
            // 
            // btnSeleccionarMatricula
            // 
            this.btnSeleccionarMatricula.Location = new System.Drawing.Point(566, 566);
            this.btnSeleccionarMatricula.Name = "btnSeleccionarMatricula";
            this.btnSeleccionarMatricula.Size = new System.Drawing.Size(135, 34);
            this.btnSeleccionarMatricula.TabIndex = 12;
            this.btnSeleccionarMatricula.Text = "Seleccionar Matricula";
            this.btnSeleccionarMatricula.UseVisualStyleBackColor = true;
            this.btnSeleccionarMatricula.Click += new System.EventHandler(this.btnSeleccionarMatricula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione un Profesor";
            // 
            // dgvBuscarMatriculas
            // 
            this.dgvBuscarMatriculas.AllowUserToAddRows = false;
            this.dgvBuscarMatriculas.AllowUserToDeleteRows = false;
            this.dgvBuscarMatriculas.AllowUserToResizeColumns = false;
            this.dgvBuscarMatriculas.AllowUserToResizeRows = false;
            this.dgvBuscarMatriculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMatriculas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column7,
            this.Column5,
            this.Column6});
            this.dgvBuscarMatriculas.Location = new System.Drawing.Point(12, 104);
            this.dgvBuscarMatriculas.Name = "dgvBuscarMatriculas";
            this.dgvBuscarMatriculas.RowTemplate.Height = 25;
            this.dgvBuscarMatriculas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarMatriculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarMatriculas.Size = new System.Drawing.Size(845, 446);
            this.dgvBuscarMatriculas.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "NumFactura";
            this.Column1.HeaderText = "Num Factura";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CarnetEstudiante";
            this.Column2.HeaderText = "Carnet Estudiante";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "IdEstudiante";
            this.Column3.HeaderText = "Cedula Estudiante";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NombreEstudiante";
            this.Column4.HeaderText = "Nombre Estudiante";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "FechaMatricula";
            this.Column7.HeaderText = "Fecha Matricula";
            this.Column7.Name = "Column7";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MontoMatricula";
            this.Column5.HeaderText = "Monto Matricula";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TipoPago";
            this.Column6.HeaderText = "Tipo Pago";
            this.Column6.Name = "Column6";
            // 
            // FrmBuscarMatriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(877, 612);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionarMatricula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarMatriculas);
            this.Name = "FrmBuscarMatriculas";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Buscar Matriculas Pendientes";
            this.Load += new System.EventHandler(this.FrmBuscarMatriculas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMatriculas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarMatricula;
        private System.Windows.Forms.TextBox txtCondicionMatricula;
        private System.Windows.Forms.RadioButton rdnCedulaEstudiante;
        private System.Windows.Forms.RadioButton rdnCarnetEstudiante;
        private System.Windows.Forms.Button btnSeleccionarMatricula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarMatriculas;
        private System.Windows.Forms.RadioButton rdnNombreEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}