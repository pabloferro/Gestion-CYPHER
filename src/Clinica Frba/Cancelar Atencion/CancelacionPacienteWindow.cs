using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

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
            dtgTurnos.DataSource = DAOAfiliado.turnosAsignados(txtNroAfiliado.IntValue);
        }
    }
}
