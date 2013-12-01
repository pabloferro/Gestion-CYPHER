using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DAO
{
    public class DAOAgenda
    {
        public static void guardarAgenda(int medico, DateTime fechaI, DateTime fechaF)
        {
            SqlConnector.insert("AGENDA", "AGEN_MEDICO, AGEN_FECHAI, AGEN_FECHAF", medico, fechaI, fechaF);
        }

        public static void guardarDia(int medico, int dia, DateTime horaI, DateTime horaF)
        {
            SqlConnector.insert("AGENDA_DIA",
                "AGDI_MEDICO, AGDI_DIA, AGDI_HORAI, AGDI_HORAF", 
                medico, dia, horaI, horaF);
        }
    }
}

