using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Registro_Resultado_Atencion
{
    public partial class RegistroAtencionWindow : Form
    {
        int turno;
        public RegistroAtencionWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Ok_Click(object sender, EventArgs e)
        {
            DateTime fecha= SqlConnector.fecha;
            turno = Convert.ToInt32(textBox1.Text);
            if (DAO.DAOAtencionMedica.yaHayAtencionMedica(turno)) label_Error.Text = "Ya hay una atencion medica del turno solicitado";
            else if (DAO.DAOTurnos.FechaTurno(turno, fecha))
            {
                makeVisibleFechaTurno();
                string dia = Convert.ToString(fecha.Day) +"/" +Convert.ToString(fecha.Month) + "/"+Convert.ToString(fecha.Year);
                string hora = Convert.ToString(fecha.TimeOfDay.Hours) + ":" +Convert.ToString(fecha.TimeOfDay.Minutes);
                label_Fecha.Text = dia + " ( " + hora + " )";
            }
            else
            {
                label_Error.Text = "El turno solicitado no existe en el sistema";
            }

        }

        private void makeVisibleFechaTurno()
        {
            label1.Visible = true;
            button_Si.Visible = true;
            button_No.Visible = true;
            label_Error.Visible = false;
        }
        private void makeSintomasEnfermedadesVisible()
        {
            button_Enfermedades.Visible = true;
            button_Sintomas.Visible = true;
            label_Enfermedades.Visible = true;
            label_Sintomas.Visible = true;
            comboBox_Enfermedades.Visible = true;
            comboBox_Sintomas.Visible = true;
            button_Aceptar.Visible = true;
            button_Cancelar.Visible = true;
        }

        private void button_Si_Click(object sender, EventArgs e)
        {
            makeSintomasEnfermedadesVisible();
        }

        private void button_No_Click(object sender, EventArgs e)
        {
            makeSintomasEnfermedadesVisible();
        }

        private void button_Sintomas_Click(object sender, EventArgs e)
        {
            try
            {
                new SintomaEnfermedadWin().ShowDialog();
            }
            catch (Exception ex)
            {
                comboBox_Sintomas.Items.Add(ex.Message);
            }
        }

        private void button_Enfermedades_Click(object sender, EventArgs e)
        {
            try
            {
                new SintomaEnfermedadWin().ShowDialog();
            }
            catch (Exception ex)
            {
                comboBox_Enfermedades.Items.Add(ex.Message);
            }
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Aceptar_Click(object sender, EventArgs e)
        {
            string sintomas="";
            string enfermedades="";
            for (int i = 0; i < comboBox_Sintomas.Items.Count; i++)
            {
                sintomas = sintomas +  comboBox_Sintomas.Items[i] + " + ";
            }
            for (int i = 0; i < comboBox_Enfermedades.Items.Count; i++)
            {
                enfermedades = enfermedades + comboBox_Enfermedades.Items[i] + " + ";
            }
            sintomas = sintomas.Substring(0, sintomas.Length - 3);
            enfermedades = enfermedades.Substring(0, enfermedades.Length - 3);
            DAO.DAOAtencionMedica.insertarAtencionMedica(turno, sintomas, enfermedades);
            this.Close();
        }
    }
}
