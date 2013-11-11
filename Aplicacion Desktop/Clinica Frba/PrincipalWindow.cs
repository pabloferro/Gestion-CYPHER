using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba
{
    public partial class PrincipalWindow : Form
    {
        private string usuario;
        private int rol;
        public PrincipalWindow(string newUsuario, int newRol)
        {
            usuario = newUsuario;
            rol = newRol;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable funcionalidades=DAOUser.getFuncionalidades(usuario, rol);
            
            for (int i = 0; i < funcionalidades.Rows.Count; i++)
            {
                switch (funcionalidades.Rows[i].Field<int>(0))
                {
                    case 1: button_roles.Visible = true; break;
                    case 2: button_usuario.Visible = true; break;
                    case 3: button_afiliados.Visible = true; break;
                    case 4: button_profesionales.Visible = true; break;
                    case 5: button_especialidades.Visible = true; break;
                    case 6: button_planes.Visible = true; break;
                    case 7: button_agenda.Visible = true; break;
                    case 8: button_compraBonos.Visible = true; break;
                    case 9: button_turno.Visible = true; break;
                    case 10: button_llegada.Visible = true; break;
                    case 11: button_atencion.Visible = true; break;
                    case 12: button_cancelar.Visible = true; break;
                    case 13: button_receta.Visible = true; break;
                    case 14: button_estadisticas.Visible = true; break;
                }
                    
            }

        }
        private void label_Titulo_Click(object sender, EventArgs e)
        {

        }

        private void button_roles_Click(object sender, EventArgs e)
        {
            new Abm_de_Rol.RolWindow().ShowDialog();
        }

        private void button_atencion_Click(object sender, EventArgs e)
        {
            new Registro_Resultado_Atencion.RegistroAtencionWindow().ShowDialog();
        }

        private void button_afiliados_Click(object sender, EventArgs e)
        {
            new Abm_de_afiliado.AfiliadoListadoWindow().ShowDialog();
        }

        private void button_agenda_Click(object sender, EventArgs e)
        {
            new Registrar_Agenda.RegistroAgendaWindow().ShowDialog();
        }

        private void button_especialidades_Click(object sender, EventArgs e)
        {
            new Abm_de_Especialidades_Medicas.EspecialidadesWindow().ShowDialog();
        }

        private void button_planes_Click(object sender, EventArgs e)
        {
            new Abm_de_Planes.PlanesWindow().ShowDialog();
        }

        private void button_llegada_Click(object sender, EventArgs e)
        {
            new Registro_de_llegada.RegistroLlegadaWindow().ShowDialog();
        }

        private void button_profesionales_Click(object sender, EventArgs e)
        {
            new Abm_de_Profesional.ProfesionalWindow().ShowDialog();
        }

        private void button_cancelar_Click(object sender, EventArgs e)
        {
            new Cancelar_Atencion.CancelacionWindow().ShowDialog();
        }

        private void button_compraBonos_Click(object sender, EventArgs e)
        {
            new Compra_De_Bono.CompraBonosWindow().ShowDialog();
        }

        private void button_receta_Click(object sender, EventArgs e)
        {
            new Generar_Receta.GenerarRecetaWindow().ShowDialog();
        }

        private void button_usuario_Click(object sender, EventArgs e)
        {
            new Registro_de_Usuario.RegistroUsuarioWindow().ShowDialog();
        }

        private void button_estadisticas_Click(object sender, EventArgs e)
        {
            new Listados_Entadisticos.EstadisticasWindow().ShowDialog();
        }

        private void button_turno_Click(object sender, EventArgs e)
        {
            new Pedir_Turno.PedirTurnoWindow().ShowDialog();
        }

    }
}
