using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ini;
using System.IO;
using System.Globalization;
using Clinica_Frba.Varios;
using System.Windows.Forms;
using System.Data;

namespace Clinica_Frba.DAO
{
    public class DAOMedico : DAOMedicoNew
    {
        public static void baja(int nro)
        {
            string[] columnasBaja = { "MED_ACTIVO"};
            SqlConnector.update("MEDICO", "MED_CODIGO", nro, columnasBaja, 0);
            SqlConnector.callProcedure("CANCELARTURNOMEDICOTODOS", nro, "Baja de médico");
        }

        private static string[] columns = {"MED_APELLIDO", "MED_NOMBRE", "MED_TIPODOCUMENTO", "MED_DOCUMENTO", "MED_MAIL", 
                                           "MED_DIRECCION", "MED_TELEFONO", "MED_MATRICULA", "MED_SEXO"};
        public decimal plan_anterior;
        public DAOMedico(Decimal _codigo, int _matricula, bool _activo, string _nombre, string _apellido, int _tipoDocumento, Decimal _documento, string _direccion, string _email, DateTime _fechaNacimiento, Decimal _telefono, char _sexo)
        {
            codigo = _codigo; matricula = _matricula; activo = _activo; nombre = _nombre; apellido = _apellido;
            tipoDocumento = _tipoDocumento; documento = _documento; direccion = _direccion; email = _email; fechaNacimiento = _fechaNacimiento;
            telefono = _telefono; sexo = _sexo;
        }

        public override void save()
        {
            SqlConnector.update("MEDICO", "MED_CODIGO", codigo, columns, apellido, nombre, tipoDocumento, documento, email,
                                                    direccion, telefono, matricula, sexo);
            foreach (int f in especialidadesAgregadas)
            {
                SqlConnector.callProcedure("UPDATEMEDICOESPECIALIDAD", codigo, f, 1);
            }
            foreach (int f in especialidadesRemovidas)
            {
                SqlConnector.callProcedure("UPDATEMEDICOESPECIALIDAD", codigo, f, 0);
            }
        }

        public static bool medicoActivo(int medico)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("MEDICOACTIVO", medico);
        }

        public static bool medicoValido(int medico)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("MEDICOVALIDO", medico);
        }
    }
}
