using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.DAO
{
    class DAOTurnos
    {
        public static bool FechaTurno(int turn,DateTime fecha)
        {
            try
            {
                fecha = (DateTime)SqlConnector.select("select top 1 TURN_FECHA from CIPHER.TURNO where TURN_CODIGO=" + turn).Rows[0][0];
                return true;
            }
            catch (IndexOutOfRangeException)
            {
                return false;
            }

        }
    }
}
