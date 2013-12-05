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
                    case 1: menuStrip1.Items.Add("Roles"); break;
                    case 2: menuStrip1.Items.Add("Usuarios"); break;
                    case 3: menuStrip1.Items.Add("Afiliados"); break;
                    case 4: menuStrip1.Items.Add("Profesionales"); break;
                    case 5: menuStrip1.Items.Add("Especialidades"); break;
                    case 6: menuStrip1.Items.Add("Planes"); break;
                    case 7: menuStrip1.Items.Add("Agenda"); break;
                    case 8: menuStrip1.Items.Add("Compra Bonos"); break;
                    case 9: menuStrip1.Items.Add("Turnos"); break;
                    case 10: menuStrip1.Items.Add("Registro de Llegada"); break;
                    case 11: menuStrip1.Items.Add("Atencion"); break;
                    case 12: menuStrip1.Items.Add("Cancelar Turnos"); break;
                    case 13: menuStrip1.Items.Add("Generar Recetas"); break;
                    case 14: menuStrip1.Items.Add("Estadisticas"); break;
                }
                    
            }

        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            String funcionalidad=e.ClickedItem.Text;

            switch(funcionalidad)
            {
                case "Roles": new Abm_de_Rol.RolWindow().ShowDialog(); break;
                case "Afiliados": new Abm_de_afiliado.AfiliadoListadoWindow().ShowDialog(); break;
                case "Profesionales": new Abm_de_Profesional.ProfesionalWindow().ShowDialog(); break;
                case "Especialidades": new Abm_de_Especialidades_Medicas.EspecialidadesWindow().ShowDialog(); break;
                case "Planes": new Abm_de_Planes.PlanesWindow().ShowDialog(); break;
                case "Agenda": new Registrar_Agenda.RegistroAgendaWindow().ShowDialog(); break;
                case "Compra Bonos":new Compra_De_Bono.CompraBonosWindow().ShowDialog(); break;
                case "Turnos" :new Pedir_Turno.PedirTurnoWindow().ShowDialog();break;
                case "Registro de Llegada": new Registro_de_llegada.RegistroLlegadaWindow().ShowDialog(); break;
                case "Atencion": new Registro_Resultado_Atencion.RegistroAtencionWindow().ShowDialog(); break;
                case "Cancelar Turnos": new Cancelar_Atencion.CancelacionMedicoWindow().ShowDialog(); break;
                case "Generar Recetas": new Generar_Receta.GenerarRecetaWindow().ShowDialog(); break;
                case "Estadisticas": new Listados_Entadisticos.EstadisticasWindow().ShowDialog(); break;

            }
            
        }

    }
}
