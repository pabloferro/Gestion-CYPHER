using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DAO
{
    class DAOPlan
    {
        public static System.Data.DataTable getPlanes()
        {
            return SqlConnector.callProcedure("GETPLANES");
        }
    }
}
