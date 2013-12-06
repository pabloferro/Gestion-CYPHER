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
    public partial class ProfesionalListadoWindow : Form
    {
        public ProfesionalListadoWindow()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String filters = "";
            filters += " MED_NOMBRE like '%" + txtNombre.Text + "%'";
            filters += " AND ";
            filters += "MED_APELLIDO like '%" + txtApellido.Text + "%'";
            filters += " AND ";
            filters += "MED_MAIL like '%" + txtEmail.Text + "%'";
            filters += " AND ";
            if (chkInactivos.Checked)
                filters += "MED_ACTIVO = 0";
            else
                filters += "MED_ACTIVO = 1";
            if (cmbEspecialidad.Text != "TODAS")
            {
                filters += " AND ";
                filters += "EXISTS (SELECT * FROM CIPHER.ESPECIALIDAD_POR_MEDICO WHERE ESPMED_MEDICO = MED_CODIGO AND ESPMED_ESP = " 
                           + DAOEspecialidad.codigo(cmbEspecialidad.Text).ToString() +")" ;
            }

            if (txtNroDocumento.Text != "")
            {
                filters += " AND ";
                filters += "MED_DOCUMENTO = " + txtNroDocumento.Text;
            }
            if (txtTelefono.Text != "")
            {
                filters += " AND ";
                filters += "MED_TELEFONO = " + txtTelefono.Text;
            }            
            
            dtgMedicos.DataSource = DAOMedicoNew.select(filters);
            dtgMedicos.Columns["A"].Visible = false;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {

        }

        private void ProfesionalListadoWindow_Load(object sender, EventArgs e)
        {
            DAOEspecialidad.llenarCombo(cmbEspecialidad);
            cmbEspecialidad.Items.Add("TODAS");
            cmbEspecialidad.Text = "TODAS";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgMedicos.DataSource = null;
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                    t.Text = "";
            }
            cmbEspecialidad.Text = "TODAS";
            chkInactivos.Checked = false;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            new Abm_de_Profesional.Medico(new DAOMedicoNew()).ShowDialog(this);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgMedicos.SelectedRows.GetEnumerator().MoveNext())
            {
                DataGridViewRow selectedRow = dtgMedicos.SelectedRows[0];
                int matricula;
                if (selectedRow.Cells["Matricula"].Value == DBNull.Value)
                    matricula = 0;
                else
                    matricula = (int)selectedRow.Cells["Matricula"].Value;

                DAOMedico medico = new DAOMedico(
                    (int)selectedRow.Cells["Código"].Value,
                    matricula,
                    (bool)selectedRow.Cells["A"].Value,
                    (string)selectedRow.Cells["Nombre"].Value,
                    (string)selectedRow.Cells["Apellido"].Value,
                    DAODocumento.codigo(selectedRow.Cells["Tipo Doc"].Value.ToString()),
                    (int)selectedRow.Cells["Nro Doc"].Value,
                    (string)selectedRow.Cells["Direccion"].Value,
                    (string)selectedRow.Cells["Email"].Value,
                    (DateTime)selectedRow.Cells["Fecha Nacimiento"].Value,
                    (int)selectedRow.Cells["Telefono"].Value,
                    (char)selectedRow.Cells["Sexo"].Value.ToString().ToCharArray()[0]);
                new Abm_de_Profesional.Medico(medico).ShowDialog(this);
            }
            else
                MessageBox.Show("Seleccione un afiliado");
        }
    }
}
