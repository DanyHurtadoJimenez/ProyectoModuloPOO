
namespace Interfaz
{
    partial class FrmBuscarMateria
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
            this.dgvBuscarMateria = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.rdnCodMateria = new System.Windows.Forms.RadioButton();
            this.rdnNombreMateria = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarMateria = new System.Windows.Forms.Button();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMateria)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBuscarMateria
            // 
            this.dgvBuscarMateria.AllowUserToAddRows = false;
            this.dgvBuscarMateria.AllowUserToDeleteRows = false;
            this.dgvBuscarMateria.AllowUserToResizeColumns = false;
            this.dgvBuscarMateria.AllowUserToResizeRows = false;
            this.dgvBuscarMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMateria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvBuscarMateria.Location = new System.Drawing.Point(12, 116);
            this.dgvBuscarMateria.Name = "dgvBuscarMateria";
            this.dgvBuscarMateria.RowTemplate.Height = 25;
            this.dgvBuscarMateria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarMateria.Size = new System.Drawing.Size(655, 446);
            this.dgvBuscarMateria.TabIndex = 0;
            this.dgvBuscarMateria.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarMateria_CellContentClick);
            this.dgvBuscarMateria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarMateria_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Una Materia";
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(377, 581);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(135, 34);
            this.btnAgregarMateria.TabIndex = 2;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // rdnCodMateria
            // 
            this.rdnCodMateria.AutoSize = true;
            this.rdnCodMateria.Location = new System.Drawing.Point(20, 22);
            this.rdnCodMateria.Name = "rdnCodMateria";
            this.rdnCodMateria.Size = new System.Drawing.Size(148, 19);
            this.rdnCodMateria.TabIndex = 4;
            this.rdnCodMateria.TabStop = true;
            this.rdnCodMateria.Text = "Codigo Materia Carrera";
            this.rdnCodMateria.UseVisualStyleBackColor = true;
            // 
            // rdnNombreMateria
            // 
            this.rdnNombreMateria.AutoSize = true;
            this.rdnNombreMateria.Location = new System.Drawing.Point(181, 21);
            this.rdnNombreMateria.Name = "rdnNombreMateria";
            this.rdnNombreMateria.Size = new System.Drawing.Size(112, 19);
            this.rdnNombreMateria.TabIndex = 4;
            this.rdnNombreMateria.TabStop = true;
            this.rdnNombreMateria.Text = "Nombre Materia";
            this.rdnNombreMateria.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarMateria);
            this.groupBox1.Controls.Add(this.txtCondicion);
            this.groupBox1.Controls.Add(this.rdnNombreMateria);
            this.groupBox1.Controls.Add(this.rdnCodMateria);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(655, 62);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // btnBuscarMateria
            // 
            this.btnBuscarMateria.Location = new System.Drawing.Point(518, 21);
            this.btnBuscarMateria.Name = "btnBuscarMateria";
            this.btnBuscarMateria.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarMateria.TabIndex = 6;
            this.btnBuscarMateria.Text = "Buscar Materia";
            this.btnBuscarMateria.UseVisualStyleBackColor = true;
            this.btnBuscarMateria.Click += new System.EventHandler(this.btnBuscarMateria_Click);
            // 
            // txtCondicion
            // 
            this.txtCondicion.Location = new System.Drawing.Point(308, 21);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(191, 23);
            this.txtCondicion.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(531, 581);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 34);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodMateriaCarrera";
            this.Column1.HeaderText = "CodMateriaCarrera";
            this.Column1.Name = "Column1";
            this.Column1.Width = 110;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CodigoMateria";
            this.Column2.HeaderText = "Codigo Materia";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "NombreMateria";
            this.Column3.HeaderText = "Nombre Materia";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "CreditosMateria";
            this.Column4.HeaderText = "Creditos";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "NombreCarrera";
            this.Column5.HeaderText = "Carrera";
            this.Column5.Name = "Column5";
            this.Column5.Width = 120;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "CodigoCarrera";
            this.Column6.HeaderText = "Codigo Carrera";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // FrmBuscarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(680, 627);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarMateria);
            this.MaximizeBox = false;
            this.Name = "FrmBuscarMateria";
            this.Text = "Buscar Materia";
            this.Load += new System.EventHandler(this.FrmBuscarMateria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMateria)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.RadioButton rdnCodMateria;
        private System.Windows.Forms.RadioButton rdnNombreMateria;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarMateria;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}