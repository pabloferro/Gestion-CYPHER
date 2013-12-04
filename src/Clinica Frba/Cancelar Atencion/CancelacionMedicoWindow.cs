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
    public partial class CancelacionMedicoWindow : Form
    {
        public CancelacionMedicoWindow()
        {
            InitializeComponent();
        }

        private void rdbRango_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbRango.Checked)
            {
                lblFecha.Text = "Fecha Inicial";
            }
            dtpFechaFinal.Visible = rdbRango.Checked;
            lblFechaFinal.Visible = rdbRango.Checked;
        }

        private void rdbUnica_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbUnica.Checked)
            {
                lblFecha.Text = "Fecha";
            }
        }

        private void CancelacionMedicoWindow_Load(object sender, EventArgs e)
        {
            dtpFecha.MaxDate = SqlConnector.fecha.AddDays(-1);
            dtpFecha.Value = dtpFecha.MaxDate;
            dtpFechaFinal.MinDate = dtpFecha.Value;
            //dtpFechaFinal.MaxDate = SqlConnector.fecha.AddDays(-1);
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            dtpFechaFinal.MinDate = dtpFecha.Value;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            string motivo = "";
            InputBox.Show("Cancelación", "Motivo:", ref motivo);
            if (rdbRango.Checked)
                DAOAgenda.cancelarTurnos(txtNroMedico.IntValue, dtpFecha.Value, dtpFechaFinal.Value, motivo);
            else
                DAOAgenda.cancelarTurnos(txtNroMedico.IntValue, dtpFecha.Value, dtpFecha.Value, motivo);
            MessageBox.Show("Turnos cancelados");
        }

        private void dtpFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaFinal.Value > SqlConnector.fecha.AddDays(-1))
                MessageBox.Show("Seleccionó una fecha de hoy o posterior. " +
                                "Se cancelarán SOLO los turnos que tengan un día de antelación. " +
                                "Se respetará el rango para la cancelación de la Agenda", "Atención");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
