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
    public class DAOAfiliado : DAOAfiliadoNew
    {

        public static DataTable turnosAsignados(int nro)
        {
            //Le sumo uno a la fecha por el día de antelación
            return SqlConnector.callProcedure("TURNOSASIGNADOS", nro, SqlConnector.fecha.AddDays(1));
        }

        public static void baja(int nro)
        {
            string[] columnasBaja = { "AFIL_ACTIVO", "AFIL_FECHABAJA" };
            SqlConnector.update("AFILIADO", "AFIL_NROAFILIADO", nro, columnasBaja, 0, SqlConnector.fecha);
        }

        private static string[] columns = {"AFIL_APELLIDO", "AFIL_NOMBRE", "AFIL_TIPODOCUMENTO", "AFIL_DOCUMENTO", "AFIL_MAIL", 
                                           "AFIL_DIRE", "AFIL_TELEFONO", "AFIL_ESTADOCIVIL", "AFIL_CANTFAMILIARES",
                                           "AFIL_SEXO"};
        public decimal plan_anterior;
        public DAOAfiliado(int _nro, int _plan, bool _activo, string _nombre, string _apellido, int _tipoDocumento, Decimal _documento, string _direccion, string _email, DateTime _fechaNacimiento, Decimal _telefono, string _estadoCivil, int _cantFamiliares, char _sexo)
        {
            nro = _nro; plan = _plan; plan_anterior = _plan; activo = _activo; nombre = _nombre; apellido = _apellido;
            tipoDocumento = _tipoDocumento; documento = _documento; direccion = _direccion; email = _email; fechaNacimiento = _fechaNacimiento;
            telefono = _telefono; estadoCivil = _estadoCivil; cantFamiliares = _cantFamiliares; sexo = _sexo;
        }

        public override void save()
        {
            SqlConnector.update("AFILIADO", "AFIL_NROAFILIADO", nro, columns, apellido, nombre, tipoDocumento, documento, email,
                                                    direccion, telefono, estadoCivil, cantFamiliares, sexo);
            if (plan != plan_anterior)
            {
                string motivo = "";
                InputBox.Show("Cambio de Plan", "Motivo:", ref motivo);
                SqlConnector.callProcedure("CAMBIARPLAN", nro, plan, SqlConnector.fecha, motivo);
            }
        }

        public static void cancelarTurno(int codigo, string motivo)
        {
            SqlConnector.callProcedure("CANCELARTURNOPACIENTE", codigo, motivo);
        }

        public static int turnoEnFecha(int medico, int afiliado)
        {
            return (int)SqlConnector.callScalarFunctionWithArguments("TURNOENFECHAAFILIADO", medico, afiliado, SqlConnector.fecha);
        }

        public static bool bonoValido(int afiliado, int bono)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("AFILIADOBONOVALIDO", afiliado, bono, SqlConnector.fecha);
        }

        public static bool bonoValidoF(int afiliado, int bono)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("AFILIADOBONOFARMACIAVALIDO", afiliado, bono, SqlConnector.fecha);
        }

        public static void registrarLlegada(int afiliado, int turno, int bono)
        {
            SqlConnector.callProcedure("REGISTRARLLEGADA", afiliado, turno, bono, SqlConnector.fecha);
        }

        public static bool afiliadoActivo(int afiliado)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("AFILIADOACTIVO", afiliado);
        }

        public static bool afiliadoValido(int afiliado)
        {
            return (bool)SqlConnector.callScalarFunctionWithArguments("AFILIADOVALIDO", afiliado);
        }
    }
}
