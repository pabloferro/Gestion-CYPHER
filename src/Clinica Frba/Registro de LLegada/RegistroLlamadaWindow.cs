using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Registro_de_llegada
{
    public partial class RegistroLlegadaWindow : Form
    {
        public RegistroLlegadaWindow()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            dtgTurnos.DataSource = DAOAgenda.turnosHoy(txtNroMedico.IntValue);
            dtgTurnos.Columns["Código"].Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
