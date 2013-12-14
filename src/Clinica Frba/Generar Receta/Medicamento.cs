using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clinica_Frba.DAO;

namespace Clinica_Frba.Generar_Receta
{
    class Medicamento
    {
        public DateTime fechaPrescripcion = SqlConnector.fecha;
        public String codigo;
        public int cant=0;

        public Medicamento(String cod)
        {
            codigo = cod;
        }
        public override string ToString()
        {
            return Convert.ToString(this.codigo);
        }

        public void setCant(int c)
        {
            cant=c;
        }
        public void setPrescripcion(DateTime d)
        {
            fechaPrescripcion = d;
        }
    
    }


}

