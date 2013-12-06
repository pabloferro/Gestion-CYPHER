using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Clinica_Frba.Generar_Receta;
namespace Clinica_Frba.DAO
{
    class DAOReceta
    {
        public static int vencimientoBonoF(int bonoF,DateTime fechaVencimiento)
        {
            DataTable data=DAO.SqlConnector.select("select BONF_FECHAVENCIMIENTO from CIPHER.BONOFARMACIA WHERE BONF_CODIGO="+bonoF);
            if (data.Rows.Count == 0) return -1;
            else { fechaVencimiento= (DateTime)data.Rows[0][0]; return 1; }
        }

        public static void insertarReceta(BonoFarmacia bono)
        {
            for(int i=0;i<bono.medicamentos.Count;i++)
            {
                Medicamento med=bono.medicamentos[i];
                SqlConnector.insert("MEDICAMENTO_POR_RECETA", "MEDREC_MEDICAM,MEDREC_RECETA,MEDREC_CANTIDAD", med.codigo,bono.codigo, med.cant);
            }
                
            
        }
    }
}
