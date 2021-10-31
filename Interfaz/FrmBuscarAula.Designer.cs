
namespace Interfaz
{
    partial class FrmBuscarAula
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
            this.btnBuscarAula = new System.Windows.Forms.Button();
            this.txtCondicionAula = new System.Windows.Forms.TextBox();
            this.rdnTipoAula = new System.Windows.Forms.RadioButton();
            this.rdnCodAula = new System.Windows.Forms.RadioButton();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarAula = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarAula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(370, 585);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 34);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarAula);
            this.groupBox1.Controls.Add(this.txtCondicionAula);
            this.groupBox1.Controls.Add(this.rdnTipoAula);
            this.groupBox1.Controls.Add(this.rdnCodAula);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(493, 62);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // btnBuscarAula
            // 
            this.btnBuscarAula.Location = new System.Drawing.Point(366, 24);
            this.btnBuscarAula.Name = "btnBuscarAula";
            this.btnBuscarAula.Size = new System.Drawing.Size(121, 23);
            this.btnBuscarAula.TabIndex = 6;
            this.btnBuscarAula.Text = "Buscar Aula";
            this.btnBuscarAula.UseVisualStyleBackColor = true;
            this.btnBuscarAula.Click += new System.EventHandler(this.btnBuscarAula_Click);
            // 
            // txtCondicionAula
            // 
            this.txtCondicionAula.Enabled = false;
            this.txtCondicionAula.Location = new System.Drawing.Point(193, 24);
            this.txtCondicionAula.Name = "txtCondicionAula";
            this.txtCondicionAula.Size = new System.Drawing.Size(146, 23);
            this.txtCondicionAula.TabIndex = 5;
            this.txtCondicionAula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCondicionAula_KeyPress);
            // 
            // rdnTipoAula
            // 
            this.rdnTipoAula.AutoSize = true;
            this.rdnTipoAula.Location = new System.Drawing.Point(103, 25);
            this.rdnTipoAula.Name = "rdnTipoAula";
            this.rdnTipoAula.Size = new System.Drawing.Size(75, 19);
            this.rdnTipoAula.TabIndex = 4;
            this.rdnTipoAula.TabStop = true;
            this.rdnTipoAula.Text = "Tipo Aula";
            this.rdnTipoAula.UseVisualStyleBackColor = true;
            this.rdnTipoAula.CheckedChanged += new System.EventHandler(this.rdnTipoAula_CheckedChanged);
            // 
            // rdnCodAula
            // 
            this.rdnCodAula.AutoSize = true;
            this.rdnCodAula.Location = new System.Drawing.Point(6, 25);
            this.rdnCodAula.Name = "rdnCodAula";
            this.rdnCodAula.Size = new System.Drawing.Size(91, 19);
            this.rdnCodAula.TabIndex = 4;
            this.rdnCodAula.TabStop = true;
            this.rdnCodAula.Text = "Código Aula";
            this.rdnCodAula.UseVisualStyleBackColor = true;
            this.rdnCodAula.CheckedChanged += new System.EventHandler(this.rdnCodAula_CheckedChanged);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(216, 585);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(135, 34);
            this.btnAgregarMateria.TabIndex = 12;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Seleccione un aula";
            // 
            // dgvBuscarAula
            // 
            this.dgvBuscarAula.AllowUserToAddRows = false;
            this.dgvBuscarAula.AllowUserToDeleteRows = false;
            this.dgvBuscarAula.AllowUserToResizeColumns = false;
            this.dgvBuscarAula.AllowUserToResizeRows = false;
            this.dgvBuscarAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarAula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvBuscarAula.Location = new System.Drawing.Point(12, 117);
            this.dgvBuscarAula.Name = "dgvBuscarAula";
            this.dgvBuscarAula.RowTemplate.Height = 25;
            this.dgvBuscarAula.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarAula.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarAula.Size = new System.Drawing.Size(493, 446);
            this.dgvBuscarAula.TabIndex = 10;
            this.dgvBuscarAula.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarAula_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "codigoAula";
            this.Column1.HeaderText = "Codigo Aula";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "tipoAula";
            this.Column2.HeaderText = "Tipo Aula";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "numeroAula";
            this.Column3.HeaderText = "Número Aula";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "capacidad";
            this.Column4.HeaderText = "Capacidad";
            this.Column4.Name = "Column4";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmBuscarAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 631);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarAula);
            this.Name = "FrmBuscarAula";
            this.Text = "Buscar Aula";
            this.Load += new System.EventHandler(this.FrmBuscarAula_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarAula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarAula;
        private System.Windows.Forms.TextBox txtCondicionAula;
        private System.Windows.Forms.RadioButton rdnTipoAula;
        private System.Windows.Forms.RadioButton rdnCodAula;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}