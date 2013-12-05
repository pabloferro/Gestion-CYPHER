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
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(253, 272);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 81;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            // RegistroLlegadaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 306);
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
    }
}