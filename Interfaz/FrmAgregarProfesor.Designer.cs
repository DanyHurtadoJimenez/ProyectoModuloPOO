
namespace Interfaz
{
    partial class FrmAgregarProfesor
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
            this.dgtvSeleccionarProfesor = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgtvSeleccionarProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione un profesor";
            // 
            // dgtvSeleccionarProfesor
            // 
            this.dgtvSeleccionarProfesor.AllowUserToAddRows = false;
            this.dgtvSeleccionarProfesor.AllowUserToDeleteRows = false;
            this.dgtvSeleccionarProfesor.AllowUserToResizeColumns = false;
            this.dgtvSeleccionarProfesor.AllowUserToResizeRows = false;
            this.dgtvSeleccionarProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtvSeleccionarProfesor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgtvSeleccionarProfesor.Location = new System.Drawing.Point(12, 57);
            this.dgtvSeleccionarProfesor.Name = "dgtvSeleccionarProfesor";
            this.dgtvSeleccionarProfesor.RowTemplate.Height = 25;
            this.dgtvSeleccionarProfesor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgtvSeleccionarProfesor.Size = new System.Drawing.Size(884, 221);
            this.dgtvSeleccionarProfesor.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Código Profesor";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Id Profesor";
            this.Column2.Name = "Column2";
            this.Column2.Width = 126;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Nombre Profesor";
            this.Column3.Name = "Column3";
            this.Column3.Width = 126;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Primer Apellido ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 126;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Segundo Apellido";
            this.Column5.Name = "Column5";
            this.Column5.Width = 126;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Teléfono";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Correo Electrónico";
            this.Column7.Name = "Column7";
            this.Column7.Width = 130;
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(407, 300);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarProfesor.TabIndex = 2;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            // 
            // FrmAgregarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(908, 336);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.dgtvSeleccionarProfesor);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FrmAgregarProfesor";
            this.Text = "Agregar Profesor";
            this.Load += new System.EventHandler(this.FrmAgregarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtvSeleccionarProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgtvSeleccionarProfesor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Button btnAgregarProfesor;
    }
}