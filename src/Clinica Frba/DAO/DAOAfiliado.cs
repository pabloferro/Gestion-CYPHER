using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ini;
using System.IO;
using System.Globalization;
using Clinica_Frba.Varios;
using System.Windows.Forms;

namespace Clinica_Frba.DAO
{
    public class DAOAfiliado : DAOAfiliadoNew
    {

        public static void baja(int nro)
        {
            string[] columnasBaja = { "AFIL_ACTIVO", "AFIL_FECHABAJA" };
            SqlConnector.update("AFILIADO", "AFIL_NROAFILIADO", nro, columnasBaja, 0, SqlConnector.fecha);
        }

        private static string[] columns = {"AFIL_APELLIDO", "AFIL_NOMBRE", "AFIL_DNI", "AFIL_MAIL", 
                                           "AFIL_DIRE", "AFIL_TELEFONO", "AFIL_ESTADOCIVIL", "AFIL_CANTFAMILIARES"};
        public decimal plan_anterior;
        public DAOAfiliado(int _nro, int _plan, bool _activo, string _nombre, string _apellido, Decimal _dni, string _direccion, string _email, DateTime _fechaNacimiento, Decimal _telefono, string _estadoCivil, int _cantFamiliares)
        {
            nro = _nro; plan = _plan; plan_anterior = _plan; activo = _activo; nombre = _nombre; apellido = _apellido;
            dni = _dni; direccion = _direccion; email = _email; fechaNacimiento = _fechaNacimiento;
            telefono = _telefono; estadoCivil = _estadoCivil; cantFamiliares = _cantFamiliares;
        }

        public override void save()
        {
            SqlConnector.update("AFILIADO", "AFIL_NROAFILIADO", nro, columns, apellido, nombre, dni,
                                                                email, direccion, telefono, estadoCivil, cantFamiliares);
            if (plan != plan_anterior)
            {
                string motivo = "";
                InputBox.Show("Cambio de Plan", "Motivo:", ref motivo);
                SqlConnector.callProcedure("CAMBIARPLAN", nro, plan, SqlConnector.fecha, motivo);
            }
        }
    }
}
