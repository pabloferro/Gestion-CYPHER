using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.DAO
{
    public class DAOMedicoNew
    {
        public const string selectFrom = "SELECT MED_CODIGO 'Código', MED_APELLIDO Apellido, MED_NOMBRE Nombre, "
                                       + "MED_SEXO Sexo, MED_ACTIVO 'A', "
                                       + "(SELECT TIDO_NOMBRE FROM CIPHER.TIPO_DOCUMENTO WHERE TIDO_CODIGO = MED_TIPODOCUMENTO) 'Tipo Doc' , "
                                       + "MED_DOCUMENTO 'Nro Doc', MED_MATRICULA Matricula, MED_MAIL Email, MED_DIRECCION Direccion, "
                                       + "MED_FECHANAC 'Fecha Nacimiento', MED_TELEFONO Telefono "
                                       + "FROM CIPHER.MEDICO";

        public static DataTable select(String filtersString)
        {
            if (filtersString != "")
                filtersString = " WHERE " + filtersString;
            return SqlConnector.select(selectFrom + filtersString);
        }

        public int codigo;
        public int matricula;
        public bool activo;
        public string nombre;
        public string apellido;
        public int tipoDocumento;
        public Decimal documento;
        public string direccion;
        public string email;
        public DateTime fechaNacimiento;
        public Decimal telefono;
        public char sexo;

        public DAOMedicoNew()
        {
            activo = true; nombre = ""; apellido = ""; matricula = 0;
            tipoDocumento = 1; documento = 0; direccion = ""; email = "";
            fechaNacimiento = SqlConnector.fecha; telefono = 0; sexo = 'F';
        }

        public virtual void save()
        {
            codigo = (int)SqlConnector.insertGetKey("MEDICO", "MED_MATRICULA, MED_APELLIDO, MED_NOMBRE, MED_TIPODOCUMENTO, MED_DOCUMENTO, " +
                                "MED_MAIL, MED_DIRECCION, MED_FECHANAC, MED_TELEFONO, " +
                                "MED_SEXO",
                                matricula, apellido, nombre, tipoDocumento, documento, email, direccion, fechaNacimiento, telefono, sexo);
        }
    }


}
