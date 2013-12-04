using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Pedir_Turno
{
    public partial class PedirTurnoWindow : Form
    {
        public PedirTurnoWindow()
        {
            InitializeComponent();
        }

        private void btnVerFechas_Click(object sender, EventArgs e)
        {
            int nroMedico = txtNumero.IntValue;
            dtgFechas.DataSource = DAOAgenda.fechasTurnos(nroMedico);
        }

        private void dtgFechas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PedirTurnoWindow_Load(object sender, EventArgs e)
        {

        }

        private void dtgFechas_SelectionChanged(object sender, EventArgs e)
        {
            if (dtgFechas.SelectedRows.GetEnumerator().MoveNext())
            {
                DataGridViewRow selectedRow = dtgFechas.SelectedRows[0];
                if (selectedRow.Cells["Fecha"].Value != null)
                {
                    dtgTurnos.DataSource =
                        DAOAgenda.turnosPorFecha(txtNumero.IntValue, (DateTime)selectedRow.Cells["Fecha"].Value);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dtgFechas.SelectedRows.GetEnumerator().MoveNext())
            {
                DataGridViewRow selectedRowF = dtgFechas.SelectedRows[0];
                if (selectedRowF.Cells["Fecha"].Value != null)
                {
                    if (dtgTurnos.SelectedRows.GetEnumerator().MoveNext())
                    {
                        DataGridViewRow selectedRowT = dtgTurnos.SelectedRows[0];
                        if (selectedRowT.Cells["Desde"].Value != null)
                        {
                            DAOAgenda.pedirTurno(txtNumero.IntValue, txtNroAfiliado.IntValue,
                                (DateTime)selectedRowF.Cells["Fecha"].Value,
                                (TimeSpan)selectedRowT.Cells["Desde"].Value);
                            MessageBox.Show("Turno registrado");
                            this.Close();
                        }
                    }
                }
            }else
                MessageBox.Show("Debe seleccionar un turno");
        }
    }
}
