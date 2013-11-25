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
            txtPlan.Items.Clear();
            DataTable planes = DAOPlan.getPlanes();
            foreach (DataRow row in planes.Rows)
            {
                txtPlan.Items.Add(row["PLAN_CODIGO"]);
            }
            txtPlan.Text = afiliado.plan.ToString();
            txtEmail.Text = afiliado.email;
            txtDireccion.Text = afiliado.direccion;
            txtTelefono.Text = afiliado.telefono.ToString();
            dtpFechaNacimiento.Value = afiliado.fechaNacimiento;
            dtpFechaNacimiento.Enabled = false;
            txtEstadoCivil.Text = afiliado.estadoCivil;
            txtEstadoCivil.Enabled = false;
            txtCantFamiliares.Text = afiliado.cantFamiliares.ToString();
            txtCantFamiliares.Enabled = false;
        }

        public Afiliado(DAOAfiliadoNew afiliado)
        {
            this.afiliado = afiliado;
            InitializeComponent();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtPlan.Items.Clear();
            DataTable planes = DAOPlan.getPlanes();
            foreach (DataRow row in planes.Rows)
            {
                txtPlan.Items.Add(row["PLAN_CODIGO"]);
            }
            txtPlan.Text = txtPlan.Items[0].ToString();
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtEstadoCivil.Text = "Soltero/a";
            txtCantFamiliares.Text = "0";
        }

        public DAOAfiliadoNew getAfiliado()
        {
            return afiliado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            afiliado.nombre = txtNombre.Text;
            afiliado.apellido = txtApellido.Text;
            afiliado.dni = txtDni.DecimalValue;
            afiliado.plan = Decimal.Parse(txtPlan.Text);
            afiliado.email = txtEmail.Text;
            afiliado.direccion = txtDireccion.Text;
            afiliado.telefono = txtTelefono.DecimalValue;
            afiliado.fechaNacimiento = dtpFechaNacimiento.Value;
            afiliado.cantFamiliares = txtCantFamiliares.IntValue;
            afiliado.estadoCivil = txtEstadoCivil.Text;
            afiliado.save();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Afiliado_Load(object sender, EventArgs e)
        {

        }
    }
}
