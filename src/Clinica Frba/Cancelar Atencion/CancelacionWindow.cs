using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Cancelar_Atencion
{
    public partial class CancelacionWindow : Form
    {
        public CancelacionWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPaciente_Click(object sender, EventArgs e)
        {
            new CancelacionPacienteWindow().ShowDialog(this);
        }

        private void btnMedico_Click(object sender, EventArgs e)
        {
            new CancelacionMedicoWindow().ShowDialog(this);
        }
    }
}
