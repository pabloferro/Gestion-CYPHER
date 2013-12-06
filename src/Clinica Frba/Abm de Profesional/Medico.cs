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
            DAOEspecialidad.llenarCombo(lstEspecialidades);
            llenarEspecialidades(DAOEspecialidad.getEspecialidadesMedico(medico.codigo));
        }

         public Medico(DAOMedicoNew medico)
        {

            this.medico = medico;
            InitializeComponent();
            DAOEspecialidad.llenarCombo(lstEspecialidades);
            DAODocumento.llenarCombo(cmbTipoDocumento);
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
            DAOEspecialidad.llenarCombo(lstEspecialidades);
            DAODocumento.llenarCombo(cmbTipoDocumento);
        }

        private void llenarEspecialidades(DataTable table)
        {
            foreach (DataRow row in table.Rows)
            {
                int i = lstEspecialidades.Items.IndexOf((string)row["ESP_DESC"]);
                if(i>=0)
                    lstEspecialidades.SetItemChecked(i, true);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || txtApellido.Text == "" || txtNroDocumento.Text == "" ||
                txtDireccion.Text == "" || txtTelefono.Text == "" || txtMatricula.Text == "")
                MessageBox.Show("Todos los campos son obligatorios", "Error");
            else
            {
                medico.nombre = txtNombre.Text;
                medico.apellido = txtApellido.Text;
                medico.tipoDocumento = DAODocumento.codigo(cmbTipoDocumento.Text);
                medico.documento = txtNroDocumento.DecimalValue;
                medico.matricula = txtMatricula.IntValue;
                medico.email = txtEmail.Text;
                medico.direccion = txtDireccion.Text;
                medico.telefono = txtTelefono.DecimalValue;
                medico.fechaNacimiento = dtpFechaNacimiento.Value;
                if (rdbF.Checked)
                    medico.sexo = 'F';
                else
                    medico.sexo = 'M';
                for (int i = 0; i < lstEspecialidades.Items.Count; i++)
                {
                    CheckState st = lstEspecialidades.GetItemCheckState(i);
                    if (st == CheckState.Checked)
                        medico.addEspecialidad(DAOEspecialidad.codigo(lstEspecialidades.Items[i].ToString()));
                    else
                        medico.removeEspecialidad(DAOEspecialidad.codigo(lstEspecialidades.Items[i].ToString()));
                }

                if (DAODocumento.medicoDocumentoValido(medico.codigo ,medico.tipoDocumento, medico.documento))
                {
                    medico.save();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ya hay un médico con ese tipo y número de documento");
                }
            }
        }
    }
}
