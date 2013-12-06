using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.DAO
{
    public class DAOBusquedaMedico
    {
        public const string selectFrom = "SELECT MED_CODIGO 'Código', MED_APELLIDO Apellido, MED_NOMBRE Nombre "
                                       + "FROM CIPHER.MEDICO";

        public static DataTable select(String filtersString)
        {
            if (filtersString != "")
                filtersString = " WHERE " + filtersString;
            return SqlConnector.select(selectFrom + filtersString);
        }
    }
}
