using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;
using Clinica_Frba;

namespace Clinica_Frba.Login
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }

        private void login()
        {
            String usuario = textBox_usuario.Text;
            String pass = textBox_password.Text;


            if (!DAOUser.CorrectLogin(usuario, pass)) label_error.Text = "Login Incorrecto";
            else
            {
                this.Hide();
                new PrincipalWindow(usuario, 1).ShowDialog();
                this.Close();
            }
        }

        private void label_error_Click(object sender, EventArgs e)
        {

        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_usuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                login();
        }
    }
}
