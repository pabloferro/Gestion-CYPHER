using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.DAO
{
    class DAOPlan
    {
        public static System.Data.DataTable getPlanes()
        {
            return SqlConnector.callProcedure("GETPLANES");
        }

        internal static void llenarCombo(System.Windows.Forms.ComboBox txtPlan)
        {
            DataTable planes = DAOPlan.getPlanes();
            foreach (DataRow row in planes.Rows)
            {
                txtPlan.Items.Add(row["PLAN_CODIGO"]);
            }
        }
    }
}
