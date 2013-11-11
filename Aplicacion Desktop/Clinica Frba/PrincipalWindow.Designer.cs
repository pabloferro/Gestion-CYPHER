namespace Clinica_Frba
{
    partial class PrincipalWindow
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
            this.button_roles = new System.Windows.Forms.Button();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.button_afiliados = new System.Windows.Forms.Button();
            this.button_especialidades = new System.Windows.Forms.Button();
            this.button_planes = new System.Windows.Forms.Button();
            this.button_profesionales = new System.Windows.Forms.Button();
            this.button_cancelar = new System.Windows.Forms.Button();
            this.button_compraBonos = new System.Windows.Forms.Button();
            this.button_receta = new System.Windows.Forms.Button();
            this.button_estadisticas = new System.Windows.Forms.Button();
            this.button_turno = new System.Windows.Forms.Button();
            this.button_agenda = new System.Windows.Forms.Button();
            this.button_llegada = new System.Windows.Forms.Button();
            this.button_atencion = new System.Windows.Forms.Button();
            this.button_usuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_roles
            // 
            this.button_roles.Location = new System.Drawing.Point(35, 72);
            this.button_roles.Name = "button_roles";
            this.button_roles.Size = new System.Drawing.Size(75, 23);
            this.button_roles.TabIndex = 0;
            this.button_roles.Text = "Roles";
            this.button_roles.UseVisualStyleBackColor = true;
            this.button_roles.Visible = false;
            this.button_roles.Click += new System.EventHandler(this.button_roles_Click);
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_Titulo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Titulo.Location = new System.Drawing.Point(218, 21);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(112, 28);
            this.label_Titulo.TabIndex = 1;
            this.label_Titulo.Text = "Clinica Frba";
            this.label_Titulo.Click += new System.EventHandler(this.label_Titulo_Click);
            // 
            // button_afiliados
            // 
            this.button_afiliados.Location = new System.Drawing.Point(145, 72);
            this.button_afiliados.Name = "button_afiliados";
            this.button_afiliados.Size = new System.Drawing.Size(75, 23);
            this.button_afiliados.TabIndex = 2;
            this.button_afiliados.Text = "Afiliados";
            this.button_afiliados.UseVisualStyleBackColor = true;
            this.button_afiliados.Visible = false;
            this.button_afiliados.Click += new System.EventHandler(this.button_afiliados_Click);
            // 
            // button_especialidades
            // 
            this.button_especialidades.Location = new System.Drawing.Point(35, 101);
            this.button_especialidades.Name = "button_especialidades";
            this.button_especialidades.Size = new System.Drawing.Size(87, 23);
            this.button_especialidades.TabIndex = 3;
            this.button_especialidades.Text = "Especialidades";
            this.button_especialidades.UseVisualStyleBackColor = true;
            this.button_especialidades.Visible = false;
            this.button_especialidades.Click += new System.EventHandler(this.button_especialidades_Click);
            // 
            // button_planes
            // 
            this.button_planes.Location = new System.Drawing.Point(145, 100);
            this.button_planes.Name = "button_planes";
            this.button_planes.Size = new System.Drawing.Size(75, 23);
            this.button_planes.TabIndex = 4;
            this.button_planes.Text = "Planes";
            this.button_planes.UseVisualStyleBackColor = true;
            this.button_planes.Visible = false;
            this.button_planes.Click += new System.EventHandler(this.button_planes_Click);
            // 
            // button_profesionales
            // 
            this.button_profesionales.Location = new System.Drawing.Point(35, 142);
            this.button_profesionales.Name = "button_profesionales";
            this.button_profesionales.Size = new System.Drawing.Size(87, 23);
            this.button_profesionales.TabIndex = 5;
            this.button_profesionales.Text = "Profesionales";
            this.button_profesionales.UseVisualStyleBackColor = true;
            this.button_profesionales.Visible = false;
            this.button_profesionales.Click += new System.EventHandler(this.button_profesionales_Click);
            // 
            // button_cancelar
            // 
            this.button_cancelar.Location = new System.Drawing.Point(145, 141);
            this.button_cancelar.Name = "button_cancelar";
            this.button_cancelar.Size = new System.Drawing.Size(120, 23);
            this.button_cancelar.TabIndex = 6;
            this.button_cancelar.Text = "Cancelar Atencion";
            this.button_cancelar.UseVisualStyleBackColor = true;
            this.button_cancelar.Visible = false;
            this.button_cancelar.Click += new System.EventHandler(this.button_cancelar_Click);
            // 
            // button_compraBonos
            // 
            this.button_compraBonos.Location = new System.Drawing.Point(35, 185);
            this.button_compraBonos.Name = "button_compraBonos";
            this.button_compraBonos.Size = new System.Drawing.Size(104, 23);
            this.button_compraBonos.TabIndex = 7;
            this.button_compraBonos.Text = "Compra Bonos";
            this.button_compraBonos.UseVisualStyleBackColor = true;
            this.button_compraBonos.Visible = false;
            this.button_compraBonos.Click += new System.EventHandler(this.button_compraBonos_Click);
            // 
            // button_receta
            // 
            this.button_receta.Location = new System.Drawing.Point(145, 184);
            this.button_receta.Name = "button_receta";
            this.button_receta.Size = new System.Drawing.Size(105, 23);
            this.button_receta.TabIndex = 8;
            this.button_receta.Text = "Generar Receta";
            this.button_receta.UseVisualStyleBackColor = true;
            this.button_receta.Visible = false;
            this.button_receta.Click += new System.EventHandler(this.button_receta_Click);
            // 
            // button_estadisticas
            // 
            this.button_estadisticas.Location = new System.Drawing.Point(35, 214);
            this.button_estadisticas.Name = "button_estadisticas";
            this.button_estadisticas.Size = new System.Drawing.Size(75, 23);
            this.button_estadisticas.TabIndex = 9;
            this.button_estadisticas.Text = "Estadisticas";
            this.button_estadisticas.UseVisualStyleBackColor = true;
            this.button_estadisticas.Visible = false;
            this.button_estadisticas.Click += new System.EventHandler(this.button_estadisticas_Click);
            // 
            // button_turno
            // 
            this.button_turno.Location = new System.Drawing.Point(145, 213);
            this.button_turno.Name = "button_turno";
            this.button_turno.Size = new System.Drawing.Size(75, 23);
            this.button_turno.TabIndex = 10;
            this.button_turno.Text = "Pedir Turno";
            this.button_turno.UseVisualStyleBackColor = true;
            this.button_turno.Visible = false;
            this.button_turno.Click += new System.EventHandler(this.button_turno_Click);
            // 
            // button_agenda
            // 
            this.button_agenda.Location = new System.Drawing.Point(271, 71);
            this.button_agenda.Name = "button_agenda";
            this.button_agenda.Size = new System.Drawing.Size(111, 23);
            this.button_agenda.TabIndex = 11;
            this.button_agenda.Text = "Registrar Agenda";
            this.button_agenda.UseVisualStyleBackColor = true;
            this.button_agenda.Visible = false;
            this.button_agenda.Click += new System.EventHandler(this.button_agenda_Click);
            // 
            // button_llegada
            // 
            this.button_llegada.Location = new System.Drawing.Point(271, 101);
            this.button_llegada.Name = "button_llegada";
            this.button_llegada.Size = new System.Drawing.Size(111, 23);
            this.button_llegada.TabIndex = 12;
            this.button_llegada.Text = "Registro LLegada";
            this.button_llegada.UseVisualStyleBackColor = true;
            this.button_llegada.Visible = false;
            this.button_llegada.Click += new System.EventHandler(this.button_llegada_Click);
            // 
            // button_atencion
            // 
            this.button_atencion.Location = new System.Drawing.Point(271, 140);
            this.button_atencion.Name = "button_atencion";
            this.button_atencion.Size = new System.Drawing.Size(111, 23);
            this.button_atencion.TabIndex = 13;
            this.button_atencion.Text = "Registro Atencion";
            this.button_atencion.UseVisualStyleBackColor = true;
            this.button_atencion.Visible = false;
            this.button_atencion.Click += new System.EventHandler(this.button_atencion_Click);
            // 
            // button_usuario
            // 
            this.button_usuario.Location = new System.Drawing.Point(271, 183);
            this.button_usuario.Name = "button_usuario";
            this.button_usuario.Size = new System.Drawing.Size(111, 23);
            this.button_usuario.TabIndex = 14;
            this.button_usuario.Text = "Registro de Usuario";
            this.button_usuario.UseVisualStyleBackColor = true;
            this.button_usuario.Visible = false;
            this.button_usuario.Click += new System.EventHandler(this.button_usuario_Click);
            // 
            // PrincipalWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 566);
            this.Controls.Add(this.button_usuario);
            this.Controls.Add(this.button_atencion);
            this.Controls.Add(this.button_llegada);
            this.Controls.Add(this.button_agenda);
            this.Controls.Add(this.button_turno);
            this.Controls.Add(this.button_estadisticas);
            this.Controls.Add(this.button_receta);
            this.Controls.Add(this.button_compraBonos);
            this.Controls.Add(this.button_cancelar);
            this.Controls.Add(this.button_profesionales);
            this.Controls.Add(this.button_planes);
            this.Controls.Add(this.button_especialidades);
            this.Controls.Add(this.button_afiliados);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.button_roles);
            this.Name = "PrincipalWindow";
            this.Text = "Clinica Frba";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_roles;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Button button_afiliados;
        private System.Windows.Forms.Button button_especialidades;
        private System.Windows.Forms.Button button_planes;
        private System.Windows.Forms.Button button_profesionales;
        private System.Windows.Forms.Button button_cancelar;
        private System.Windows.Forms.Button button_compraBonos;
        private System.Windows.Forms.Button button_receta;
        private System.Windows.Forms.Button button_estadisticas;
        private System.Windows.Forms.Button button_turno;
        private System.Windows.Forms.Button button_agenda;
        private System.Windows.Forms.Button button_llegada;
        private System.Windows.Forms.Button button_atencion;
        private System.Windows.Forms.Button button_usuario;
    }
}

