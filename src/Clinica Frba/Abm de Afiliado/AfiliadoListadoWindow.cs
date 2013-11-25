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

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            String filters = "";
            filters += " AFIL_NOMBRE like '%" + txtNombre.Text + "%'";
            filters += " AND ";
            filters += "AFIL_APELLIDO like '%" + txtApellido.Text + "%'";
            filters += " AND ";
            if (chkInactivos.Checked)
                filters += "AFIL_ACTIVO = 0";
            else
                filters += "AFIL_ACTIVO = 1";

            dtgAfiliados.DataSource = DAOAfiliadoNew.select(filters);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dtgAfiliados.DataSource = null;
            foreach (Control t in groupBox1.Controls)
            {
                if (t is TextBox)
                    t.Text = "";
            }
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
                    (bool)true,
                    (string)selectedRow.Cells["Nombre"].Value,
                    (string)selectedRow.Cells["Apellido"].Value,
                    (int)selectedRow.Cells["Dni"].Value,
                    (string)selectedRow.Cells["Direccion"].Value,
                    (string)selectedRow.Cells["Email"].Value,
                    (DateTime)selectedRow.Cells["Fecha Nacimiento"].Value,
                    (Decimal)selectedRow.Cells["Telefono"].Value,
                    selectedRow.Cells["Estado Civil"].Value.ToString(),
                    (int)selectedRow.Cells["Cant Familiares"].Value);
                new Abm_de_Afiliado.Afiliado(afiliado).ShowDialog(this);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            new Abm_de_Afiliado.Afiliado(new DAOAfiliadoNew()).ShowDialog(this);
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            if (dtgAfiliados.SelectedRows.GetEnumerator().MoveNext())
                DAOAfiliado.baja((int)dtgAfiliados.SelectedRows[0].Cells["Numero"].Value);
        }

    }
}
