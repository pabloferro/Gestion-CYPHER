namespace Clinica_Frba.Registro_Resultado_Atencion
{
    partial class RegistroAtencionWindow
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
            this.button_Si = new System.Windows.Forms.Button();
            this.button_No = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label_CodigoTurno = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.comboBox_Sintomas = new System.Windows.Forms.ComboBox();
            this.button_Sintomas = new System.Windows.Forms.Button();
            this.comboBox_Enfermedades = new System.Windows.Forms.ComboBox();
            this.button_Enfermedades = new System.Windows.Forms.Button();
            this.label_Sintomas = new System.Windows.Forms.Label();
            this.label_Enfermedades = new System.Windows.Forms.Label();
            this.button_Aceptar = new System.Windows.Forms.Button();
            this.button_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Si
            // 
            this.button_Si.Location = new System.Drawing.Point(63, 155);
            this.button_Si.Name = "button_Si";
            this.button_Si.Size = new System.Drawing.Size(75, 23);
            this.button_Si.TabIndex = 0;
            this.button_Si.Text = "Si";
            this.button_Si.UseVisualStyleBackColor = true;
            this.button_Si.Visible = false;
            this.button_Si.Click += new System.EventHandler(this.button_Si_Click);
            // 
            // button_No
            // 
            this.button_No.Location = new System.Drawing.Point(175, 155);
            this.button_No.Name = "button_No";
            this.button_No.Size = new System.Drawing.Size(75, 23);
            this.button_No.TabIndex = 1;
            this.button_No.Text = "No";
            this.button_No.UseVisualStyleBackColor = true;
            this.button_No.Visible = false;
            this.button_No.Click += new System.EventHandler(this.button_No_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "La consulta ocurrio en el fecha y horario pactado?";
            this.label1.Visible = false;
            // 
            // label_CodigoTurno
            // 
            this.label_CodigoTurno.AutoSize = true;
            this.label_CodigoTurno.Location = new System.Drawing.Point(12, 23);
            this.label_CodigoTurno.Name = "label_CodigoTurno";
            this.label_CodigoTurno.Size = new System.Drawing.Size(85, 13);
            this.label_CodigoTurno.TabIndex = 3;
            this.label_CodigoTurno.Text = "Codigo de turno:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(103, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // button_Ok
            // 
            this.button_Ok.Location = new System.Drawing.Point(226, 23);
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.Size = new System.Drawing.Size(44, 23);
            this.button_Ok.TabIndex = 5;
            this.button_Ok.Text = "Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.button_Ok_Click);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Location = new System.Drawing.Point(63, 7);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 13);
            this.label_Error.TabIndex = 6;
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Location = new System.Drawing.Point(103, 115);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(0, 13);
            this.label_Fecha.TabIndex = 7;
            // 
            // comboBox_Sintomas
            // 
            this.comboBox_Sintomas.FormattingEnabled = true;
            this.comboBox_Sintomas.Location = new System.Drawing.Point(66, 228);
            this.comboBox_Sintomas.Name = "comboBox_Sintomas";
            this.comboBox_Sintomas.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Sintomas.TabIndex = 8;
            this.comboBox_Sintomas.Visible = false;
            // 
            // button_Sintomas
            // 
            this.button_Sintomas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_Sintomas.Location = new System.Drawing.Point(215, 228);
            this.button_Sintomas.Name = "button_Sintomas";
            this.button_Sintomas.Size = new System.Drawing.Size(35, 23);
            this.button_Sintomas.TabIndex = 9;
            this.button_Sintomas.Text = "+";
            this.button_Sintomas.UseVisualStyleBackColor = true;
            this.button_Sintomas.Visible = false;
            this.button_Sintomas.Click += new System.EventHandler(this.button_Sintomas_Click);
            // 
            // comboBox_Enfermedades
            // 
            this.comboBox_Enfermedades.FormattingEnabled = true;
            this.comboBox_Enfermedades.Location = new System.Drawing.Point(66, 304);
            this.comboBox_Enfermedades.Name = "comboBox_Enfermedades";
            this.comboBox_Enfermedades.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Enfermedades.TabIndex = 10;
            this.comboBox_Enfermedades.Visible = false;
            // 
            // button_Enfermedades
            // 
            this.button_Enfermedades.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.button_Enfermedades.Location = new System.Drawing.Point(215, 302);
            this.button_Enfermedades.Name = "button_Enfermedades";
            this.button_Enfermedades.Size = new System.Drawing.Size(35, 23);
            this.button_Enfermedades.TabIndex = 11;
            this.button_Enfermedades.Text = "+";
            this.button_Enfermedades.UseVisualStyleBackColor = true;
            this.button_Enfermedades.Visible = false;
            this.button_Enfermedades.Click += new System.EventHandler(this.button_Enfermedades_Click);
            // 
            // label_Sintomas
            // 
            this.label_Sintomas.AutoSize = true;
            this.label_Sintomas.Location = new System.Drawing.Point(39, 202);
            this.label_Sintomas.Name = "label_Sintomas";
            this.label_Sintomas.Size = new System.Drawing.Size(50, 13);
            this.label_Sintomas.TabIndex = 12;
            this.label_Sintomas.Text = "Sintomas";
            this.label_Sintomas.Visible = false;
            // 
            // label_Enfermedades
            // 
            this.label_Enfermedades.AutoSize = true;
            this.label_Enfermedades.Location = new System.Drawing.Point(42, 283);
            this.label_Enfermedades.Name = "label_Enfermedades";
            this.label_Enfermedades.Size = new System.Drawing.Size(75, 13);
            this.label_Enfermedades.TabIndex = 13;
            this.label_Enfermedades.Text = "Enfermedades";
            this.label_Enfermedades.Visible = false;
            // 
            // button_Aceptar
            // 
            this.button_Aceptar.Location = new System.Drawing.Point(63, 372);
            this.button_Aceptar.Name = "button_Aceptar";
            this.button_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.button_Aceptar.TabIndex = 14;
            this.button_Aceptar.Text = "Aceptar";
            this.button_Aceptar.UseVisualStyleBackColor = true;
            this.button_Aceptar.Visible = false;
            this.button_Aceptar.Click += new System.EventHandler(this.button_Aceptar_Click);
            // 
            // button_Cancelar
            // 
            this.button_Cancelar.Location = new System.Drawing.Point(175, 372);
            this.button_Cancelar.Name = "button_Cancelar";
            this.button_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.button_Cancelar.TabIndex = 15;
            this.button_Cancelar.Text = "Cancelar";
            this.button_Cancelar.UseVisualStyleBackColor = true;
            this.button_Cancelar.Visible = false;
            this.button_Cancelar.Click += new System.EventHandler(this.button_Cancelar_Click);
            // 
            // RegistroAtencionWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 407);
            this.Controls.Add(this.button_Cancelar);
            this.Controls.Add(this.button_Aceptar);
            this.Controls.Add(this.label_Enfermedades);
            this.Controls.Add(this.label_Sintomas);
            this.Controls.Add(this.button_Enfermedades);
            this.Controls.Add(this.comboBox_Enfermedades);
            this.Controls.Add(this.button_Sintomas);
            this.Controls.Add(this.comboBox_Sintomas);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_CodigoTurno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_No);
            this.Controls.Add(this.button_Si);
            this.Name = "RegistroAtencionWindow";
            this.Text = "Registro Atencion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Si;
        private System.Windows.Forms.Button button_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_CodigoTurno;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.ComboBox comboBox_Sintomas;
        private System.Windows.Forms.Button button_Sintomas;
        private System.Windows.Forms.ComboBox comboBox_Enfermedades;
        private System.Windows.Forms.Button button_Enfermedades;
        private System.Windows.Forms.Label label_Sintomas;
        private System.Windows.Forms.Label label_Enfermedades;
        private System.Windows.Forms.Button button_Aceptar;
        private System.Windows.Forms.Button button_Cancelar;
    }
}