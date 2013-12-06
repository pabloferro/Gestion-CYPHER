using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Clinica_Frba.Generar_Receta
{
    public partial class GenerarRecetaWindow : Form
    {
        
        public GenerarRecetaWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Bono_Click(object sender, EventArgs e)
        {
            //listBox_Bonos.Items.Add(new BonoFarmacia(numericTextBox1.IntValue));
            if (numericTextBox1.Text.Length == 0) return;
            else if (!listBox_Bonos.Items.Contains(numericTextBox1.IntValue))
            {
                agregarBono();
            }
            else
                label_Error.Text = "No puede haber bonos repetidos";
        }
        private void agregarBono()
        {
            DateTime fechaVenc = new DateTime();
            int codigoBono = numericTextBox1.IntValue;
            if (DAO.DAOReceta.vencimientoBonoF(codigoBono, fechaVenc) == -1)
                label_Error.Text = "El  bono especificado no se encuentra en el sistema";
            else if (fechaVenc > DateTime.Now)
                label_Error.Text = "El bono ya vencio en la fecha:" + fechaVenc;
            else
            {
                listBox_Bonos.Items.Add(new BonoFarmacia(codigoBono));
                label_Error.Text = "";
                textBox_Medicamento.Text = "";
                numericTextBox1.Text = "";
            }
                
        }
       
        private void listBox_Bonos_SelectedIndexChanged(object sender, EventArgs e)
        {
            acualizarVistaBonos();
        }

        private void button_Medicamento_Click(object sender, EventArgs e)
        {
            if (listBox_Bonos.SelectedItem != null)
            {
                BonoFarmacia bono = (BonoFarmacia)listBox_Bonos.SelectedItem;
                bono.addMedicamento(new Medicamento(textBox_Medicamento.Text));
                acualizarVistaBonos();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (listBox_Medicamentos.SelectedItem != null)
            {
                Medicamento med = (Medicamento)listBox_Medicamentos.SelectedItem;
                med.setPrescripcion(monthCalendar1.SelectionStart);
            }
            
        }

        private void acualizarVistaBonos()
        {
            if (listBox_Bonos.SelectedItem != null)
            {
                listBox_Medicamentos.Items.Clear();
                BonoFarmacia bono = (BonoFarmacia)listBox_Bonos.SelectedItem;
                for (int i = 0; i < bono.medicamentos.Count; i++)
                {
                    listBox_Medicamentos.Items.Add(bono.medicamentos[i]);
                }
                listBox_Medicamentos.Visible = true;
                textBox_Medicamento.Visible = true;
                label2.Visible = true;
                button_Medicamento.Visible = true;
            }  
        }

        private void actualizarVistaMedicamentos()
        {
            Medicamento med = (Medicamento)listBox_Medicamentos.SelectedItem;
            if (med != null)
            {
                this.numericUpDown1.Value=med.cant;
                monthCalendar1.SelectionStart = med.fechaPrescripcion;
                this.monthCalendar1.Visible = true;
                this.numericUpDown1.Visible = true;
                this.label_Cantidad.Visible = true;
                this.label_Fecha.Visible = true;
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (listBox_Medicamentos.SelectedItem != null)
            {
                Medicamento med = (Medicamento)listBox_Medicamentos.SelectedItem;
                med.setCant((int)this.numericUpDown1.Value);
                if ((cantMedicamentosEnBonoSeleccionado()) == 6) { label_Error.Text = "Se llego al maximo de 5 medicamentos por bono"; med.cant -= 1; numericUpDown1.Enabled = false; }
                else { label_Error.Text = ""; numericUpDown1.Enabled = true; }
            }
        }

        private void listBox_Medicamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarVistaMedicamentos();
        }
        private int cantMedicamentosEnBonoSeleccionado()
        {
            BonoFarmacia bono = (BonoFarmacia)listBox_Bonos.SelectedItem;
            int cant = 0;
            for (int i=0; i < bono.medicamentos.Count; i++)
            {
                Medicamento med = bono.medicamentos[i];
                cant += med.cant;
            }
            return cant;
        }
        private bool maximoPorBono() { return cantMedicamentosEnBonoSeleccionado() == 5; }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listBox_Bonos.Items.Count;i++)
            {
                DAO.DAOReceta.insertarReceta((BonoFarmacia) listBox_Bonos.Items[i]);
            }
            this.Close();
        }
    }

}
