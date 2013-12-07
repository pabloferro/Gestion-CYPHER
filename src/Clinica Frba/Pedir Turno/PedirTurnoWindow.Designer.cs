namespace Clinica_Frba.Pedir_Turno
{
    partial class PedirTurnoWindow
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
            this.btnVerFechas = new System.Windows.Forms.Button();
            this.dtgFechas = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgTurnos = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbEspecialidad = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNroAfiliado = new System.Windows.Forms.NumericTextBox();
            this.txtNumero = new System.Windows.Forms.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFechas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Nro Médico";
            // 
            // btnVerFechas
            // 
            this.btnVerFechas.Location = new System.Drawing.Point(308, 12);
            this.btnVerFechas.Name = "btnVerFechas";
            this.btnVerFechas.Size = new System.Drawing.Size(37, 22);
            this.btnVerFechas.TabIndex = 56;
            this.btnVerFechas.Text = "OK";
            this.btnVerFechas.UseVisualStyleBackColor = true;
            this.btnVerFechas.Click += new System.EventHandler(this.btnVerFechas_Click);
            // 
            // dtgFechas
            // 
            this.dtgFechas.AllowUserToAddRows = false;
            this.dtgFechas.AllowUserToDeleteRows = false;
            this.dtgFechas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgFechas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFechas.Location = new System.Drawing.Point(12, 81);
            this.dtgFechas.MultiSelect = false;
            this.dtgFechas.Name = "dtgFechas";
            this.dtgFechas.ReadOnly = true;
            this.dtgFechas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFechas.Size = new System.Drawing.Size(229, 198);
            this.dtgFechas.TabIndex = 57;
            this.dtgFechas.SelectionChanged += new System.EventHandler(this.dtgFechas_SelectionChanged);
            this.dtgFechas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgFechas_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Fechas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "Turnos";
            // 
            // dtgTurnos
            // 
            this.dtgTurnos.AllowUserToAddRows = false;
            this.dtgTurnos.AllowUserToDeleteRows = false;
            this.dtgTurnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgTurnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTurnos.Location = new System.Drawing.Point(247, 81);
            this.dtgTurnos.MultiSelect = false;
            this.dtgTurnos.Name = "dtgTurnos";
            this.dtgTurnos.ReadOnly = true;
            this.dtgTurnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgTurnos.Size = new System.Drawing.Size(206, 198);
            this.dtgTurnos.TabIndex = 59;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 314);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 24);
            this.button1.TabIndex = 61;
            this.button1.Text = "Pedir Turno Seleccionado";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "Nro Afiliado";
            // 
            // cmbEspecialidad
            // 
            this.cmbEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEspecialidad.FormattingEnabled = true;
            this.cmbEspecialidad.Location = new System.Drawing.Point(247, 285);
            this.cmbEspecialidad.Name = "cmbEspecialidad";
            this.cmbEspecialidad.Size = new System.Drawing.Size(206, 21);
            this.cmbEspecialidad.TabIndex = 64;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(239, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 22);
            this.button2.TabIndex = 65;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtNroAfiliado
            // 
            this.txtNroAfiliado.AllowSpace = false;
            this.txtNroAfiliado.Location = new System.Drawing.Point(96, 37);
            this.txtNroAfiliado.Name = "txtNroAfiliado";
            this.txtNroAfiliado.Size = new System.Drawing.Size(141, 20);
            this.txtNroAfiliado.TabIndex = 63;
            // 
            // txtNumero
            // 
            this.txtNumero.AllowSpace = false;
            this.txtNumero.Location = new System.Drawing.Point(96, 12);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(141, 20);
            this.txtNumero.TabIndex = 54;
            // 
            // PedirTurnoWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbEspecialidad);
            this.Controls.Add(this.txtNroAfiliado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgTurnos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgFechas);
            this.Controls.Add(this.btnVerFechas);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label1);
            this.Name = "PedirTurnoWindow";
            this.Text = "Pedir Turno";
            this.Load += new System.EventHandler(this.PedirTurnoWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFechas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTurnos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericTextBox txtNumero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerFechas;
        private System.Windows.Forms.DataGridView dtgFechas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dtgTurnos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericTextBox txtNroAfiliado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbEspecialidad;
        private System.Windows.Forms.Button button2;
    }
}