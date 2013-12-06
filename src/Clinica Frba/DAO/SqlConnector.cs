using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Text.RegularExpressions;
using System.Configuration;
using System.IO;
using Ini;
using System.Globalization;

namespace Clinica_Frba.DAO
{
    class SqlConnector
    {
        private static IniFile file = new IniFile(Path.GetFullPath("Archivo Configuracion.ini"));

        private static string connectionString = "User id=" + file.IniReadValue("connection", "id") +
            ";Password=" + file.IniReadValue("connection", "pass") +
            ";Server=" + file.IniReadValue("connection", "server") +
            ";Trusted_Connection=yes" +
            ";database=" + file.IniReadValue("connection", "database") +
            ";connection timeout=10";

        private static SqlConnection conn = new SqlConnection(connectionString);
        
        public static void Connect()
        {
            conn.Open(); 
            
        }
        public static void Close()
        {
            conn.Close();

        }
   
        public static DataTable callProcedure(string procedure, params object[] values)
        {
            List<string> args = generateArguments(procedure);
            SqlCommand cmd = new SqlCommand("CIPHER."+procedure,conn);
            cmd.CommandType=CommandType.StoredProcedure;
            
            for (int i = 0; i < args.Count(); i++)
            {
                cmd.Parameters.AddWithValue(args[i], values[i]);
            }
            
            return retrieveDataTable(cmd);
        }

        public static DataTable retrieveDataTable(SqlCommand cmd)
        {
            DataTable dt= new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            da.Dispose();
            return dt;
        }
        
        private static List<string> generateArguments(string procedure)
        {
            SqlCommand cm = new SqlCommand(procedure,conn);
            SqlDataReader dr;
            DataTable dt = new DataTable();
            List<string> args = new List<string>();
            
            cm.CommandType = CommandType.Text;
            cm.CommandText = "SELECT PARAMETER_NAME FROM information_schema.parameters WHERE SPECIFIC_SCHEMA='CIPHER' AND SPECIFIC_NAME='" + procedure + "'";
            dr = cm.ExecuteReader();
            dt.Load(dr);
            foreach (DataRow d in dt.Rows)
            {
               if (d[0].ToString()!="")
                args.Add(d[0].ToString());
            }
            return args;
        }


        public static object callScalarFunctionWithArguments(string function, params object[] values)
        {
            
            List<string> args = generateArguments(function);
            SqlCommand cmd = new SqlCommand("CIPHER." + function, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < args.Count(); i++)
            {
                cmd.Parameters.AddWithValue(args[i], values[i]);
            }
            cmd.Parameters.Add("@RETURN_VALUE", SqlDbType.Variant).Direction = ParameterDirection.ReturnValue;
            cmd.ExecuteNonQuery();
            return cmd.Parameters["@RETURN_VALUE"].Value; 
        }

        public static object callScalarFunction(string function)
        {
            SqlCommand cmd = new SqlCommand("SELECT CIPHER." + function + "()", conn);
            return cmd.ExecuteScalar();
        }


        /*table = Nombre de la tabla 
         *columns = Nombre de las columnas ej: "col1, col2, col3"
         *params = Valores en orden
         */
        public static void insert(string table, string columns, params object[] values)
        {
            String args = "("; int a=1;
            foreach(object val in values)
            {
                args+= "@" + a.ToString() + ",";
                a++;
            }
            args = args.Substring(0, args.Length - 1);
            args += ")";
            SqlCommand cmd = new SqlCommand("INSERT INTO CIPHER." + table + " (" + columns + ") values " + args, conn);
            for (int i = 1; i <= values.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + i.ToString(), values[i-1]);
            }
            cmd.ExecuteNonQuery();
        }

        /*table = Nombre de la tabla 
         *columns = Nombre de las columnas ej: "col1, col2, col3"
         *params = Valores en orden
         */
        public static void update(string table, string pkColumn, object pk, string[] columns, params object[] values)
        {
            String args = ""; int a = 1;
            foreach (string col in columns)
            {
                args += col + " = @" + a + ",";   
                a++;
            }
            args = args.Substring(0, args.Length - 1);
            SqlCommand cmd = new SqlCommand("UPDATE CIPHER." + table + " SET " + args + 
                                            " WHERE " + pkColumn + "=" + pk.ToString(), conn);
            for (int i = 1; i <= values.Length; i++)
            {
                cmd.Parameters.AddWithValue("@" + i.ToString(), values[i - 1]);
            }
            cmd.ExecuteNonQuery();
        }

        //Igual que el insert y devuelve la PK del registro insertado
        public static object insertGetKey(string table, string columns, params object[] values)
        {
            insert(table, columns, values);
            SqlCommand cmd = new SqlCommand("SELECT @@IDENTITY", conn);
            return cmd.ExecuteScalar();
        }

        public static DataTable select(string consulta)
        {
            SqlCommand cm = new SqlCommand(consulta, conn);
            SqlDataReader dr;
            DataTable dt = new DataTable();

            //try
            {
                dr = cm.ExecuteReader();
                dt.Load(dr);
            }
            //catch (SqlException)
            {
            //    throw new Exception();
            }
            
            return dt;
        }

        public static DateTime fecha = DateTime.ParseExact(new IniFile(Path.GetFullPath("Archivo Configuracion.ini")).IniReadValue("time", "fechaComienzo"), "dd/MM/yyyy", CultureInfo.InvariantCulture);
    }
}
