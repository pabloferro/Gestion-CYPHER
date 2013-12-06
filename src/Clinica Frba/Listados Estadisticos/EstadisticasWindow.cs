using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            }
        }
    }
}
