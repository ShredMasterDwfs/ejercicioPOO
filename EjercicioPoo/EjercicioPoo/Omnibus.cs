using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    public class Omnibus : Transporte
    {
        private string tipoTransporte = "Omnibus";

        public Omnibus (int pasajeros) : base(pasajeros)
        {
            
        }
        public override string Avanzar()
        {
            return $"Ómnibus avanzando con {pasajeros} pasajeros arriba...";
        }

        public override string CantidadPax()
        {
            return $"{pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"Ómnibus deteniéndose...";
        }

        public string TipoTransporte()
        {
            return this.tipoTransporte;
        }
    }
}
