using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Abm_de_afiliado
{
    public partial class AfiliadoListadoWindow : Form
    {
        public AfiliadoListadoWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAOPlan.llenarCombo(cmbPlan);
            cmbPlan.Items.Add("TODOS");
            cmbPlan.Text = "TODOS";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String filters = "";
            filters += " AFIL_NOMBRE like '%" + txtNombre.Text + "%'";
            filters += " AND ";
            filters += "AFIL_APELLIDO like '%" + txtApellido.Text + "%'";
            filters += " AND ";
            filters += "AFIL_MAIL like '%" + txtEmail.Text + "%'";
            filters += " AND ";
            if (chkInactivos.Checked)
                filters += "AFIL_ACTIVO = 0";
            else
                filters += "AFIL_ACTIVO = 1";
            if (cmbPlan.Text != "TODOS")
            {
                filters += " AND ";
                filters += "AFIL_PLAN = " + cmbPlan.Text;
            }
            if (txtNroDocumento.Text != "")
            {
                filters += " AND ";
                filters += "AFIL_DOCUMENTO = " + txtNroDocumento.Text;
            }
            if (txtTelefono.Text != "")
            {
                filters += " AND ";
                filters += "AFIL_TELEFONO = " + txtTelefono.Text;
            }

            dtgAfiliados.DataSource = DAOAfiliadoNew.select(filters);
            dtgAfiliados.Columns["A"].Visible = false;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgAfiliados.DataSource = null;
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                    t.Text = "";
            }
            cmbPlan.Text = "TODOS";
            chkInactivos.Checked = false;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dtgAfiliados.SelectedRows.GetEnumerator().MoveNext())
            {
                DataGridViewRow selectedRow = dtgAfiliados.SelectedRows[0];
                DAOAfiliado afiliado = new DAOAfiliado(
                    (int)selectedRow.Cells["Numero"].Value,
                    (int)selectedRow.Cells["Plan"].Value,
                    (bool)selectedRow.Cells["A"].Value,
                    (string)selectedRow.Cells["Nombre"].Value,
                    (string)selectedRow.Cells["Apellido"].Value,
                    DAODocumento.codigo(selectedRow.Cells["Tipo Doc"].Value.ToString()),
                    (int)selectedRow.Cells["Nro Doc"].Value,
                    (string)selectedRow.Cells["Direccion"].Value,
                    (string)selectedRow.Cells["Email"].Value,
                    (DateTime)selectedRow.Cells["Fecha Nacimiento"].Value,
                    (Decimal)selectedRow.Cells["Telefono"].Value,
                    selectedRow.Cells["Estado Civil"].Value.ToString(),
                    (int)selectedRow.Cells["Cant Familiares"].Value,
                    (char)selectedRow.Cells["Sexo"].Value.ToString().ToCharArray()[0]);
                new Abm_de_Afiliado.Afiliado(afiliado).ShowDialog(this);
            }
            else
                MessageBox.Show("Seleccione un afiliado");
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            new Abm_de_Afiliado.Afiliado(new DAOAfiliadoNew()).ShowDialog(this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dtgAfiliados.SelectedRows.GetEnumerator().MoveNext())
            {
                DAOAfiliado.baja((int)dtgAfiliados.SelectedRows[0].Cells["Numero"].Value);
                MessageBox.Show("Afiliado dado de baja");
            }
            else
                MessageBox.Show("Seleccione un afiliado");
        }
    }
}
