using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Varios
{
    public partial class BuscarMedicoWindow : Form
    {
        ConMedico medico;

        public BuscarMedicoWindow()
        {
            InitializeComponent();
        }

        public BuscarMedicoWindow(ConMedico _medico)
        {
            medico = _medico;
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String filters = "";
            filters += " MED_NOMBRE like '%" + txtNombre.Text + "%'";
            filters += " AND ";
            filters += "MED_APELLIDO like '%" + txtApellido.Text + "%'";
            filters += " AND MED_ACTIVO = 1";
            if (cmbEspecialidad.Text != "TODAS")
            {
                filters += " AND ";
                filters += "EXISTS (SELECT * FROM CIPHER.ESPECIALIDAD_POR_MEDICO WHERE ESPMED_MEDICO = MED_CODIGO AND ESPMED_ESP = "
                           + DAOEspecialidad.codigo(cmbEspecialidad.Text).ToString() + ")";
            }
            dtgMedicos.DataSource = DAOBusquedaMedico.select(filters);
            dtgMedicos.Columns["Código"].Visible = false;
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
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (dtgMedicos.SelectedRows.GetEnumerator().MoveNext())
            {
                DataGridViewRow selectedRowF = dtgMedicos.SelectedRows[0];
                if (selectedRowF.Cells["Código"].Value != null)
                {
                    medico.setMedico((int)selectedRowF.Cells["Código"].Value);
                    this.Close();
                }
            }
        }

        private void BuscarMedicoWindow_Load(object sender, EventArgs e)
        {
            DAOEspecialidad.llenarCombo(cmbEspecialidad);
            cmbEspecialidad.Items.Add("TODAS");
            cmbEspecialidad.Text = "TODAS";
        }
    }
}
