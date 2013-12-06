using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Clinica_Frba.Generar_Receta
{
    class BonoFarmacia
    {
        public List<Medicamento> medicamentos = new List<Medicamento>();
        public int codigo;

        public BonoFarmacia(int cod)
        {
            codigo = cod;
        }

        public override string ToString()
        {
            return Convert.ToString(this.codigo);
        }

        public void addMedicamento(Medicamento med)
        {
            medicamentos.Add(med);
        }
    }
}
