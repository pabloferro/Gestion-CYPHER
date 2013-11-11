using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


namespace Clinica_Frba.DAO
{
    class DAOUser
    {
        public static Boolean CorrectLogin(string user,string pass)
        {
            DataTable dt=SqlConnector.callProcedure("CHECKLOGIN", user, pass);
            if (dt.Rows.Count == 0) return false;
            else return true;
        }

        public static DataTable getFuncionalidades(string user, int rol)
        {
            return SqlConnector.callProcedure("GETFUNCIONALIDADES", user, rol);
        }
    }
}
