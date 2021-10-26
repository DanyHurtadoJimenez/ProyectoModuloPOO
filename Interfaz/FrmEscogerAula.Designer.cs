
namespace Interfaz
{
    partial class FrmEscogerAula
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgvSeleccionarAula = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSeleccionarAula)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un aula";
            // 
            // dtgvSeleccionarAula
            // 
            this.dtgvSeleccionarAula.AllowUserToAddRows = false;
            this.dtgvSeleccionarAula.AllowUserToDeleteRows = false;
            this.dtgvSeleccionarAula.AllowUserToResizeColumns = false;
            this.dtgvSeleccionarAula.AllowUserToResizeRows = false;
            this.dtgvSeleccionarAula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvSeleccionarAula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvSeleccionarAula.Location = new System.Drawing.Point(12, 54);
            this.dtgvSeleccionarAula.Name = "dtgvSeleccionarAula";
            this.dtgvSeleccionarAula.RowTemplate.Height = 25;
            this.dtgvSeleccionarAula.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvSeleccionarAula.Size = new System.Drawing.Size(524, 250);
            this.dtgvSeleccionarAula.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código Aula";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tipo Aula";
            this.Column2.Name = "Column2";
            this.Column2.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Número Aula";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Capacidad";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Agregar Aula";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // EscogerAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(550, 360);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtgvSeleccionarAula);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "EscogerAula";
            this.Text = "Escoger Aula";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvSeleccionarAula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgvSeleccionarAula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button button1;
    }
}