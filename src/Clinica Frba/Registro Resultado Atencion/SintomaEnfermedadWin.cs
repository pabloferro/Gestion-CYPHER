using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class SintomaEnfermedadWin : Form
    {
        public SintomaEnfermedadWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new Exception(textBox1.Text);
        }
    }
}
