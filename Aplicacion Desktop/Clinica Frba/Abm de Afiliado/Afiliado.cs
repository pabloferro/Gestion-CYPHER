using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Abm_de_Afiliado
{
    public partial class Afiliado : Form
    {
        public DAOAfiliadoNew afiliado;

        public Afiliado(DAOAfiliado afiliado)
        {
            this.afiliado = afiliado;
            InitializeComponent();
            txtNombre.Text = afiliado.nombre;
            txtNombre.Enabled = false;
            txtApellido.Text = afiliado.apellido;
            txtApellido.Enabled = false;
            txtDni.Text = afiliado.dni.ToString();
            txtDni.Enabled = false;
            txtPlan.Text = afiliado.plan.ToString();
            txtEmail.Text = afiliado.email;
            txtDireccion.Text = afiliado.direccion;
            txtTelefono.Text = afiliado.telefono.ToString();
            dtpFechaNacimiento.Value = afiliado.fechaNacimiento;
            dtpFechaNacimiento.Enabled = false;
        }

        public Afiliado(DAOAfiliadoNew afiliado)
        {
            this.afiliado = afiliado;
            InitializeComponent();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtPlan.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Afiliado_Load(object sender, EventArgs e)
        {

        }

        public DAOAfiliadoNew getAfiliado()
        {
            return afiliado;
        }

        private void txtPlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dtpFechaNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            afiliado.nombre = txtNombre.Text;
            afiliado.apellido = txtApellido.Text;
            afiliado.dni = txtDni.DecimalValue;
            afiliado.plan = txtPlan.DecimalValue;
            afiliado.email = txtEmail.Text;
            afiliado.direccion = txtDireccion.Text;
            afiliado.telefono = txtTelefono.DecimalValue;
            afiliado.fechaNacimiento = dtpFechaNacimiento.Value;
            afiliado.save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
