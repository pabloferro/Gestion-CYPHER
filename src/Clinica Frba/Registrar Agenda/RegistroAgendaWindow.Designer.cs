namespace Clinica_Frba.Registrar_Agenda
{
    partial class RegistroAgendaWindow
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
            this.btnAlta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dtpFechaInicial = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.chkLu = new System.Windows.Forms.CheckBox();
            this.dtpDesdeLu = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpHastaLu = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpHastaMa = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDesdeMa = new System.Windows.Forms.DateTimePicker();
            this.chkMa = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpHastaMi = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDesdeMi = new System.Windows.Forms.DateTimePicker();
            this.chkMi = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpHastaJu = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpDesdeJu = new System.Windows.Forms.DateTimePicker();
            this.chkJu = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dtpHastaVi = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDesdeVi = new System.Windows.Forms.DateTimePicker();
            this.chkVi = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.dtpHastaSa = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.dtpDesdeSa = new System.Windows.Forms.DateTimePicker();
            this.chkSa = new System.Windows.Forms.CheckBox();
            this.txtNumero = new System.Windows.Forms.NumericTextBox();
            this.SuspendLayout();
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(57, 268);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(155, 27);
            this.btnAlta.TabIndex = 1;
            this.btnAlta.Text = "Registrar Agenda";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nro Médico";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Fecha Inicial";
            // 
            // dtpFechaInicial
            // 
            this.dtpFechaInicial.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaInicial.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaInicial.Location = new System.Drawing.Point(95, 44);
            this.dtpFechaInicial.Name = "dtpFechaInicial";
            this.dtpFechaInicial.Size = new System.Drawing.Size(157, 20);
            this.dtpFechaInicial.TabIndex = 18;
            this.dtpFechaInicial.Value = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            this.dtpFechaInicial.ValueChanged += new System.EventHandler(this.dtpFechaInicial_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fecha Final";
            // 
            // dtpFechaFinal
            // 
            this.dtpFechaFinal.CustomFormat = "dd/MM/yyyy";
            this.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaFinal.Location = new System.Drawing.Point(95, 69);
            this.dtpFechaFinal.Name = "dtpFechaFinal";
            this.dtpFechaFinal.Size = new System.Drawing.Size(157, 20);
            this.dtpFechaFinal.TabIndex = 20;
            this.dtpFechaFinal.Value = new System.DateTime(2013, 5, 1, 0, 0, 0, 0);
            // 
            // chkLu
            // 
            this.chkLu.AutoSize = true;
            this.chkLu.Location = new System.Drawing.Point(15, 100);
            this.chkLu.Name = "chkLu";
            this.chkLu.Size = new System.Drawing.Size(55, 17);
            this.chkLu.TabIndex = 22;
            this.chkLu.Text = "Lunes";
            this.chkLu.UseVisualStyleBackColor = true;
            this.chkLu.CheckedChanged += new System.EventHandler(this.chkLu_CheckedChanged);
            // 
            // dtpDesdeLu
            // 
            this.dtpDesdeLu.CustomFormat = "HH:mm";
            this.dtpDesdeLu.Enabled = false;
            this.dtpDesdeLu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeLu.Location = new System.Drawing.Point(114, 97);
            this.dtpDesdeLu.MaxDate = new System.DateTime(2013, 12, 1, 19, 30, 0, 0);
            this.dtpDesdeLu.MinDate = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeLu.Name = "dtpDesdeLu";
            this.dtpDesdeLu.ShowUpDown = true;
            this.dtpDesdeLu.Size = new System.Drawing.Size(53, 20);
            this.dtpDesdeLu.TabIndex = 23;
            this.dtpDesdeLu.Value = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeLu.ValueChanged += new System.EventHandler(this.dtpDesdeLu_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Desde";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Hasta";
            // 
            // dtpHastaLu
            // 
            this.dtpHastaLu.CustomFormat = "HH:mm";
            this.dtpHastaLu.Enabled = false;
            this.dtpHastaLu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaLu.Location = new System.Drawing.Point(202, 97);
            this.dtpHastaLu.MaxDate = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            this.dtpHastaLu.MinDate = new System.DateTime(2013, 12, 1, 10, 30, 0, 0);
            this.dtpHastaLu.Name = "dtpHastaLu";
            this.dtpHastaLu.ShowUpDown = true;
            this.dtpHastaLu.Size = new System.Drawing.Size(53, 20);
            this.dtpHastaLu.TabIndex = 25;
            this.dtpHastaLu.Value = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(167, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Hasta";
            // 
            // dtpHastaMa
            // 
            this.dtpHastaMa.CustomFormat = "HH:mm";
            this.dtpHastaMa.Enabled = false;
            this.dtpHastaMa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaMa.Location = new System.Drawing.Point(202, 120);
            this.dtpHastaMa.MaxDate = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            this.dtpHastaMa.MinDate = new System.DateTime(2013, 12, 1, 10, 30, 0, 0);
            this.dtpHastaMa.Name = "dtpHastaMa";
            this.dtpHastaMa.ShowUpDown = true;
            this.dtpHastaMa.Size = new System.Drawing.Size(53, 20);
            this.dtpHastaMa.TabIndex = 30;
            this.dtpHastaMa.Value = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(78, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Desde";
            // 
            // dtpDesdeMa
            // 
            this.dtpDesdeMa.CustomFormat = "HH:mm";
            this.dtpDesdeMa.Enabled = false;
            this.dtpDesdeMa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeMa.Location = new System.Drawing.Point(114, 120);
            this.dtpDesdeMa.MaxDate = new System.DateTime(2013, 12, 1, 19, 30, 0, 0);
            this.dtpDesdeMa.MinDate = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeMa.Name = "dtpDesdeMa";
            this.dtpDesdeMa.ShowUpDown = true;
            this.dtpDesdeMa.Size = new System.Drawing.Size(53, 20);
            this.dtpDesdeMa.TabIndex = 28;
            this.dtpDesdeMa.Value = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeMa.ValueChanged += new System.EventHandler(this.dtpDesdeMa_ValueChanged);
            // 
            // chkMa
            // 
            this.chkMa.AutoSize = true;
            this.chkMa.Location = new System.Drawing.Point(15, 123);
            this.chkMa.Name = "chkMa";
            this.chkMa.Size = new System.Drawing.Size(58, 17);
            this.chkMa.TabIndex = 27;
            this.chkMa.Text = "Martes";
            this.chkMa.UseVisualStyleBackColor = true;
            this.chkMa.CheckedChanged += new System.EventHandler(this.chkMa_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Hasta";
            // 
            // dtpHastaMi
            // 
            this.dtpHastaMi.CustomFormat = "HH:mm";
            this.dtpHastaMi.Enabled = false;
            this.dtpHastaMi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaMi.Location = new System.Drawing.Point(202, 143);
            this.dtpHastaMi.MaxDate = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            this.dtpHastaMi.MinDate = new System.DateTime(2013, 12, 1, 10, 30, 0, 0);
            this.dtpHastaMi.Name = "dtpHastaMi";
            this.dtpHastaMi.ShowUpDown = true;
            this.dtpHastaMi.Size = new System.Drawing.Size(53, 20);
            this.dtpHastaMi.TabIndex = 35;
            this.dtpHastaMi.Value = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(78, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Desde";
            // 
            // dtpDesdeMi
            // 
            this.dtpDesdeMi.CustomFormat = "HH:mm";
            this.dtpDesdeMi.Enabled = false;
            this.dtpDesdeMi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeMi.Location = new System.Drawing.Point(114, 143);
            this.dtpDesdeMi.MaxDate = new System.DateTime(2013, 12, 1, 19, 30, 0, 0);
            this.dtpDesdeMi.MinDate = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeMi.Name = "dtpDesdeMi";
            this.dtpDesdeMi.ShowUpDown = true;
            this.dtpDesdeMi.Size = new System.Drawing.Size(53, 20);
            this.dtpDesdeMi.TabIndex = 33;
            this.dtpDesdeMi.Value = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeMi.ValueChanged += new System.EventHandler(this.dtpDesdeMi_ValueChanged);
            // 
            // chkMi
            // 
            this.chkMi.AutoSize = true;
            this.chkMi.Location = new System.Drawing.Point(15, 146);
            this.chkMi.Name = "chkMi";
            this.chkMi.Size = new System.Drawing.Size(71, 17);
            this.chkMi.TabIndex = 32;
            this.chkMi.Text = "Miércoles";
            this.chkMi.UseVisualStyleBackColor = true;
            this.chkMi.CheckedChanged += new System.EventHandler(this.chkMi_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(167, 170);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Hasta";
            // 
            // dtpHastaJu
            // 
            this.dtpHastaJu.CustomFormat = "HH:mm";
            this.dtpHastaJu.Enabled = false;
            this.dtpHastaJu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaJu.Location = new System.Drawing.Point(202, 166);
            this.dtpHastaJu.MaxDate = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            this.dtpHastaJu.MinDate = new System.DateTime(2013, 12, 1, 10, 30, 0, 0);
            this.dtpHastaJu.Name = "dtpHastaJu";
            this.dtpHastaJu.ShowUpDown = true;
            this.dtpHastaJu.Size = new System.Drawing.Size(53, 20);
            this.dtpHastaJu.TabIndex = 40;
            this.dtpHastaJu.Value = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(78, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Desde";
            // 
            // dtpDesdeJu
            // 
            this.dtpDesdeJu.CustomFormat = "HH:mm";
            this.dtpDesdeJu.Enabled = false;
            this.dtpDesdeJu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeJu.Location = new System.Drawing.Point(114, 166);
            this.dtpDesdeJu.MaxDate = new System.DateTime(2013, 12, 1, 19, 30, 0, 0);
            this.dtpDesdeJu.MinDate = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeJu.Name = "dtpDesdeJu";
            this.dtpDesdeJu.ShowUpDown = true;
            this.dtpDesdeJu.Size = new System.Drawing.Size(53, 20);
            this.dtpDesdeJu.TabIndex = 38;
            this.dtpDesdeJu.Value = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeJu.ValueChanged += new System.EventHandler(this.dtpDesdeJu_ValueChanged);
            // 
            // chkJu
            // 
            this.chkJu.AutoSize = true;
            this.chkJu.Location = new System.Drawing.Point(15, 169);
            this.chkJu.Name = "chkJu";
            this.chkJu.Size = new System.Drawing.Size(60, 17);
            this.chkJu.TabIndex = 37;
            this.chkJu.Text = "Jueves";
            this.chkJu.UseVisualStyleBackColor = true;
            this.chkJu.CheckedChanged += new System.EventHandler(this.chkJu_CheckedChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(167, 193);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Hasta";
            // 
            // dtpHastaVi
            // 
            this.dtpHastaVi.CustomFormat = "HH:mm";
            this.dtpHastaVi.Enabled = false;
            this.dtpHastaVi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaVi.Location = new System.Drawing.Point(202, 189);
            this.dtpHastaVi.MaxDate = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            this.dtpHastaVi.MinDate = new System.DateTime(2013, 12, 1, 10, 30, 0, 0);
            this.dtpHastaVi.Name = "dtpHastaVi";
            this.dtpHastaVi.ShowUpDown = true;
            this.dtpHastaVi.Size = new System.Drawing.Size(53, 20);
            this.dtpHastaVi.TabIndex = 45;
            this.dtpHastaVi.Value = new System.DateTime(2013, 12, 1, 20, 0, 0, 0);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(78, 193);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Desde";
            // 
            // dtpDesdeVi
            // 
            this.dtpDesdeVi.CustomFormat = "HH:mm";
            this.dtpDesdeVi.Enabled = false;
            this.dtpDesdeVi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeVi.Location = new System.Drawing.Point(114, 189);
            this.dtpDesdeVi.MaxDate = new System.DateTime(2013, 12, 1, 19, 30, 0, 0);
            this.dtpDesdeVi.MinDate = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeVi.Name = "dtpDesdeVi";
            this.dtpDesdeVi.ShowUpDown = true;
            this.dtpDesdeVi.Size = new System.Drawing.Size(53, 20);
            this.dtpDesdeVi.TabIndex = 43;
            this.dtpDesdeVi.Value = new System.DateTime(2013, 12, 1, 7, 0, 0, 0);
            this.dtpDesdeVi.ValueChanged += new System.EventHandler(this.dtpDesdeVi_ValueChanged);
            // 
            // chkVi
            // 
            this.chkVi.AutoSize = true;
            this.chkVi.Location = new System.Drawing.Point(15, 192);
            this.chkVi.Name = "chkVi";
            this.chkVi.Size = new System.Drawing.Size(61, 17);
            this.chkVi.TabIndex = 42;
            this.chkVi.Text = "Viernes";
            this.chkVi.UseVisualStyleBackColor = true;
            this.chkVi.CheckedChanged += new System.EventHandler(this.chkVi_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(167, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 51;
            this.label14.Text = "Hasta";
            // 
            // dtpHastaSa
            // 
            this.dtpHastaSa.CustomFormat = "HH:mm";
            this.dtpHastaSa.Enabled = false;
            this.dtpHastaSa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHastaSa.Location = new System.Drawing.Point(202, 212);
            this.dtpHastaSa.MaxDate = new System.DateTime(2013, 12, 1, 15, 0, 0, 0);
            this.dtpHastaSa.MinDate = new System.DateTime(2013, 12, 1, 10, 30, 0, 0);
            this.dtpHastaSa.Name = "dtpHastaSa";
            this.dtpHastaSa.ShowUpDown = true;
            this.dtpHastaSa.Size = new System.Drawing.Size(53, 20);
            this.dtpHastaSa.TabIndex = 50;
            this.dtpHastaSa.Value = new System.DateTime(2013, 12, 1, 15, 0, 0, 0);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(78, 216);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 49;
            this.label15.Text = "Desde";
            // 
            // dtpDesdeSa
            // 
            this.dtpDesdeSa.CustomFormat = "HH:mm";
            this.dtpDesdeSa.Enabled = false;
            this.dtpDesdeSa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDesdeSa.Location = new System.Drawing.Point(114, 212);
            this.dtpDesdeSa.MaxDate = new System.DateTime(2013, 12, 1, 14, 30, 0, 0);
            this.dtpDesdeSa.MinDate = new System.DateTime(2013, 12, 1, 10, 0, 0, 0);
            this.dtpDesdeSa.Name = "dtpDesdeSa";
            this.dtpDesdeSa.ShowUpDown = true;
            this.dtpDesdeSa.Size = new System.Drawing.Size(53, 20);
            this.dtpDesdeSa.TabIndex = 48;
            this.dtpDesdeSa.Value = new System.DateTime(2013, 12, 1, 10, 0, 0, 0);
            this.dtpDesdeSa.ValueChanged += new System.EventHandler(this.dtpDesdeSa_ValueChanged);
            // 
            // chkSa
            // 
            this.chkSa.AutoSize = true;
            this.chkSa.Location = new System.Drawing.Point(15, 215);
            this.chkSa.Name = "chkSa";
            this.chkSa.Size = new System.Drawing.Size(63, 17);
            this.chkSa.TabIndex = 47;
            this.chkSa.Text = "Sábado";
            this.chkSa.UseVisualStyleBackColor = true;
            this.chkSa.CheckedChanged += new System.EventHandler(this.chkSa_CheckedChanged);
            // 
            // txtNumero
            // 
            this.txtNumero.AllowSpace = false;
            this.txtNumero.Location = new System.Drawing.Point(95, 15);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(157, 20);
            this.txtNumero.TabIndex = 52;
            // 
            // RegistroAgendaWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 307);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dtpHastaSa);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dtpDesdeSa);
            this.Controls.Add(this.chkSa);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dtpHastaVi);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpDesdeVi);
            this.Controls.Add(this.chkVi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpHastaJu);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dtpDesdeJu);
            this.Controls.Add(this.chkJu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpHastaMi);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpDesdeMi);
            this.Controls.Add(this.chkMi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpHastaMa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtpDesdeMa);
            this.Controls.Add(this.chkMa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpHastaLu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtpDesdeLu);
            this.Controls.Add(this.chkLu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpFechaFinal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtpFechaInicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAlta);
            this.Name = "RegistroAgendaWindow";
            this.Text = "Registrar Agenda";
            this.Load += new System.EventHandler(this.RegistroAgendaWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpFechaInicial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFechaFinal;
        private System.Windows.Forms.CheckBox chkLu;
        private System.Windows.Forms.DateTimePicker dtpDesdeLu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpHastaLu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpHastaMa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpDesdeMa;
        private System.Windows.Forms.CheckBox chkMa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpHastaMi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDesdeMi;
        private System.Windows.Forms.CheckBox chkMi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpHastaJu;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtpDesdeJu;
        private System.Windows.Forms.CheckBox chkJu;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker dtpHastaVi;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDesdeVi;
        private System.Windows.Forms.CheckBox chkVi;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dtpHastaSa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DateTimePicker dtpDesdeSa;
        private System.Windows.Forms.CheckBox chkSa;
        private System.Windows.Forms.NumericTextBox txtNumero;
    }
}