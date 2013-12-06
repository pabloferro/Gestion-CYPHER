
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.DAO
{
    class DAOEspecialidad
    {
        public static System.Data.DataTable getEspecialidades()
        {
            return SqlConnector.callProcedure("GETESPECIALIDADES");
        }

        public static System.Data.DataTable getEspecialidadesMedico(Decimal medico)
        {
            return SqlConnector.callProcedure("GETESPECIALIDADESMEDICO", medico);
        }

        internal static void llenarComboMedico(System.Windows.Forms.ComboBox txtEsp, Decimal medico)
        {
            DataTable especialidades = DAOEspecialidad.getEspecialidadesMedico(medico);
            txtEsp.Items.Clear();
            foreach (DataRow row in especialidades.Rows)
            {
                txtEsp.Items.Add(row["ESP_DESC"]);
            }
        }

        internal static void llenarCombo(System.Windows.Forms.ComboBox txtEsp)
        {
            DataTable especialidades = DAOEspecialidad.getEspecialidades();
            txtEsp.Items.Clear();
            foreach (DataRow row in especialidades.Rows)
            {
                txtEsp.Items.Add(row["ESP_DESC"]);
            }
        }

        internal static void llenarCombo(System.Windows.Forms.CheckedListBox lstEspecialidades)
        {
            DataTable especialidades = DAOEspecialidad.getEspecialidades();
            lstEspecialidades.Items.Clear();
            foreach (DataRow row in especialidades.Rows)
            {
                lstEspecialidades.Items.Add(row["ESP_DESC"]);
            }
        }

        public static int codigo(string nombre)
        {
            return (int)SqlConnector.callScalarFunctionWithArguments("CODIGOESPECIALIDAD", nombre);
        }

        public static string nombre(int codigo)
        {
            return (string)SqlConnector.callScalarFunctionWithArguments("NOMBREESPECIALIDAD", codigo);
        }
    }
}
