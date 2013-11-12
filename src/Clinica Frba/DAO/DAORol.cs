using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Clinica_Frba.DAO
{
    class DAORol
    {
        public static System.Data.DataTable getRoles()
        {
            return SqlConnector.callProcedure("GETNOMBRESROLES");
        }

        public static System.Data.DataTable getFuncionalidadesRol(int rol)
        {
            return SqlConnector.callProcedure("GETFUNCIONALIDADESROL", rol);
        }

        public static System.Data.DataTable getFuncionalidadesNuevo()
        {
            return SqlConnector.callProcedure("GETFUNCIONALIDADESNUEVOROL");
        }

        List<int> funcionalidadesAgregadas;
        List<int> funcionalidadesRemovidas;
        int rol;
        bool nuevoRol;
        String nombre;
        bool habilitado;

        public void setNombre(string n)
        {
            nombre = n;
        }

        public void setHabilitado(bool h)
        {
            habilitado = h;
        }

        public DAORol()
        {
            funcionalidadesAgregadas = new List<int>();
            funcionalidadesRemovidas = new List<int>();
            nuevoRol = true;
        }

        public DAORol(int rol) : this()
        {
            this.rol = rol;
            nuevoRol = false;
        }


        public void addFuncionalidad(int f)
        {
            funcionalidadesAgregadas.Add(f);
        }

        public void removeFuncionalidad(int f)
        {
            funcionalidadesRemovidas.Add(f);
        }

        public void save(){
            if (nuevoRol)
            {
                object code = (object)SqlConnector.insertGetKey("ROL", "ROL_NOMBRE", this.nombre);

                foreach (int f in funcionalidadesAgregadas)
                {
                    SqlConnector.insert("FUNCIONALIDAD_POR_ROL", "FUNCROL_ROL, FUNCROL_FUNC", code, f);
                }
                SqlConnector.callProcedure("HABILITARROL", code, habilitado);
            }
            else
            {
                SqlConnector.callProcedure("UPDATEROL", rol, nombre);
                foreach (int f in funcionalidadesAgregadas)
                {
                    SqlConnector.callProcedure("UPDATEROLFUNCIONALIDAD", rol, f, 1);
                }
                foreach (int f in funcionalidadesRemovidas)
                {
                    SqlConnector.callProcedure("UPDATEROLFUNCIONALIDAD", rol, f, 0);
                }
                SqlConnector.callProcedure("HABILITARROL", rol, habilitado);
            }
        }
    }
}
