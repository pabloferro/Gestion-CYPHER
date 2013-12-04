using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

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

        public static void turnoDisponible(int medico, DateTime fecha, DateTime horaI)
        {
            SqlConnector.insert("TURNO_DISPONIBLE", "TUDI_MEDICO, TUDI_FECHA, TUDI_HORAI", medico, fecha, horaI);
        }

        public static void pedirTurno(int medico, int afiliado, DateTime fecha, TimeSpan horaI)
        {
            SqlConnector.callProcedure("PEDIRTURNO", medico, afiliado, fecha, horaI);
        }

        public static DataTable fechasTurnos(int medico)
        {
            return SqlConnector.callProcedure("FECHASTURNOS", medico, SqlConnector.fecha);
        }

        public static DataTable turnosPorFecha(int medico, DateTime fecha)
        {
            return SqlConnector.callProcedure("TURNOSPORFECHA", medico, fecha);
        }

        public static DateTime fechaInicial(int medico)
        {
            return (DateTime)SqlConnector.callScalarFunctionWithArguments("AGENDADESDE", medico);
        }

        public static DateTime fechaFinal(int medico)
        {
            return (DateTime)SqlConnector.callScalarFunctionWithArguments("AGENDAHASTA", medico);
        }

        public static bool atiendeDia(int medico, int dia)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("ATIENDEDIA", medico, dia);
        }

        internal static void cancelarTurnos(int medico, DateTime fInicial, DateTime fFinal, string motivo)
        {
            SqlConnector.callProcedure("CANCELARTURNOMEDICO", medico, fInicial, 
                                       SqlConnector.fecha.AddDays(-1), fFinal, motivo);
        }
    }
}

