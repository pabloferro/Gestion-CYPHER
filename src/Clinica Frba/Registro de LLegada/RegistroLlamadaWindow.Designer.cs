namespace Clinica_Frba.Registro_de_llegada
{
    partial class RegistroLlegadaWindow
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
            this.btnVer = new System.Windows.Forms.Button();
            this.txtNroMedico = new System.Windows.Forms.NumericTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtgTurnos = new System.Windows.Forms.DataGridView();
            this.numericTextBox1 = new System.Windows.Forms.NumericTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(253, 305);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 81;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(77, 39);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(184, 23);
            this.btnVer.TabIndex = 80;
            this.btnVer.Text = "Ver Turnos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // txtNroMedico
            // 
            this.txtNroMedico.AllowSpace = false;
            this.txtNroMedico.Location = new System.Drawing.Point(95, 13);
            this.txtNroMedico.Name = "txtNroMedico";
            this.txtNroMedico.Size = new System.Drawing.Size(220, 20);
            this.txtNroMedico.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 78;
            this.label4.Text = "Nro Médico";
            // 
            // dtgTurnos
            // 
            this.dtgTurnos.AllowUserToAddRows = false;
            this.dtgTurnos.AllowUserToDeleteRows = false;
            this.dtgTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTurnos.Location = new System.Drawing.Point(12, 68);
            this.dtgTurnos.MultiSelect = false;
            this.dtgTurnos.Name = "dtgTurnos";
            this.dtgTurnos.ReadOnly = true;
            this.dtgTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTurnos.Size = new System.Drawing.Size(316, 198);
            this.dtgTurnos.TabIndex = 77;
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Location = new System.Drawing.Point(118, 270);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(209, 20);
            this.numericTextBox1.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 83;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 84;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "BONO CONSULTA";
            // 
            // RegistroLlegadaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 340);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericTextBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtNroMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgTurnos);
            this.Name = "RegistroLlegadaWindow";
            this.Text = "Registro de Llegada";
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.NumericTextBox txtNroMedico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtgTurnos;
        private System.Windows.Forms.NumericTextBox numericTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}