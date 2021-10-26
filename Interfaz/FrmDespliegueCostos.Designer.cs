
namespace Interfaz
{
    partial class FrmDespliegueCostos
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.dtgvVistaCostos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNumFactura = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCarnetEstudiante = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombreEstudiante = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpFechaMatricula = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.btnCalcularCostos = new System.Windows.Forms.Button();
            this.comboTipoPago = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVistaCostos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Enabled = false;
            this.btnPagar.Location = new System.Drawing.Point(343, 509);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(170, 24);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar Matrícula";
            this.btnPagar.UseVisualStyleBackColor = true;
            // 
            // dtgvVistaCostos
            // 
            this.dtgvVistaCostos.AllowUserToAddRows = false;
            this.dtgvVistaCostos.AllowUserToDeleteRows = false;
            this.dtgvVistaCostos.AllowUserToResizeColumns = false;
            this.dtgvVistaCostos.AllowUserToResizeRows = false;
            this.dtgvVistaCostos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvVistaCostos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvVistaCostos.Location = new System.Drawing.Point(32, 176);
            this.dtgvVistaCostos.Name = "dtgvVistaCostos";
            this.dtgvVistaCostos.RowTemplate.Height = 25;
            this.dtgvVistaCostos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dtgvVistaCostos.Size = new System.Drawing.Size(481, 265);
            this.dtgvVistaCostos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cálculo de Costos";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cod Materia Abieta";
            this.Column1.Name = "Column1";
            this.Column1.Width = 140;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Materia Abierta";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Costo";
            this.Column3.Name = "Column3";
            this.Column3.Width = 140;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número de Factura:";
            // 
            // txtNumFactura
            // 
            this.txtNumFactura.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumFactura.Enabled = false;
            this.txtNumFactura.Location = new System.Drawing.Point(147, 58);
            this.txtNumFactura.Name = "txtNumFactura";
            this.txtNumFactura.ReadOnly = true;
            this.txtNumFactura.Size = new System.Drawing.Size(100, 23);
            this.txtNumFactura.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Carnet Estudiante:";
            // 
            // txtCarnetEstudiante
            // 
            this.txtCarnetEstudiante.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCarnetEstudiante.Enabled = false;
            this.txtCarnetEstudiante.Location = new System.Drawing.Point(362, 58);
            this.txtCarnetEstudiante.Name = "txtCarnetEstudiante";
            this.txtCarnetEstudiante.ReadOnly = true;
            this.txtCarnetEstudiante.Size = new System.Drawing.Size(151, 23);
            this.txtCarnetEstudiante.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Nombre Estudiante:";
            // 
            // txtNombreEstudiante
            // 
            this.txtNombreEstudiante.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNombreEstudiante.Enabled = false;
            this.txtNombreEstudiante.Location = new System.Drawing.Point(147, 97);
            this.txtNombreEstudiante.Name = "txtNombreEstudiante";
            this.txtNombreEstudiante.ReadOnly = true;
            this.txtNombreEstudiante.Size = new System.Drawing.Size(366, 23);
            this.txtNombreEstudiante.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fecha Matricula: ";
            // 
            // dtpFechaMatricula
            // 
            this.dtpFechaMatricula.Enabled = false;
            this.dtpFechaMatricula.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaMatricula.Location = new System.Drawing.Point(434, 22);
            this.dtpFechaMatricula.Name = "dtpFechaMatricula";
            this.dtpFechaMatricula.Size = new System.Drawing.Size(79, 23);
            this.dtpFechaMatricula.TabIndex = 10;
            this.dtpFechaMatricula.Value = new System.DateTime(2021, 10, 24, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Materias a Matricular:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total a Pagar: ";
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Location = new System.Drawing.Point(253, 463);
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.ReadOnly = true;
            this.txtTotalPagar.Size = new System.Drawing.Size(260, 23);
            this.txtTotalPagar.TabIndex = 13;
            // 
            // btnCalcularCostos
            // 
            this.btnCalcularCostos.Location = new System.Drawing.Point(32, 457);
            this.btnCalcularCostos.Name = "btnCalcularCostos";
            this.btnCalcularCostos.Size = new System.Drawing.Size(115, 29);
            this.btnCalcularCostos.TabIndex = 14;
            this.btnCalcularCostos.Text = "Calcular Costos";
            this.btnCalcularCostos.UseVisualStyleBackColor = true;
            // 
            // comboTipoPago
            // 
            this.comboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPago.FormattingEnabled = true;
            this.comboTipoPago.Location = new System.Drawing.Point(167, 510);
            this.comboTipoPago.Name = "comboTipoPago";
            this.comboTipoPago.Size = new System.Drawing.Size(121, 23);
            this.comboTipoPago.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(32, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Escojer Tipo Pago:";
            // 
            // FrmDespliegueCostos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(538, 545);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboTipoPago);
            this.Controls.Add(this.btnCalcularCostos);
            this.Controls.Add(this.txtTotalPagar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpFechaMatricula);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNombreEstudiante);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCarnetEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumFactura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgvVistaCostos);
            this.Controls.Add(this.btnPagar);
            this.MaximizeBox = false;
            this.Name = "FrmDespliegueCostos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despliegue Costos";
            ((System.ComponentModel.ISupportInitialize)(this.dtgvVistaCostos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.DataGridView dtgvVistaCostos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNumFactura;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCarnetEstudiante;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombreEstudiante;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpFechaMatricula;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.Button btnCalcularCostos;
        private System.Windows.Forms.ComboBox comboTipoPago;
        private System.Windows.Forms.Label label8;
    }
}