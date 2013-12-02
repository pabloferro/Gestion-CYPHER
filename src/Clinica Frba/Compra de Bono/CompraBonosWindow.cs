using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.Compra_de_Bono;


namespace Clinica_Frba.Compra_De_Bono
{
    public partial class CompraBonosWindow : Form
    {
        public CompraBonosWindow()
        {
            InitializeComponent();
            textBoxCantBonoC.Text = "0";
            textBoxCantBonoF.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            int afiliado = Convert.ToInt32(textBoxAfiliado.Text);
            int plan=DAO.DAOCompraBonos.planDeAfiliado(afiliado);
            if (plan.Equals(-1)) labelError.Text = "Afiliado No Existente";
            else if (DAO.DAOCompraBonos.AfiliadoActivo(afiliado).Equals(false)) labelError.Text = "El afiliado debe estar activo";
            else
                new ConfimarCompra(afiliado, plan, Convert.ToInt32(textBoxCantBonoC.Text), Convert.ToInt32(textBoxCantBonoF.Text)).ShowDialog();
        }
    }
}
