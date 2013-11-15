using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Clinica_Frba.DAO
{
    public class DAOAfiliadoNew
    {
        public const string selectFrom = "SELECT AFIL_NROAFILIADO Numero, AFIL_APELLIDO Apellido, AFIL_NOMBRE Nombre, "
                                       + "AFIL_DNI DNI, AFIL_MAIL Email, AFIL_DIRE Direccion, AFIL_PLAN 'Plan', "
                                       + "AFIL_FECHANAC 'Fecha Nacimiento', AFIL_TELEFONO Telefono "
                                       + "FROM CIPHER.AFILIADO";

        public static System.Data.DataTable getAfiliados(params object[] values)
        {
            return SqlConnector.callProcedure("GETAFILIADOS", values);
        }

        public static DataTable select(String filtersString)
        {
            if (filtersString != "")
                filtersString = " WHERE " + filtersString;
            return SqlConnector.select(selectFrom + filtersString);
        }

        public Decimal plan;
        public bool activo;
        public string nombre;
        public string apellido;
        public Decimal dni;
        public string direccion;
        public string email;
        public DateTime fechaNacimiento;
        public Decimal telefono;

        public DAOAfiliadoNew()
        {
            plan = 0; activo = true; nombre = ""; apellido = "";
            dni = 0; direccion = ""; email = ""; fechaNacimiento = DateTime.Today;
            telefono = 0;
        }

        public virtual void save()
        {
            SqlConnector.insert("AFILIADO", "AFIL_APELLIDO, AFIL_NOMBRE, AFIL_DNI, AFIL_MAIL, " +
                                "AFIL_DIRE, AFIL_PLAN, AFIL_FECHANAC, AFIL_TELEFONO",
                                apellido, nombre, dni, email, direccion, plan, fechaNacimiento, telefono);
        }
    }


}
