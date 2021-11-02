
namespace Interfaz
{
    partial class FrmMostrarHorarios
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvVerHorarios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerHorarios)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(210, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvVerHorarios
            // 
            this.dgvVerHorarios.AllowUserToAddRows = false;
            this.dgvVerHorarios.AllowUserToDeleteRows = false;
            this.dgvVerHorarios.AllowUserToResizeColumns = false;
            this.dgvVerHorarios.AllowUserToResizeRows = false;
            this.dgvVerHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVerHorarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvVerHorarios.Location = new System.Drawing.Point(12, 12);
            this.dgvVerHorarios.Name = "dgvVerHorarios";
            this.dgvVerHorarios.RowTemplate.Height = 25;
            this.dgvVerHorarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvVerHorarios.Size = new System.Drawing.Size(273, 227);
            this.dgvVerHorarios.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "dia";
            this.Column1.HeaderText = "Día";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "HoraInicio";
            this.Column2.HeaderText = "Hora de Inicio";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "HoraFin";
            this.Column3.HeaderText = "Hora de Fin";
            this.Column3.Name = "Column3";
            // 
            // FrmMostrarHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(296, 276);
            this.ControlBox = false;
            this.Controls.Add(this.dgvVerHorarios);
            this.Controls.Add(this.btnSalir);
            this.Name = "FrmMostrarHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mostrar Horarios";
            this.Load += new System.EventHandler(this.FrmMostrarHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVerHorarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvVerHorarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}