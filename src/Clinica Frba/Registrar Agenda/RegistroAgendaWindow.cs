using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Registrar_Agenda
{
    public partial class RegistroAgendaWindow : Form
    {
        DateTimePicker[] desde;
        DateTimePicker[] hasta;
        CheckBox[] habilitado;

        public RegistroAgendaWindow()
        {
            InitializeComponent();
        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFechaInicial.Value > dtpFechaFinal.Value)
                dtpFechaFinal.Value = dtpFechaInicial.Value.AddDays(7);

        }

        private void RegistroAgendaWindow_Load(object sender, EventArgs e)
        {
            dtpFechaInicial.MinDate = SqlConnector.fecha;
            dtpFechaInicial.Value = SqlConnector.fecha;
            dtpFechaFinal.MaxDate = dtpFechaInicial.Value.AddDays(119);
            dtpFechaFinal.MinDate = dtpFechaInicial.Value.AddDays(6);
            dtpFechaFinal.Value = dtpFechaFinal.MinDate;
            desde = new DateTimePicker[6] { dtpDesdeLu, dtpDesdeMa, dtpDesdeMi, dtpDesdeJu, dtpDesdeVi, dtpDesdeSa };
            hasta = new DateTimePicker[6] { dtpHastaLu, dtpHastaMa, dtpHastaMi, dtpHastaJu, dtpHastaVi, dtpHastaSa };
            habilitado = new CheckBox[6] { chkLu, chkMa, chkMi, chkJu, chkVi, chkSa };
        }

        private void chkDia_CheckedChanged(object sender, EventArgs e, int dia)
        {
            desde[dia - 1].Enabled = habilitado[dia - 1].Checked;
            hasta[dia - 1].Enabled = habilitado[dia - 1].Checked;
        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e, int dia)
        {
            DateTime d = desde[dia - 1].Value;
            hasta[dia - 1].MinDate = d.AddMinutes(30);
        }

        private void chkLu_CheckedChanged(object sender, EventArgs e)
        {
            chkDia_CheckedChanged(sender, e, 1);
        }

        private void chkMa_CheckedChanged(object sender, EventArgs e)
        {
            chkDia_CheckedChanged(sender, e, 2);
        }

        private void chkMi_CheckedChanged(object sender, EventArgs e)
        {
            chkDia_CheckedChanged(sender, e, 3);
        }

        private void chkJu_CheckedChanged(object sender, EventArgs e)
        {
            chkDia_CheckedChanged(sender, e, 4);
        }

        private void chkVi_CheckedChanged(object sender, EventArgs e)
        {
            chkDia_CheckedChanged(sender, e, 5);
        }

        private void chkSa_CheckedChanged(object sender, EventArgs e)
        {
            chkDia_CheckedChanged(sender, e, 6);
        }

        private void dtpDesdeLu_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde_ValueChanged(sender, e, 1);
        }

        private void dtpDesdeMa_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde_ValueChanged(sender, e, 2);
        }

        private void dtpDesdeMi_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde_ValueChanged(sender, e, 3);
        }

        private void dtpDesdeJu_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde_ValueChanged(sender, e, 4);
        }

        private void dtpDesdeVi_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde_ValueChanged(sender, e, 5);
        }

        private void dtpDesdeSa_ValueChanged(object sender, EventArgs e)
        {
            dtpDesde_ValueChanged(sender, e, 6);
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            double horasSemanales = 0;
            int i = 0;
            for (i = 0; i < 6; i++)
            {
                if (habilitado[i].Checked)
                    horasSemanales += (hasta[i].Value - desde[i].Value).TotalHours;
            }
            if (horasSemanales > 48)
                MessageBox.Show("No puede tener más de 48 horas semanales. Actualmente tiene " + horasSemanales.ToString());
            else if (horasSemanales <= 0)
                MessageBox.Show("No seleccionó ningún horario");
            DAOAgenda.guardarAgenda(txtNumero.IntValue, dtpFechaInicial.Value, dtpFechaFinal.Value);
            for (i = 0; i < 6; i++)
            {
                if (habilitado[i].Checked)
                    DAOAgenda.guardarDia(txtNumero.IntValue, i + 1, desde[i].Value, hasta[i].Value);
            }
            crearTurnosDisponibles(txtNumero.IntValue, dtpFechaInicial.Value, dtpFechaFinal.Value);
            this.Close();
        }

        public void crearTurnosDisponibles(int nroMedico, DateTime fInicial, DateTime fFinal)
        {
            DateTime d = SqlConnector.fecha;
            while (d <= fFinal)
            {
                //DayOfWeek 0-Do 1-Lu..6-Sa
                int day = (int)d.DayOfWeek - 1;
                if (d.DayOfWeek != DayOfWeek.Sunday)
                    if (habilitado[day].Checked)
                    {
                        DateTime hora = desde[day].Value;
                        while (hora < hasta[day].Value)
                        {
                            DAOAgenda.turnoDisponible(nroMedico, d, hora);
                            hora = hora.AddMinutes(30);
                        }
                    }
                d = d.AddDays(1);
            }
        }
    }
}
