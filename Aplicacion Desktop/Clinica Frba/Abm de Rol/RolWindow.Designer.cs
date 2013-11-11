namespace Clinica_Frba.Abm_de_Rol
{
    partial class RolWindow
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
            this.grpRol = new System.Windows.Forms.GroupBox();
            this.chkHabilitado = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lstFuncionalidades = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtgRoles = new System.Windows.Forms.DataGridView();
            this.grpRoles = new System.Windows.Forms.GroupBox();
            this.grpRol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).BeginInit();
            this.grpRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRol
            // 
            this.grpRol.Controls.Add(this.chkHabilitado);
            this.grpRol.Controls.Add(this.btnCancelar);
            this.grpRol.Controls.Add(this.btnGuardar);
            this.grpRol.Controls.Add(this.lstFuncionalidades);
            this.grpRol.Controls.Add(this.label2);
            this.grpRol.Controls.Add(this.txtNombre);
            this.grpRol.Controls.Add(this.label1);
            this.grpRol.Enabled = false;
            this.grpRol.Location = new System.Drawing.Point(286, 12);
            this.grpRol.Name = "grpRol";
            this.grpRol.Size = new System.Drawing.Size(267, 352);
            this.grpRol.TabIndex = 3;
            this.grpRol.TabStop = false;
            this.grpRol.Text = "Rol";
            // 
            // chkHabilitado
            // 
            this.chkHabilitado.AutoSize = true;
            this.chkHabilitado.Location = new System.Drawing.Point(14, 46);
            this.chkHabilitado.Name = "chkHabilitado";
            this.chkHabilitado.Size = new System.Drawing.Size(73, 17);
            this.chkHabilitado.TabIndex = 6;
            this.chkHabilitado.Text = "Habilitado";
            this.chkHabilitado.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(138, 314);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 30);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(10, 315);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(122, 30);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lstFuncionalidades
            // 
            this.lstFuncionalidades.FormattingEnabled = true;
            this.lstFuncionalidades.Location = new System.Drawing.Point(9, 80);
            this.lstFuncionalidades.Name = "lstFuncionalidades";
            this.lstFuncionalidades.Size = new System.Drawing.Size(254, 229);
            this.lstFuncionalidades.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Funcionalidades";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(67, 16);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(194, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btnAlta
            // 
            this.btnAlta.Location = new System.Drawing.Point(5, 323);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Size = new System.Drawing.Size(81, 22);
            this.btnAlta.TabIndex = 8;
            this.btnAlta.Text = "Nuevo Rol";
            this.btnAlta.UseVisualStyleBackColor = true;
            this.btnAlta.Click += new System.EventHandler(this.btnAlta_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(92, 323);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(94, 22);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar Rol";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtgRoles
            // 
            this.dtgRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgRoles.Location = new System.Drawing.Point(5, 19);
            this.dtgRoles.MultiSelect = false;
            this.dtgRoles.Name = "dtgRoles";
            this.dtgRoles.ReadOnly = true;
            this.dtgRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgRoles.Size = new System.Drawing.Size(268, 296);
            this.dtgRoles.TabIndex = 10;
            // 
            // grpRoles
            // 
            this.grpRoles.Controls.Add(this.dtgRoles);
            this.grpRoles.Controls.Add(this.btnModificar);
            this.grpRoles.Controls.Add(this.btnAlta);
            this.grpRoles.Location = new System.Drawing.Point(5, 12);
            this.grpRoles.Name = "grpRoles";
            this.grpRoles.Size = new System.Drawing.Size(275, 352);
            this.grpRoles.TabIndex = 4;
            this.grpRoles.TabStop = false;
            this.grpRoles.Text = "Roles";
            this.grpRoles.Enter += new System.EventHandler(this.grpRoles_Enter);
            // 
            // RolWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 368);
            this.Controls.Add(this.grpRoles);
            this.Controls.Add(this.grpRol);
            this.Name = "RolWindow";
            this.Text = "Rol";
            this.grpRol.ResumeLayout(false);
            this.grpRol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgRoles)).EndInit();
            this.grpRoles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox lstFuncionalidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.CheckBox chkHabilitado;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DataGridView dtgRoles;
        private System.Windows.Forms.GroupBox grpRoles;
    }
}