
namespace Interfaz
{
    partial class BuscarMateria
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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMateria)).BeginInit();
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
            this.Column2});
            this.dgvBuscarMateria.Location = new System.Drawing.Point(12, 51);
            this.dgvBuscarMateria.Name = "dgvBuscarMateria";
            this.dgvBuscarMateria.RowTemplate.Height = 25;
            this.dgvBuscarMateria.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvBuscarMateria.Size = new System.Drawing.Size(395, 291);
            this.dgvBuscarMateria.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre de la Materia";
            this.Column2.Name = "Column2";
            this.Column2.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccione Una Materia";
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(167, 362);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(100, 34);
            this.btnAgregarMateria.TabIndex = 2;
            this.btnAgregarMateria.Text = "Agregar";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            // 
            // BuscarMateria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(421, 408);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBuscarMateria);
            this.MaximizeBox = false;
            this.Name = "BuscarMateria";
            this.Text = "Buscar Materia";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBuscarMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBuscarMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarMateria;
    }
}