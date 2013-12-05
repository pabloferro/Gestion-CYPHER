using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.DAO
{
    class DAOAtencionMedica
    {
        public static void insertarAtencionMedica(int turno,string sintomas,string enfermedades)
        {
            SqlConnector.insert("ATENCIONMEDICA", "ATENCMED_TURNO,ATENMED_DIAGNOSTICO,ATENMED_SINTOMAS", turno, enfermedades, sintomas);
        }
        public static bool yaHayAtencionMedica(int turno)
        {
            return SqlConnector.select("select top 1 * from CIPHER.ATENCIONMEDICA where ATENCMED_TURNO=" + turno).Rows.Count == 1;
        }
    }
}
