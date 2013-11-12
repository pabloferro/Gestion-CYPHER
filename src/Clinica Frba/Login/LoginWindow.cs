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
using System.Security.Cryptography;

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

        static string sha256(string password)
        {
            SHA256Managed crypt = new SHA256Managed();
            string hash = String.Empty;
            byte[] crypto = crypt.ComputeHash(Encoding.UTF8.GetBytes(password), 0, Encoding.UTF8.GetByteCount(password));
            foreach (byte bit in crypto)
            {
                hash += bit.ToString("x2");
            }
            return hash;
        }

        private void login()
        {
            String usuario = textBox_usuario.Text;
            String pass = sha256(textBox_password.Text);

            
            if (DAOUser.CorrectLogin(usuario, pass)==0) label_error.Text = "Login Incorrecto";
            else if (DAOUser.CorrectLogin(usuario, pass)==-1) label_error.Text = "Usuario Desabilitado";
            else
            {
                this.Hide();
                new LoginRolWindow(usuario).ShowDialog();
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
