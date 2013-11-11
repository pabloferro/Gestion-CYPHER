using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DAO
{
    public class DAOAfiliado : DAOAfiliadoNew
    {

        private static string[] columns = {"AFIL_APELLIDO", "AFIL_NOMBRE", "AFIL_DNI", "AFIL_MAIL", 
                                           "AFIL_DIRE", "AFIL_PLAN", "AFIL_TELEFONO"};
        public int nro;

        public DAOAfiliado(int _nro, int _plan, bool _activo, string _nombre, string _apellido, Decimal _dni, string _direccion, string _email, DateTime _fechaNacimiento, Decimal _telefono)
        {
            nro = _nro; plan = _plan; activo = _activo; nombre = _nombre; apellido = _apellido;
            dni = _dni; direccion = _direccion; email = _email; fechaNacimiento = _fechaNacimiento;
            telefono = _telefono;
        }

        public override void save()
        {
            SqlConnector.update("AFILIADO", "AFIL_NROAFILIADO", nro, columns, "'" + apellido + "'",
                                "'" + nombre + "'", dni, "'" + email + "'", "'" + direccion + "'", plan, telefono);
        }
    }
}
