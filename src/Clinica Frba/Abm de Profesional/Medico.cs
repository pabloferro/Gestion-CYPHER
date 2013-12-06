using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Abm_de_Profesional
{
    public partial class Medico : Form
    {
         public DAOMedicoNew medico;

         public Medico(DAOMedico medico)
         {
            this.medico = medico;
            InitializeComponent();
            txtNombre.Text = medico.nombre;
            txtNombre.Enabled = false;
            txtApellido.Text = medico.apellido;
            txtApellido.Enabled = false;
            DAODocumento.llenarCombo(cmbTipoDocumento);
            cmbTipoDocumento.Text = DAODocumento.nombre(medico.tipoDocumento);
            cmbTipoDocumento.Enabled = false;
            txtNroDocumento.Text = medico.documento.ToString();
            txtNroDocumento.Enabled = false;
            txtMatricula.Text = medico.matricula.ToString();
            txtEmail.Text = medico.email;
            txtDireccion.Text = medico.direccion;
            txtTelefono.Text = medico.telefono.ToString();
            dtpFechaNacimiento.Value = medico.fechaNacimiento;
            dtpFechaNacimiento.Enabled = false;
            if (medico.sexo == 'X')
            {
                MessageBox.Show("El médico actual es migrado, debe completar el sexo y matrícula.");
                medico.sexo = 'F';
                rdbF.Checked = true;
            }
            else
            {
                rdbF.Checked = medico.sexo == 'F';
                rdbM.Checked = medico.sexo == 'M';
            }

        }

         public Medico(DAOMedicoNew medico)
        {
            this.medico = medico;
            InitializeComponent();
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtNroDocumento.Text = "";
            DAODocumento.llenarCombo(cmbTipoDocumento);
            cmbTipoDocumento.Text = cmbTipoDocumento.Items[0].ToString();
            txtMatricula.Text = "";
            txtEmail.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            dtpFechaNacimiento.Value = DateTime.Today;
            rdbF.Checked = true;
        }

        public Medico()
        {
            InitializeComponent();
        }

        private void Medico_Load(object sender, EventArgs e)
        {
            DAOEspecialidad.llenarCombo(lstEspecialidades);
            DAODocumento.llenarCombo(cmbTipoDocumento);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
