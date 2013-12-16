namespace Clinica_Frba.Generar_Receta
{
    partial class GenerarRecetaWindow
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.listBox_Bonos = new System.Windows.Forms.ListBox();
            this.listBox_Medicamentos = new System.Windows.Forms.ListBox();
            this.label_Error = new System.Windows.Forms.Label();
            this.label_Cantidad = new System.Windows.Forms.Label();
            this.label_Fecha = new System.Windows.Forms.Label();
            this.button_Bono = new System.Windows.Forms.Button();
            this.textBox_Medicamento = new System.Windows.Forms.TextBox();
            this.button_Medicamento = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label_Afiliado = new System.Windows.Forms.Label();
            this.button_Afiliado = new System.Windows.Forms.Button();
            this.numericTextBox_Afiliado = new System.Windows.Forms.NumericTextBox();
            this.numericTextBox1 = new System.Windows.Forms.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(369, 103);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // listBox_Bonos
            // 
            this.listBox_Bonos.FormattingEnabled = true;
            this.listBox_Bonos.Location = new System.Drawing.Point(37, 163);
            this.listBox_Bonos.Name = "listBox_Bonos";
            this.listBox_Bonos.Size = new System.Drawing.Size(98, 95);
            this.listBox_Bonos.TabIndex = 2;
            this.listBox_Bonos.Visible = false;
            this.listBox_Bonos.SelectedIndexChanged += new System.EventHandler(this.listBox_Bonos_SelectedIndexChanged);
            // 
            // listBox_Medicamentos
            // 
            this.listBox_Medicamentos.FormattingEnabled = true;
            this.listBox_Medicamentos.Location = new System.Drawing.Point(197, 163);
            this.listBox_Medicamentos.Name = "listBox_Medicamentos";
            this.listBox_Medicamentos.Size = new System.Drawing.Size(159, 95);
            this.listBox_Medicamentos.TabIndex = 3;
            this.listBox_Medicamentos.Visible = false;
            this.listBox_Medicamentos.SelectedIndexChanged += new System.EventHandler(this.listBox_Medicamentos_SelectedIndexChanged);
            // 
            // label_Error
            // 
            this.label_Error.AutoSize = true;
            this.label_Error.Location = new System.Drawing.Point(194, 13);
            this.label_Error.Name = "label_Error";
            this.label_Error.Size = new System.Drawing.Size(0, 13);
            this.label_Error.TabIndex = 5;
            // 
            // label_Cantidad
            // 
            this.label_Cantidad.AutoSize = true;
            this.label_Cantidad.Location = new System.Drawing.Point(417, 50);
            this.label_Cantidad.Name = "label_Cantidad";
            this.label_Cantidad.Size = new System.Drawing.Size(49, 13);
            this.label_Cantidad.TabIndex = 6;
            this.label_Cantidad.Text = "Cantidad";
            this.label_Cantidad.Visible = false;
            // 
            // label_Fecha
            // 
            this.label_Fecha.AutoSize = true;
            this.label_Fecha.Location = new System.Drawing.Point(406, 92);
            this.label_Fecha.Name = "label_Fecha";
            this.label_Fecha.Size = new System.Drawing.Size(98, 13);
            this.label_Fecha.TabIndex = 7;
            this.label_Fecha.Text = "Fecha Prescripcion";
            this.label_Fecha.Visible = false;
            // 
            // button_Bono
            // 
            this.button_Bono.Location = new System.Drawing.Point(37, 124);
            this.button_Bono.Name = "button_Bono";
            this.button_Bono.Size = new System.Drawing.Size(98, 23);
            this.button_Bono.TabIndex = 8;
            this.button_Bono.Text = "Agregar Bono";
            this.button_Bono.UseVisualStyleBackColor = true;
            this.button_Bono.Visible = false;
            this.button_Bono.Click += new System.EventHandler(this.button_Bono_Click);
            // 
            // textBox_Medicamento
            // 
            this.textBox_Medicamento.Location = new System.Drawing.Point(197, 85);
            this.textBox_Medicamento.Name = "textBox_Medicamento";
            this.textBox_Medicamento.Size = new System.Drawing.Size(100, 20);
            this.textBox_Medicamento.TabIndex = 9;
            this.textBox_Medicamento.Visible = false;
            // 
            // button_Medicamento
            // 
            this.button_Medicamento.Location = new System.Drawing.Point(197, 124);
            this.button_Medicamento.Name = "button_Medicamento";
            this.button_Medicamento.Size = new System.Drawing.Size(129, 23);
            this.button_Medicamento.TabIndex = 10;
            this.button_Medicamento.Text = "Agregar Medicamento";
            this.button_Medicamento.UseVisualStyleBackColor = true;
            this.button_Medicamento.Visible = false;
            this.button_Medicamento.Click += new System.EventHandler(this.button_Medicamento_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(476, 48);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(28, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Visible = false;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo De Bono:";
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(194, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Medicamento:";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(118, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_Afiliado
            // 
            this.label_Afiliado.AutoSize = true;
            this.label_Afiliado.Location = new System.Drawing.Point(34, 44);
            this.label_Afiliado.Name = "label_Afiliado";
            this.label_Afiliado.Size = new System.Drawing.Size(47, 13);
            this.label_Afiliado.TabIndex = 16;
            this.label_Afiliado.Text = "Afiliado :";
            // 
            // button_Afiliado
            // 
            this.button_Afiliado.Location = new System.Drawing.Point(197, 38);
            this.button_Afiliado.Name = "button_Afiliado";
            this.button_Afiliado.Size = new System.Drawing.Size(39, 23);
            this.button_Afiliado.TabIndex = 18;
            this.button_Afiliado.Text = "OK";
            this.button_Afiliado.UseVisualStyleBackColor = true;
            this.button_Afiliado.Click += new System.EventHandler(this.button_Afiliado_Click);
            // 
            // numericTextBox_Afiliado
            // 
            this.numericTextBox_Afiliado.AllowSpace = false;
            this.numericTextBox_Afiliado.Location = new System.Drawing.Point(118, 41);
            this.numericTextBox_Afiliado.Name = "numericTextBox_Afiliado";
            this.numericTextBox_Afiliado.Size = new System.Drawing.Size(70, 20);
            this.numericTextBox_Afiliado.TabIndex = 17;
            // 
            // numericTextBox1
            // 
            this.numericTextBox1.AllowSpace = false;
            this.numericTextBox1.Location = new System.Drawing.Point(37, 89);
            this.numericTextBox1.Name = "numericTextBox1";
            this.numericTextBox1.Size = new System.Drawing.Size(98, 20);
            this.numericTextBox1.TabIndex = 0;
            this.numericTextBox1.Visible = false;
            // 
            // GenerarRecetaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 331);
            this.Controls.Add(this.button_Afiliado);
            this.Controls.Add(this.numericTextBox_Afiliado);
            this.Controls.Add(this.label_Afiliado);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button_Medicamento);
            this.Controls.Add(this.textBox_Medicamento);
            this.Controls.Add(this.button_Bono);
            this.Controls.Add(this.label_Fecha);
            this.Controls.Add(this.label_Cantidad);
            this.Controls.Add(this.label_Error);
            this.Controls.Add(this.listBox_Medicamentos);
            this.Controls.Add(this.listBox_Bonos);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.numericTextBox1);
            this.Name = "GenerarRecetaWindow";
            this.Text = "Nueva Receta";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericTextBox numericTextBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.ListBox listBox_Bonos;
        private System.Windows.Forms.ListBox listBox_Medicamentos;
        private System.Windows.Forms.Label label_Error;
        private System.Windows.Forms.Label label_Cantidad;
        private System.Windows.Forms.Label label_Fecha;
        private System.Windows.Forms.Button button_Bono;
        private System.Windows.Forms.TextBox textBox_Medicamento;
        private System.Windows.Forms.Button button_Medicamento;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label_Afiliado;
        private System.Windows.Forms.NumericTextBox numericTextBox_Afiliado;
        private System.Windows.Forms.Button button_Afiliado;
    }
}