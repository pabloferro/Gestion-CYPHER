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
            DAODocumento.llenarCombo(cmbTipoDocumento);
            cmbTipoDocumento.Text = DAODocumento.nombre(afiliado.tipoDocumento);
            cmbTipoDocumento.Enabled = false;
            txtNroDocumento.Text = afiliado.documento.ToString();
            txtNroDocumento.Enabled = false;
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
            txtCantFamiliares.Text = afiliado.cantFamiliares.ToString();
            txtCantFamiliares.Enabled = false;
            rdbF.Checked = true;
            if (afiliado.sexo == 'X')
            {
                MessageBox.Show("El afiliado actual es migrado, debe completar el estado civil y el sexo.");
                afiliado.sexo = 'F';
                rdbF.Checked = true;
                txtEstadoCivil.Text = txtEstadoCivil.Items[0].ToString();
            }
            else
            {
                rdbF.Checked = afiliado.sexo == 'F';
                rdbM.Checked = afiliado.sexo == 'M';
            }

        }

        public Afiliado(DAOAfiliadoNew afiliado)
        {
            this.afiliado = afiliado;
            InitializeComponent();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNroDocumento.Text = "";
            txtPlan.Items.Clear();
            DAODocumento.llenarCombo(cmbTipoDocumento);
            cmbTipoDocumento.Text = cmbTipoDocumento.Items[0].ToString();
            DAOPlan.llenarCombo(txtPlan);
            txtPlan.Text = txtPlan.Items[0].ToString();
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            txtEstadoCivil.Text = "Soltero/a";
            txtCantFamiliares.Text = "0";
            rdbF.Checked = true;
        }

        public DAOAfiliadoNew getAfiliado()
        {
            return afiliado;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtNroDocumento.Text == "" ||
                txtDireccion.Text == "" || txtTelefono.Text == "" || txtCantFamiliares.Text == "")
                MessageBox.Show("Todos los campos son obligatorios", "Error");
            else
            {
                afiliado.nombre = txtNombre.Text;
                afiliado.apellido = txtApellido.Text;
                afiliado.tipoDocumento = DAODocumento.codigo(cmbTipoDocumento.Text);
                afiliado.documento = txtNroDocumento.DecimalValue;
                afiliado.plan = Decimal.Parse(txtPlan.Text);
                afiliado.email = txtEmail.Text;
                afiliado.direccion = txtDireccion.Text;
                afiliado.telefono = txtTelefono.DecimalValue;
                afiliado.fechaNacimiento = dtpFechaNacimiento.Value;
                afiliado.cantFamiliares = txtCantFamiliares.IntValue;
                afiliado.estadoCivil = txtEstadoCivil.Text;
                if (rdbF.Checked)
                    afiliado.sexo = 'F';
                else
                    afiliado.sexo = 'M';
                if (DAODocumento.afiliadoDocumentoValido(afiliado.nro, afiliado.tipoDocumento, afiliado.documento))
                {
                    afiliado.save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya hay un afiliado con ese tipo y número de documento");
                }
            }
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
