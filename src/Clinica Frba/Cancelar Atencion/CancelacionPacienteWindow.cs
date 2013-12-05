using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;
using Clinica_Frba.Varios;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class CancelacionPacienteWindow : Form
    {
        public CancelacionPacienteWindow()
        {
            InitializeComponent();
        }

        private void CancelacionPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtNroAfiliado.Text == "" || !DAOAfiliado.afiliadoValido(txtNroAfiliado.IntValue))
                MessageBox.Show("Afiliado inválido");
            else
            {
                dtgTurnos.DataSource = DAOAfiliado.turnosAsignados(txtNroAfiliado.IntValue);
                dtgTurnos.Columns["Código"].Visible = false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (dtgTurnos.SelectedRows.GetEnumerator().MoveNext())
            {
                DataGridViewRow selectedRowF = dtgTurnos.SelectedRows[0];
                if (selectedRowF.Cells["Código"].Value != null)
                {
                    string motivo = "";
                    InputBox.Show("Cancelación", "Motivo:", ref motivo);
                    DAOAfiliado.cancelarTurno((int)selectedRowF.Cells["Código"].Value, motivo);
                    MessageBox.Show("Turno Cancelado");
                    this.Close();
                }
            }else
                MessageBox.Show("Debe seleccionar un turno");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
