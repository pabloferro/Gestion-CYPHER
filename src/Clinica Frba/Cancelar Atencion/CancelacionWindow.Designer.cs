namespace Clinica_Frba.Cancelar_Atencion
{
    partial class CancelacionWindow
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
            this.btnPaciente = new System.Windows.Forms.Button();
            this.btnMedico = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPaciente
            // 
            this.btnPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaciente.Location = new System.Drawing.Point(12, 12);
            this.btnPaciente.Name = "btnPaciente";
            this.btnPaciente.Size = new System.Drawing.Size(204, 35);
            this.btnPaciente.TabIndex = 0;
            this.btnPaciente.Text = "Por Paciente";
            this.btnPaciente.UseVisualStyleBackColor = true;
            this.btnPaciente.Click += new System.EventHandler(this.btnPaciente_Click);
            // 
            // btnMedico
            // 
            this.btnMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMedico.Location = new System.Drawing.Point(13, 65);
            this.btnMedico.Name = "btnMedico";
            this.btnMedico.Size = new System.Drawing.Size(204, 35);
            this.btnMedico.TabIndex = 1;
            this.btnMedico.Text = "Por Médico";
            this.btnMedico.UseVisualStyleBackColor = true;
            this.btnMedico.Click += new System.EventHandler(this.btnMedico_Click);
            // 
            // CancelacionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 118);
            this.Controls.Add(this.btnMedico);
            this.Controls.Add(this.btnPaciente);
            this.Name = "CancelacionWindow";
            this.Text = "Cancelar Atención Médica";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPaciente;
        private System.Windows.Forms.Button btnMedico;
    }
}