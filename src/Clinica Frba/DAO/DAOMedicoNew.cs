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

        public List<int> especialidadesAgregadas;
        public List<int> especialidadesRemovidas;

        public void addEspecialidad(int e)
        {
            especialidadesAgregadas.Add(e);
        }

        public void removeEspecialidad(int e)
        {
            especialidadesRemovidas.Add(e);
        }

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

        public Decimal codigo;
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
            especialidadesAgregadas = new List<int>();
            especialidadesRemovidas = new List<int>();
            activo = true; nombre = ""; apellido = ""; matricula = 0;
            tipoDocumento = 1; documento = 0; direccion = ""; email = "";
            fechaNacimiento = SqlConnector.fecha; telefono = 0; sexo = 'F';
            codigo = -1;
        }

        public virtual void save()
        {
            codigo = (Decimal)SqlConnector.insertGetKey("MEDICO", "MED_MATRICULA, MED_APELLIDO, MED_NOMBRE, MED_TIPODOCUMENTO, MED_DOCUMENTO, " +
                                "MED_MAIL, MED_DIRECCION, MED_FECHANAC, MED_TELEFONO, " +
                                "MED_SEXO",
                                matricula, apellido, nombre, tipoDocumento, documento, email, direccion, fechaNacimiento, telefono, sexo);
            
            foreach (int e in especialidadesAgregadas)
            {
                SqlConnector.insert("ESPECIALIDAD_POR_MEDICO", "ESPMED_MEDICO, ESPMED_ESP", codigo, e);
            }
        }
    }


}
