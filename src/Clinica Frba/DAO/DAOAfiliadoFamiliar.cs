using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.DAO
{
    class DAOAfiliadoFamiliar : DAOAfiliadoNew
    {
        public int numeroPadre;
        public int n;
        public DAOAfiliadoFamiliar(int _nroPadre, int _n)
        {
            numeroPadre = _nroPadre;
            n = _n;
        }

        public override void save()
        {
            nro = (numeroPadre / 100) * 100 + n;
            SqlConnector.insert("AFILIADO", "AFIL_NROAFILIADO, AFIL_APELLIDO, AFIL_NOMBRE, AFIL_TIPODOCUMENTO, AFIL_DOCUMENTO, " +
                    "AFIL_MAIL, AFIL_DIRE, AFIL_PLAN, AFIL_FECHANAC, AFIL_TELEFONO, AFIL_ESTADOCIVIL, " +
                    "AFIL_CANTFAMILIARES, AFIL_SEXO",
                    nro, apellido, nombre, tipoDocumento, documento, email, direccion, plan, fechaNacimiento, telefono,
                    estadoCivil, cantFamiliares, sexo);
        }
    }
}
