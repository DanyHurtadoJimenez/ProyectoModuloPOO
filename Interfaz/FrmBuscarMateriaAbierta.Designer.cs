
namespace Interfaz
{
    partial class FrmBuscarMateriaAbierta
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
            this.rdnNombreMateriaA = new System.Windows.Forms.RadioButton();
            this.btnBuscarMateriaAbierta = new System.Windows.Forms.Button();
            this.txtCondicionMateriaA = new System.Windows.Forms.TextBox();
            this.rdnCodMateriaA = new System.Windows.Forms.RadioButton();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBuscarMateriaA = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMateriaA)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(715, 589);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 34);
            this.btnCancelar.TabIndex = 24;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnNombreMateriaA);
            this.groupBox1.Controls.Add(this.btnBuscarMateriaAbierta);
            this.groupBox1.Controls.Add(this.txtCondicionMateriaA);
            this.groupBox1.Controls.Add(this.rdnCodMateriaA);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(891, 62);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por:";
            // 
            // rdnNombreMateriaA
            // 
            this.rdnNombreMateriaA.AutoSize = true;
            this.rdnNombreMateriaA.Location = new System.Drawing.Point(160, 25);
            this.rdnNombreMateriaA.Name = "rdnNombreMateriaA";
            this.rdnNombreMateriaA.Size = new System.Drawing.Size(112, 19);
            this.rdnNombreMateriaA.TabIndex = 7;
            this.rdnNombreMateriaA.TabStop = true;
            this.rdnNombreMateriaA.Text = "Nombre Materia";
            this.rdnNombreMateriaA.UseVisualStyleBackColor = true;
            this.rdnNombreMateriaA.CheckedChanged += new System.EventHandler(this.rdnNombreMateriaA_CheckedChanged);
            // 
            // btnBuscarMateriaAbierta
            // 
            this.btnBuscarMateriaAbierta.Enabled = false;
            this.btnBuscarMateriaAbierta.Location = new System.Drawing.Point(645, 24);
            this.btnBuscarMateriaAbierta.Name = "btnBuscarMateriaAbierta";
            this.btnBuscarMateriaAbierta.Size = new System.Drawing.Size(192, 23);
            this.btnBuscarMateriaAbierta.TabIndex = 6;
            this.btnBuscarMateriaAbierta.Text = "Buscar Materia Abierta";
            this.btnBuscarMateriaAbierta.UseVisualStyleBackColor = true;
            this.btnBuscarMateriaAbierta.Click += new System.EventHandler(this.btnBuscarMateriaAbierta_Click);
            // 
            // txtCondicionMateriaA
            // 
            this.txtCondicionMateriaA.Location = new System.Drawing.Point(293, 24);
            this.txtCondicionMateriaA.Name = "txtCondicionMateriaA";
            this.txtCondicionMateriaA.Size = new System.Drawing.Size(248, 23);
            this.txtCondicionMateriaA.TabIndex = 5;
            // 
            // rdnCodMateriaA
            // 
            this.rdnCodMateriaA.AutoSize = true;
            this.rdnCodMateriaA.Location = new System.Drawing.Point(6, 25);
            this.rdnCodMateriaA.Name = "rdnCodMateriaA";
            this.rdnCodMateriaA.Size = new System.Drawing.Size(107, 19);
            this.rdnCodMateriaA.TabIndex = 4;
            this.rdnCodMateriaA.TabStop = true;
            this.rdnCodMateriaA.Text = "Codigo Materia";
            this.rdnCodMateriaA.UseVisualStyleBackColor = true;
            this.rdnCodMateriaA.CheckedChanged += new System.EventHandler(this.rdnCodMateriaA_CheckedChanged);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(605, 589);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(92, 34);
            this.btnAgregarMateria.TabIndex = 22;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Seleccione la materia que desea matricular";
            // 
            // dgvBuscarMateriaA
            // 
            this.dgvBuscarMateriaA.AllowUserToAddRows = false;
            this.dgvBuscarMateriaA.AllowUserToDeleteRows = false;
            this.dgvBuscarMateriaA.AllowUserToResizeColumns = false;
            this.dgvBuscarMateriaA.AllowUserToResizeRows = false;
            this.dgvBuscarMateriaA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBuscarMateriaA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvBuscarMateriaA.Location = new System.Drawing.Point(12, 130);
            this.dgvBuscarMateriaA.Name = "dgvBuscarMateriaA";
            this.dgvBuscarMateriaA.RowTemplate.Height = 25;
            this.dgvBuscarMateriaA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarMateriaA.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBuscarMateriaA.Size = new System.Drawing.Size(1223, 446);
            this.dgvBuscarMateriaA.TabIndex = 20;
            this.dgvBuscarMateriaA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBuscarMateriaA_CellDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CodMateriaAbierta";
            this.Column1.HeaderText = "Cod MateriaA ";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "CodigoMateria";
            this.Column8.HeaderText = "Cod Materia";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "NombreMateria";
            this.Column2.HeaderText = "Nombre Materia";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "requisito";
            this.Column9.HeaderText = "Cod Requisito";
            this.Column9.Name = "Column9";
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "nombreRequisito";
            this.Column10.HeaderText = "Nombre Requisito";
            this.Column10.Name = "Column10";
            this.Column10.Width = 120;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "corequisito";
            this.Column11.HeaderText = "Cod Corequisito";
            this.Column11.Name = "Column11";
            this.Column11.Width = 80;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "nombreCoRequisito";
            this.Column12.HeaderText = "Nombre Corequisito";
            this.Column12.Name = "Column12";
            this.Column12.Width = 120;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "nombreProfesor";
            this.Column3.HeaderText = "Nombre Profesor";
            this.Column3.Name = "Column3";
            this.Column3.Width = 180;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "NumeroAula";
            this.Column4.HeaderText = "Numero Aula";
            this.Column4.Name = "Column4";
            this.Column4.Width = 80;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Grupo";
            this.Column5.HeaderText = "Grupo";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Cupo";
            this.Column6.HeaderText = "Cupo";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Costo";
            this.Column7.HeaderText = "Costo";
            this.Column7.Name = "Column7";
            // 
            // FrmBuscarMateriaAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 635);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarMateriaA);
            this.Name = "FrmBuscarMateriaAbierta";
            this.Text = "Buscar Materia A Matricular";
            this.Load += new System.EventHandler(this.FrmBuscarMateriaAbierta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMateriaA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnNombreMateriaA;
        private System.Windows.Forms.Button btnBuscarMateriaAbierta;
        private System.Windows.Forms.TextBox txtCondicionMateriaA;
        private System.Windows.Forms.RadioButton rdnCodMateriaA;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBuscarMateriaA;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}