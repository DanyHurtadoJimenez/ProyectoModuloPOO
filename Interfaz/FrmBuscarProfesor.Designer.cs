
namespace Interfaz
{
    partial class FrmBuscarProfesor
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
            this.btnBuscarProfe = new System.Windows.Forms.Button();
            this.txtCondicionProfesor = new System.Windows.Forms.TextBox();
            this.rdnNombreProfe = new System.Windows.Forms.RadioButton();
            this.rdnCodProfe = new System.Windows.Forms.RadioButton();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarProfesor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(675, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 34);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarProfe);
            this.groupBox1.Controls.Add(this.txtCondicionProfesor);
            this.groupBox1.Controls.Add(this.rdnNombreProfe);
            this.groupBox1.Controls.Add(this.rdnCodProfe);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 62);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // btnBuscarProfe
            // 
            this.btnBuscarProfe.Location = new System.Drawing.Point(518, 21);
            this.btnBuscarProfe.Name = "btnBuscarProfe";
            this.btnBuscarProfe.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarProfe.TabIndex = 6;
            this.btnBuscarProfe.Text = "Buscar Profesor";
            this.btnBuscarProfe.UseVisualStyleBackColor = true;
            this.btnBuscarProfe.Click += new System.EventHandler(this.btnBuscarProfe_Click);
            // 
            // txtCondicionProfesor
            // 
            this.txtCondicionProfesor.Enabled = false;
            this.txtCondicionProfesor.Location = new System.Drawing.Point(308, 21);
            this.txtCondicionProfesor.Name = "txtCondicionProfesor";
            this.txtCondicionProfesor.Size = new System.Drawing.Size(191, 23);
            this.txtCondicionProfesor.TabIndex = 5;
            this.txtCondicionProfesor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondicionProfesor_KeyPress);
            // 
            // rdnNombreProfe
            // 
            this.rdnNombreProfe.AutoSize = true;
            this.rdnNombreProfe.Location = new System.Drawing.Point(155, 25);
            this.rdnNombreProfe.Name = "rdnNombreProfe";
            this.rdnNombreProfe.Size = new System.Drawing.Size(116, 19);
            this.rdnNombreProfe.TabIndex = 4;
            this.rdnNombreProfe.TabStop = true;
            this.rdnNombreProfe.Text = "Nombre Profesor";
            this.rdnNombreProfe.UseVisualStyleBackColor = true;
            this.rdnNombreProfe.CheckedChanged += new System.EventHandler(this.rdnNombreProfe_CheckedChanged);
            // 
            // rdnCodProfe
            // 
            this.rdnCodProfe.AutoSize = true;
            this.rdnCodProfe.Location = new System.Drawing.Point(16, 25);
            this.rdnCodProfe.Name = "rdnCodProfe";
            this.rdnCodProfe.Size = new System.Drawing.Size(111, 19);
            this.rdnCodProfe.TabIndex = 4;
            this.rdnCodProfe.TabStop = true;
            this.rdnCodProfe.Text = "Código Profesor";
            this.rdnCodProfe.UseVisualStyleBackColor = true;
            this.rdnCodProfe.CheckedChanged += new System.EventHandler(this.rdnCodProfe_CheckedChanged);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(516, 587);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(135, 34);
            this.btnAgregarMateria.TabIndex = 7;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seleccione un Profesor";
            // 
            // dgvBuscarProfesor
            // 
            this.dgvBuscarProfesor.AllowUserToAddRows = false;
            this.dgvBuscarProfesor.AllowUserToDeleteRows = false;
            this.dgvBuscarProfesor.AllowUserToResizeColumns = false;
            this.dgvBuscarProfesor.AllowUserToResizeRows = false;
            this.dgvBuscarProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBuscarProfesor.Location = new System.Drawing.Point(12, 117);
            this.dgvBuscarProfesor.Name = "dgvBuscarProfesor";
            this.dgvBuscarProfesor.RowTemplate.Height = 25;
            this.dgvBuscarProfesor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarProfesor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarProfesor.Size = new System.Drawing.Size(794, 446);
            this.dgvBuscarProfesor.TabIndex = 5;
            this.dgvBuscarProfesor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarProfesor_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodigoProfesor";
            this.Column1.HeaderText = "CodProfesor";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idProfesor";
            this.Column2.HeaderText = "ID Profesor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nombreProfesor";
            this.Column3.HeaderText = "Nombre";
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "apellido1profesor";
            this.Column4.HeaderText = "Apellido 1";
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "apellido2profesor";
            this.Column5.HeaderText = "Apellido 2";
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "telefonoProfesor";
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(822, 633);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarProfesor);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarProfesor";
            this.Text = "Buscar Profesor";
            this.Load += new System.EventHandler(this.FrmBuscarProfesor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarProfe;
        private System.Windows.Forms.TextBox txtCondicionProfesor;
        private System.Windows.Forms.RadioButton rdnNombreProfe;
        private System.Windows.Forms.RadioButton rdnCodProfe;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}