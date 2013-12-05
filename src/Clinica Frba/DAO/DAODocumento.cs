using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.DAO
{
    class DAODocumento
    {
        public static System.Data.DataTable getTiposDocumento()
        {
            return SqlConnector.callProcedure("GETTIPOSDOCUMENTOS");
        }

        public static int codigo(string nombre)
        {
            return (int)SqlConnector.callScalarFunctionWithArguments("CODIGOTIPODOCUMENTO", nombre);
        }
        
        public static string nombre(int codigo)
        {
            return (string)SqlConnector.callScalarFunctionWithArguments("NOMBRETIPODOCUMENTO", codigo);
        }

        internal static void llenarCombo(System.Windows.Forms.ComboBox cmbTipoDocumento)
        {
            DataTable planes = DAODocumento.getTiposDocumento();
            foreach (DataRow row in planes.Rows)
            {
                cmbTipoDocumento.Items.Add(row["TIDO_NOMBRE"]);
            }
        }

        public static bool afiliadoDocumentoValido(int tipo, Decimal nro)
        {
            return ((int)SqlConnector.callScalarFunctionWithArguments("AFILIADODOCUMENTOVALIDO", tipo, nro) == 1);
        }
    }
}
