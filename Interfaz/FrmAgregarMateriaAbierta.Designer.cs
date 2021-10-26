
namespace Interfaz
{
    partial class FrmAgregarMateriaAbierta
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
            this.dtgvEscogerMateriaAbierta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarMateriaAbierta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEscogerMateriaAbierta)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgvEscogerMateriaAbierta
            // 
            this.dtgvEscogerMateriaAbierta.AllowUserToAddRows = false;
            this.dtgvEscogerMateriaAbierta.AllowUserToDeleteRows = false;
            this.dtgvEscogerMateriaAbierta.AllowUserToResizeColumns = false;
            this.dtgvEscogerMateriaAbierta.AllowUserToResizeRows = false;
            this.dtgvEscogerMateriaAbierta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvEscogerMateriaAbierta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dtgvEscogerMateriaAbierta.Location = new System.Drawing.Point(12, 62);
            this.dtgvEscogerMateriaAbierta.Name = "dtgvEscogerMateriaAbierta";
            this.dtgvEscogerMateriaAbierta.RowTemplate.Height = 25;
            this.dtgvEscogerMateriaAbierta.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvEscogerMateriaAbierta.Size = new System.Drawing.Size(1063, 266);
            this.dtgvEscogerMateriaAbierta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(466, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione una Materia Abierta";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod Materia Abierta";
            this.Column1.Name = "Column1";
            this.Column1.Width = 80;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Materia";
            this.Column2.Name = "Column2";
            this.Column2.Width = 130;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Carrera";
            this.Column3.Name = "Column3";
            this.Column3.Width = 130;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Nombre Profesor";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Codigo Aula";
            this.Column5.Name = "Column5";
            this.Column5.Width = 80;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Grupo";
            this.Column6.Name = "Column6";
            this.Column6.Width = 80;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Cupo";
            this.Column7.Name = "Column7";
            this.Column7.Width = 80;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Costo";
            this.Column8.Name = "Column8";
            this.Column8.Width = 80;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Periodo";
            this.Column9.Name = "Column9";
            this.Column9.Width = 80;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Año";
            this.Column10.Name = "Column10";
            this.Column10.Width = 80;
            // 
            // btnAgregarMateriaAbierta
            // 
            this.btnAgregarMateriaAbierta.Location = new System.Drawing.Point(476, 346);
            this.btnAgregarMateriaAbierta.Name = "btnAgregarMateriaAbierta";
            this.btnAgregarMateriaAbierta.Size = new System.Drawing.Size(146, 30);
            this.btnAgregarMateriaAbierta.TabIndex = 2;
            this.btnAgregarMateriaAbierta.Text = "Agregar Materia Abierta";
            this.btnAgregarMateriaAbierta.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarMateriaAbierta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1087, 384);
            this.Controls.Add(this.btnAgregarMateriaAbierta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvEscogerMateriaAbierta);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarMateriaAbierta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Materia Abierta";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvEscogerMateriaAbierta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvEscogerMateriaAbierta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMateriaAbierta;
    }
}