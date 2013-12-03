namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelacionMedicoWindow
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
            this.label4 = new System.Windows.Forms.Label();
            this.rdbUnica = new System.Windows.Forms.RadioButton();
            this.rdbRango = new System.Windows.Forms.RadioButton();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblFechaFinal = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.txtNroMedico = new System.Windows.Forms.NumericTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "Nro Médico";
            // 
            // rdbUnica
            // 
            this.rdbUnica.AutoSize = true;
            this.rdbUnica.Checked = true;
            this.rdbUnica.Location = new System.Drawing.Point(14, 40);
            this.rdbUnica.Name = "rdbUnica";
            this.rdbUnica.Size = new System.Drawing.Size(101, 17);
            this.rdbUnica.TabIndex = 68;
            this.rdbUnica.TabStop = true;
            this.rdbUnica.Text = "Cancelar un día";
            this.rdbUnica.UseVisualStyleBackColor = true;
            this.rdbUnica.CheckedChanged += new System.EventHandler(this.rdbUnica_CheckedChanged);
            // 
            // rdbRango
            // 
            this.rdbRango.AutoSize = true;
            this.rdbRango.Location = new System.Drawing.Point(15, 64);
            this.rdbRango.Name = "rdbRango";
            this.rdbRango.Size = new System.Drawing.Size(107, 17);
            this.rdbRango.TabIndex = 69;
            this.rdbRango.Text = "Cancelar período";
            this.rdbRango.UseVisualStyleBackColor = true;
            this.rdbRango.CheckedChanged += new System.EventHandler(this.rdbRango_CheckedChanged);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(7, 97);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 71;
            this.lblFecha.Text = "Fecha";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(80, 93);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(131, 20);
            this.dtpFecha.TabIndex = 70;
            this.dtpFecha.Value = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // lblFechaFinal
            // 
            this.lblFechaFinal.AutoSize = true;
            this.lblFechaFinal.Location = new System.Drawing.Point(7, 127);
            this.lblFechaFinal.Name = "lblFechaFinal";
            this.lblFechaFinal.Size = new System.Drawing.Size(62, 13);
            this.lblFechaFinal.TabIndex = 73;
            this.lblFechaFinal.Text = "Fecha Final";
            this.lblFechaFinal.Visible = false;
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(80, 123);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(131, 20);
            this.dtpFechaFinal.TabIndex = 72;
            this.dtpFechaFinal.Value = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtpFechaFinal.Visible = false;
            // 
            // txtNroMedico
            // 
            this.txtNroMedico.AllowSpace = false;
            this.txtNroMedico.Location = new System.Drawing.Point(95, 6);
            this.txtNroMedico.Name = "txtNroMedico";
            this.txtNroMedico.Size = new System.Drawing.Size(116, 20);
            this.txtNroMedico.TabIndex = 67;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(44, 153);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(135, 24);
            this.btnCancelar.TabIndex = 74;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // CancelacionMedicoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(224, 183);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblFechaFinal);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.rdbRango);
            this.Controls.Add(this.rdbUnica);
            this.Controls.Add(this.txtNroMedico);
            this.Controls.Add(this.label4);
            this.Name = "CancelacionMedicoWindow";
            this.Text = "CancelacionMedicoWindow";
            this.Load += new System.EventHandler(this.CancelacionMedicoWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericTextBox txtNroMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdbUnica;
        private System.Windows.Forms.RadioButton rdbRango;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label lblFechaFinal;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.Button btnCancelar;
    }
}