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
            this.label4 = new System.Windows.Forms.Label();
            this.dtgTurnos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNroAfiliado = new System.Windows.Forms.NumericTextBox();
            this.txtBono = new System.Windows.Forms.NumericTextBox();
            this.txtNroMedico = new System.Windows.Forms.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(240, 342);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 30);
            this.btnSalir.TabIndex = 81;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(95, 39);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(220, 23);
            this.btnVer.TabIndex = 80;
            this.btnVer.Text = "Ver Turnos";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 311);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "BONO CONSULTA";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(15, 342);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(157, 30);
            this.btnRegistrar.TabIndex = 86;
            this.btnRegistrar.Text = "Registrar Llegada";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 88;
            this.label5.Text = "Nro de Afiliado";
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.AllowSpace = false;
            this.txtNroAfiliado.Location = new System.Drawing.Point(117, 281);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(209, 20);
            this.txtNroAfiliado.TabIndex = 87;
            // 
            // txtBono
            // 
            this.txtBono.AllowSpace = false;
            this.txtBono.Location = new System.Drawing.Point(117, 307);
            this.txtBono.Name = "txtBono";
            this.txtBono.Size = new System.Drawing.Size(209, 20);
            this.txtBono.TabIndex = 82;
            // 
            // txtNroMedico
            // 
            this.txtNroMedico.AllowSpace = false;
            this.txtNroMedico.Location = new System.Drawing.Point(95, 13);
            this.txtNroMedico.Name = "txtNroMedico";
            this.txtNroMedico.Size = new System.Drawing.Size(220, 20);
            this.txtNroMedico.TabIndex = 79;
            // 
            // RegistroLlegadaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 384);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNroAfiliado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBono);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.txtNroMedico);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtgTurnos);
            this.Name = "RegistroLlegadaWindow";
            this.Text = "Registro de Llegada";
            this.Load += new System.EventHandler(this.RegistroLlegadaWindow_Load);
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
        private System.Windows.Forms.NumericTextBox txtBono;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericTextBox txtNroAfiliado;
    }
}