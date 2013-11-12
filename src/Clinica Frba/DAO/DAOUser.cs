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
        public static int CorrectLogin(string user,string pass)
        {
            DataTable dt=SqlConnector.callProcedure("CHECKLOGIN", user, pass);
            return (int) dt.Rows[0][0];
        }

        public static DataTable getFuncionalidades(string user, int rol)
        {
            return SqlConnector.callProcedure("GETFUNCIONALIDADES", user, rol);
        }

        public static DataTable getRoles(string usuario)
        {
            return SqlConnector.select("select ROL_NOMBRE,ROL_CODIGO from CYPHER.ROLES_POR_USUARIO JOIN CYPHER.ROL ON ROLUS_ROL=ROL_CODIGO  AND ROLUS_USUARIO='"+usuario+"'");
        }
    }
}
