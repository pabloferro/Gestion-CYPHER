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
                    case 1: menuStrip1.Items.Add("1)Roles"); break;
                    case 2: menuStrip1.Items.Add("3)Usuarios").Enabled = false; break;
                    case 3: menuStrip1.Items.Add("4)Afiliados"); break;
                    case 4: menuStrip1.Items.Add("5)Profesionales"); break;
                    case 5: menuStrip1.Items.Add("6)Especialidades").Enabled = false; break;
                    case 6: menuStrip1.Items.Add("7)Planes").Enabled = false; break;
                    case 7: menuStrip1.Items.Add("8)Agenda"); break;
                    case 8: menuStrip1.Items.Add("9)Compra Bonos"); break;
                    case 9: menuStrip1.Items.Add("10)Pedido de Turno"); break;
                    case 10: menuStrip1.Items.Add("11)Registro de Llegada"); break;
                    case 11: menuStrip1.Items.Add("12)Atencion"); break;
                    case 12: menuStrip1.Items.Add("13)Cancelar Turnos"); break;
                    case 13: menuStrip1.Items.Add("14)Generar Recetas"); break;
                    case 14: menuStrip1.Items.Add("15)Estadisticas"); break;
                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String funcionalidad=e.ClickedItem.Text;

            switch(funcionalidad)
            {
                case "1)Roles": new Abm_de_Rol.RolWindow().ShowDialog(); break;
                case "4)Afiliados": new Abm_de_afiliado.AfiliadoListadoWindow().ShowDialog(); break;
                case "5)Profesionales": new Abm_de_Profesional.ProfesionalListadoWindow().ShowDialog(); break;
                case "6)Especialidades": new Abm_de_Especialidades_Medicas.EspecialidadesWindow().ShowDialog(); break;
                case "7)Planes": new Abm_de_Planes.PlanesWindow().ShowDialog(); break;
                case "8)Agenda": new Registrar_Agenda.RegistroAgendaWindow().ShowDialog(); break;
                case "9)Compra Bonos":new Compra_De_Bono.CompraBonosWindow().ShowDialog(); break;
                case "10)Pedido de Turno" :new Pedir_Turno.PedirTurnoWindow().ShowDialog();break;
                case "11)Registro de Llegada": new Registro_de_llegada.RegistroLlegadaWindow().ShowDialog(); break;
                case "12)Atencion": new Registro_Resultado_Atencion.RegistroAtencionWindow().ShowDialog(); break;
                case "13)Cancelar Turnos": new Cancelar_Atencion.CancelacionWindow().ShowDialog(); break;
                case "14)Generar Recetas": new Generar_Receta.GenerarRecetaWindow().ShowDialog(); break;
                case "15)Estadisticas": new Listados_Entadisticos.EstadisticasWindow().ShowDialog(); break;
            }
        }

    }
}
