
namespace Interfaz
{
    partial class FrmBuscarEstudiante
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnCedulaEstudiante = new System.Windows.Forms.RadioButton();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.txtCondicionEstudiante = new System.Windows.Forms.TextBox();
            this.rdnNombreEstudiante = new System.Windows.Forms.RadioButton();
            this.rdnCodEstudiante = new System.Windows.Forms.RadioButton();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarEstudiante = new System.Windows.Forms.DataGridView();
            this.carnetEstudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idestudiante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEstudiante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(1021, 574);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 34);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnCedulaEstudiante);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox1.Controls.Add(this.txtCondicionEstudiante);
            this.groupBox1.Controls.Add(this.rdnNombreEstudiante);
            this.groupBox1.Controls.Add(this.rdnCodEstudiante);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1144, 62);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // rdnCedulaEstudiante
            // 
            this.rdnCedulaEstudiante.AutoSize = true;
            this.rdnCedulaEstudiante.Location = new System.Drawing.Point(141, 25);
            this.rdnCedulaEstudiante.Name = "rdnCedulaEstudiante";
            this.rdnCedulaEstudiante.Size = new System.Drawing.Size(120, 19);
            this.rdnCedulaEstudiante.TabIndex = 7;
            this.rdnCedulaEstudiante.TabStop = true;
            this.rdnCedulaEstudiante.Text = "Cédula Estudiante";
            this.rdnCedulaEstudiante.UseVisualStyleBackColor = true;
            this.rdnCedulaEstudiante.CheckedChanged += new System.EventHandler(this.rdnCedulaEstudiante_CheckedChanged);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.Enabled = false;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(814, 24);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(304, 23);
            this.btnBuscarEstudiante.TabIndex = 6;
            this.btnBuscarEstudiante.Text = "Buscar Estudiante";
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // txtCondicionEstudiante
            // 
            this.txtCondicionEstudiante.Enabled = false;
            this.txtCondicionEstudiante.Location = new System.Drawing.Point(433, 24);
            this.txtCondicionEstudiante.Name = "txtCondicionEstudiante";
            this.txtCondicionEstudiante.Size = new System.Drawing.Size(329, 23);
            this.txtCondicionEstudiante.TabIndex = 5;
            this.txtCondicionEstudiante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondicionEstudiante_KeyPress);
            // 
            // rdnNombreEstudiante
            // 
            this.rdnNombreEstudiante.AutoSize = true;
            this.rdnNombreEstudiante.Location = new System.Drawing.Point(279, 25);
            this.rdnNombreEstudiante.Name = "rdnNombreEstudiante";
            this.rdnNombreEstudiante.Size = new System.Drawing.Size(127, 19);
            this.rdnNombreEstudiante.TabIndex = 4;
            this.rdnNombreEstudiante.TabStop = true;
            this.rdnNombreEstudiante.Text = "Nombre Estudiante";
            this.rdnNombreEstudiante.UseVisualStyleBackColor = true;
            this.rdnNombreEstudiante.CheckedChanged += new System.EventHandler(this.rdnNombreEstudiante_CheckedChanged);
            // 
            // rdnCodEstudiante
            // 
            this.rdnCodEstudiante.AutoSize = true;
            this.rdnCodEstudiante.Location = new System.Drawing.Point(6, 25);
            this.rdnCodEstudiante.Name = "rdnCodEstudiante";
            this.rdnCodEstudiante.Size = new System.Drawing.Size(118, 19);
            this.rdnCodEstudiante.TabIndex = 4;
            this.rdnCodEstudiante.TabStop = true;
            this.rdnCodEstudiante.Text = "Carnet Estudiante";
            this.rdnCodEstudiante.UseVisualStyleBackColor = true;
            this.rdnCodEstudiante.CheckedChanged += new System.EventHandler(this.rdnCodEstudiante_CheckedChanged);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(871, 574);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(135, 34);
            this.btnAgregarMateria.TabIndex = 17;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 15);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione un Estudiante";
            // 
            // dgvBuscarEstudiante
            // 
            this.dgvBuscarEstudiante.AllowUserToAddRows = false;
            this.dgvBuscarEstudiante.AllowUserToDeleteRows = false;
            this.dgvBuscarEstudiante.AllowUserToResizeColumns = false;
            this.dgvBuscarEstudiante.AllowUserToResizeRows = false;
            this.dgvBuscarEstudiante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarEstudiante.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.carnetEstudiante,
            this.idestudiante,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvBuscarEstudiante.Location = new System.Drawing.Point(12, 122);
            this.dgvBuscarEstudiante.Name = "dgvBuscarEstudiante";
            this.dgvBuscarEstudiante.RowTemplate.Height = 25;
            this.dgvBuscarEstudiante.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarEstudiante.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarEstudiante.Size = new System.Drawing.Size(1144, 446);
            this.dgvBuscarEstudiante.TabIndex = 15;
            this.dgvBuscarEstudiante.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarEstudiante_CellDoubleClick);
            // 
            // carnetEstudiante
            // 
            this.carnetEstudiante.DataPropertyName = "carnetEstudiante";
            this.carnetEstudiante.HeaderText = "No. Carnet";
            this.carnetEstudiante.Name = "carnetEstudiante";
            // 
            // idestudiante
            // 
            this.idestudiante.DataPropertyName = "idestudiante";
            this.idestudiante.HeaderText = "Cédula";
            this.idestudiante.Name = "idestudiante";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nombreEstudiante";
            this.Column3.HeaderText = "Nombre ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "apellido1estudiante";
            this.Column4.HeaderText = "Apellido 1";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "apellido2estudiante";
            this.Column5.HeaderText = "Apellido 2";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "telefonoestudiante";
            this.Column6.HeaderText = "Telefono";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "correoEstudiante";
            this.Column7.HeaderText = "Correo Estudiante";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "provinciaestudiante";
            this.Column8.HeaderText = "Provincia";
            this.Column8.Name = "Column8";
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "otrassenias";
            this.Column11.HeaderText = "Otras Senias";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "FechaIngresso";
            this.Column12.HeaderText = "Fecha Ingreso";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "descuento";
            this.Column13.HeaderText = "Descuento";
            this.Column13.Name = "Column13";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 615);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarEstudiante);
            this.Name = "FrmBuscarEstudiante";
            this.Text = "Buscar Estudiante";
            this.Load += new System.EventHandler(this.FrmBuscarEstudiante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarEstudiante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnCedulaEstudiante;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.TextBox txtCondicionEstudiante;
        private System.Windows.Forms.RadioButton rdnNombreEstudiante;
        private System.Windows.Forms.RadioButton rdnCodEstudiante;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn carnetEstudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn idestudiante;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}