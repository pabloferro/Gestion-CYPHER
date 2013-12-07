using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;
using System.Globalization;

namespace Clinica_Frba.Listados_Entadisticos
{
    public partial class EstadisticasWindow : Form
    {
        public EstadisticasWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtAnio.Text == "" || txtListado.Text == "" || cmbSemestre.Text == "")
                MessageBox.Show("Complete todos los campos");
            else
            {
                switch(txtListado.SelectedIndex)
                {
                    case 0:
                        dtgListado.DataSource = SqlConnector.callProcedure("top5EspecialidadCancelaciones", txtAnio.IntValue, cmbSemestre.SelectedIndex + 1);
                        break;
                    case 1:
                        dtgListado.DataSource = SqlConnector.callProcedure("top5BonosFVencidos", SqlConnector.fecha, txtAnio.IntValue, cmbSemestre.SelectedIndex + 1);
                        break;
                }
                dtgListado.Columns["semestre"].Visible = false;
                for (int i = 1; i <= 6; i++)
                {
                    dtgListado.Columns[i.ToString()].HeaderText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 6*(cmbSemestre.SelectedIndex));
                }
            }
        }

        private void dtgListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
