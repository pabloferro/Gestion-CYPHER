using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Clinica_Frba.DAO
{
    public class DAOCompraBonos
    {
        public static int planDeAfiliado(int afil)
        {
            try
            {
                return (int)SqlConnector.select("select TOP 1 AFIL_PLAN from CIPHER.AFILIADO WHERE AFIL_NROAFILIADO=" + afil).Rows[0][0];
            }
            catch(IndexOutOfRangeException)
            {
                return -1;
            }
        }
        public static int precioBonoConsulta(int plan)
        {
            return (int)SqlConnector.select("select TOP 1 PLAN_BONOCONSULTAPRECIO from CIPHER.PLANCLINICA where PLAN_CODIGO="+plan).Rows[0][0];
        }
        public static int precioBonoFarmacia(int plan)
        {
            return (int)SqlConnector.select("select TOP 1 PLAN_BONOFARMACIAPRECIO from CIPHER.PLANCLINICA where PLAN_CODIGO="+plan).Rows[0][0];
        }
        public static void insertarCompra(int afil,int plan,int cantBonosC,int cantBonosF)
        {
            SqlConnector.insert("COMPRA", "COMP_FECHA,COMP_AFILIADO,COMP_PLAN", SqlConnector.fecha, afil, plan);
            int codigoCompra = (int)SqlConnector.select("select TOP 1 COMP_CODIGO from CIPHER.COMPRA order by COMP_CODIGO DESC").Rows[0][0];
            int ultimoBonoC = (int)SqlConnector.select("select top 1 BONC_CODIGO from CIPHER.BONOCONSULTA ORDER BY BONC_CODIGO DESC").Rows[0][0];
            int ultimoBonoF = (int)SqlConnector.select("select top 1 BONF_CODIGO from CIPHER.BONOFARMACIA ORDER BY BONF_CODIGO DESC").Rows[0][0];
            for (int i = 0; i < cantBonosC; i++)
            {
                SqlConnector.insert("BONOCONSULTA", "BONC_CODIGO,BONC_COMPRA,BONC_FECHAIMPRESION", ultimoBonoC+i+1,codigoCompra, SqlConnector.fecha);
            }
            for (int i = 0; i < cantBonosC; i++)
            {
                SqlConnector.insert("BONOFARMACIA", "BONF_CODIGO,BONF_COMPRA,BONF_FECHAIMPRESION,BONF_FECHAVENCIMIENTO", ultimoBonoF+i+1,codigoCompra, SqlConnector.fecha,SqlConnector.fecha.AddDays(60));
            }
            if (cantBonosC > 0)
                MessageBox.Show("El primer bono consulta es " + (ultimoBonoC + 1).ToString() + ".");
            if (cantBonosF > 0)
                MessageBox.Show("El primer bono farmacia es " + (ultimoBonoF + 1).ToString() + ".");
        }

        public static bool AfiliadoActivo(int afil)
        {
            return (bool)SqlConnector.select("select top 1 AFIL_ACTIVO from CIPHER.AFILIADO where AFIL_NROAFILIADO="+afil).Rows[0][0];
        }

    }
}
