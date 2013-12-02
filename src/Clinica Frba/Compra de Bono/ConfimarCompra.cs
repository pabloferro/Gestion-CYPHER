using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Compra_de_Bono
{
    public partial class ConfimarCompra : Form
    {
        int afiliado;
        int plan;
        int cantBonosConsulta;
        int cantBonosFarmacia;

        public ConfimarCompra(int afil,int p,int cantBonosC,int cantBonosF)
        {
            InitializeComponent();
            afiliado =afil;
            plan = p;
            cantBonosConsulta = cantBonosC;
            cantBonosFarmacia = cantBonosF;
            int precioTotal = DAO.DAOCompraBonos.precioBonoConsulta(plan)*cantBonosC + DAO.DAOCompraBonos.precioBonoFarmacia(plan) * cantBonosF;
            this.label_Precio.Text = Convert.ToString(precioTotal);
            this.label_Afiliado.Text = Convert.ToString(afil);
        }

        private void ConfimarCompra_Load(object sender, EventArgs e)
        {
            
        }

        private void button_Si_Click(object sender, EventArgs e)
        {
            DAO.DAOCompraBonos.insertarCompra(afiliado, plan, cantBonosConsulta, cantBonosFarmacia);
            this.Close();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
