﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace Clinica_Frba.DAO
{
    public class DAOAfiliadoNew
    {
        public const string selectFrom = "SELECT AFIL_NROAFILIADO Numero, AFIL_APELLIDO Apellido, AFIL_NOMBRE Nombre, "
                                       + "AFIL_DNI DNI, AFIL_MAIL Email, AFIL_DIRE Direccion, AFIL_PLAN 'Plan', "
                                       + "AFIL_FECHANAC 'Fecha Nacimiento', AFIL_TELEFONO Telefono, "
                                       + "AFIL_ESTADOCIVIL 'Estado Civil', AFIL_CANTFAMILIARES 'Cant Familiares'"
                                       + "FROM CIPHER.AFILIADO";

        public static DataTable select(String filtersString)
        {
            if (filtersString != "")
                filtersString = " WHERE " + filtersString;
            return SqlConnector.select(selectFrom + filtersString);
        }

        public int nro;
        public Decimal plan;
        public bool activo;
        public string nombre;
        public string apellido;
        public Decimal dni;
        public string direccion;
        public string email;
        public DateTime fechaNacimiento;
        public Decimal telefono;
        public string estadoCivil;
        public int cantFamiliares;

        public DAOAfiliadoNew()
        {
            plan = 0; activo = true; nombre = ""; apellido = "";
            dni = 0; direccion = ""; email = ""; fechaNacimiento = DateTime.Today;
            telefono = 0; estadoCivil = "Soltero/a"; cantFamiliares = 0;
        }

        public virtual void save()
        {
            nro = (int)SqlConnector.callScalarFunction("PROXIMONROAFILIADO");
            SqlConnector.insert("AFILIADO", "AFIL_NROAFILIADO, AFIL_APELLIDO, AFIL_NOMBRE, AFIL_DNI, AFIL_MAIL, " +
                                "AFIL_DIRE, AFIL_PLAN, AFIL_FECHANAC, AFIL_TELEFONO, AFIL_ESTADOCIVIL, AFIL_CANTFAMILIARES",
                                nro, apellido, nombre, dni, email, direccion, plan, fechaNacimiento, telefono, estadoCivil, cantFamiliares);
            int n = 2;
            if (estadoCivil == "Casado/a" || estadoCivil == "Concubinato")
            {
                if (MessageBox.Show("¿Desea asociar a su conyuge?", "Afiliados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new Abm_de_Afiliado.Afiliado(new DAOAfiliadoFamiliar(nro, n)).ShowDialog();
                    n++;
                }
            }
            int f = 1;
            if (cantFamiliares > 0)
            {
                if (MessageBox.Show("¿Desea asociar a su familiar?", "Afiliados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    new Abm_de_Afiliado.Afiliado(new DAOAfiliadoFamiliar(nro, n)).ShowDialog();
                    n++;
                    while (f < cantFamiliares && MessageBox.Show("¿Desea asociar a otro familiar?", "Afiliados", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        new Abm_de_Afiliado.Afiliado(new DAOAfiliadoFamiliar(nro, n)).ShowDialog();
                        n++;
                        f++;
                    }
                }
            }
        }
    }


}
