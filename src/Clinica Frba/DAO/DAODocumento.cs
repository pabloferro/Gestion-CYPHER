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
            DataTable documentos = DAODocumento.getTiposDocumento();
            cmbTipoDocumento.Items.Clear();
            foreach (DataRow row in documentos.Rows)
            {
                cmbTipoDocumento.Items.Add(row["TIDO_NOMBRE"]);
            }
        }

        public static bool afiliadoDocumentoValido(int nroAfiliado, int tipo, Decimal nro)
        {
            return ((bool)SqlConnector.callScalarFunctionWithArguments("AFILIADODOCUMENTOVALIDO", nroAfiliado, tipo, nro));
        }

        public static bool medicoDocumentoValido(Decimal codigo, int tipo, Decimal nro)
        {
            return ((bool)SqlConnector.callScalarFunctionWithArguments("MEDICODOCUMENTOVALIDO", codigo, tipo, nro));
        }
    }
}
