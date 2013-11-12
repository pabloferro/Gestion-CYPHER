using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Login
{
    public partial class LoginRolWindow : Form
    {
        string usuario;
        DataTable data;
        public LoginRolWindow(string us)
        {
            usuario = us;
            data = DAO.DAOUser.getRoles(usuario);
            InitializeComponent();
        }

        private void LoginRolWindow_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < data.Rows.Count; i++)
                comboRoles.Items.Add(data.Rows[i][0]);   
        }

        private void comboRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            int rol = 0;
            this.Hide();
            for (int i = 0; i < data.Rows.Count; i++)
                if (data.Rows[i][0] == comboRoles.SelectedItem)
                {
                    rol=(int)data.Rows[i][1];
                    break;
                }
            new PrincipalWindow(usuario,rol).ShowDialog();
            this.Close();
        }
    }
}
