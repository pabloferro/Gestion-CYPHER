using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Abm_de_Rol
{
    public partial class RolWindow : Form
    {
        DataGridViewRow selectedRow;
        DAORol rol;

        public RolWindow()
        {
            InitializeComponent();
            dtgRoles.DataSource = DAORol.getRoles();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            selectedRow = dtgRoles.SelectedRows[0];
            if (selectedRow.Cells["CODE"].Value != null)
            {
                grpRoles.Enabled = false;
                txtNombre.Text = selectedRow.Cells["Nombre"].Value.ToString();
                chkHabilitado.Checked = (bool)selectedRow.Cells["HAB"].Value;
                rol = new DAORol(selectedCode());
                llenarFuncionalidades(DAORol.getFuncionalidadesRol(selectedCode()));
            }
        }

        private void llenarFuncionalidades(DataTable table)
        {
            lstFuncionalidades.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                lstFuncionalidades.Items.Add(row["Nombre"], (int)row["HAB"] == 1);
            }
            grpRol.Enabled = true;
        }

        private int selectedCode()
        {
            return (int)selectedRow.Cells["CODE"].Value;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            rol.setNombre(txtNombre.Text);
            rol.setHabilitado(chkHabilitado.Checked);
            for (int i = 0; i < lstFuncionalidades.Items.Count; i++)
            {
                CheckState st = lstFuncionalidades.GetItemCheckState(i);
                if (st == CheckState.Checked)
                    rol.addFuncionalidad(i + 1);
                else
                    rol.removeFuncionalidad(i + 1);
            }
            rol.save();
            clean();
        }

        private void clean()
        {
            grpRol.Enabled = true;
            txtNombre.Text = "";
            lstFuncionalidades.Items.Clear();
            grpRol.Enabled = false;
            dtgRoles.DataSource = DAORol.getRoles();
            grpRoles.Enabled = true;
            rol = null;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            selectedRow = dtgRoles.SelectedRows[0];
            dtgRoles.ClearSelection();
            grpRol.Enabled = true;
            grpRoles.Enabled = false;
            txtNombre.Text = "";
            chkHabilitado.Checked = true;
            rol = new DAORol();
            llenarFuncionalidades(DAORol.getFuncionalidadesNuevo());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clean();
        }

        private void grpRoles_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtgRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
