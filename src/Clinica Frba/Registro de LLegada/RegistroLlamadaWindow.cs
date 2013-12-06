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

namespace Clinica_Frba.Registro_de_llegada
{
    public partial class RegistroLlegadaWindow : Form, ConMedico
    {
        public RegistroLlegadaWindow()
        {
            InitializeComponent();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            if (txtNroMedico.Text == "")
                MessageBox.Show("Debe ingresar un Médico");
            else
            {
                dtgTurnos.DataSource = DAOAgenda.turnosHoy(txtNroMedico.IntValue);
                dtgTurnos.Columns["Código"].Visible = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            
            if (txtNroAfiliado.Text == "")
                MessageBox.Show("Debe ingresar un nro de Afiliado");
            else
            {
                int turno = DAOAfiliado.turnoEnFecha(txtNroMedico.IntValue, txtNroAfiliado.IntValue);
                if ((turno) == -1)
                    MessageBox.Show("El afiliado ingresado no tiene turno para este médico en esta fecha");
                else if ((turno) == -2)
                    MessageBox.Show("El afiliado está inactivo");
                else
                    if (txtBono.Text == "")
                        MessageBox.Show("Debe ingresar un Bono de Consulta");
                    else
                        if (!DAOAfiliado.bonoValido(txtNroAfiliado.IntValue, txtBono.IntValue))
                            MessageBox.Show("El bono ingresado no es válido. (usado, está vencido o no corresponde al grupo familiar)");
                        else
                        {
                            DAOAfiliado.registrarLlegada(txtNroAfiliado.IntValue, turno, txtNroMedico.IntValue);
                            MessageBox.Show("Llegada registrada!");
                            this.Close();
                        }
            }
        }

        public void setMedico(int nro)
        {
            txtNroMedico.Text = nro.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Varios.BuscarMedicoWindow(this).ShowDialog(this);
        }
    }
}
