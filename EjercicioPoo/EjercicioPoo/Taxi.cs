using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    public class Taxi : Transporte
    {
        public Taxi (int pasajeros) : base(pasajeros)
        {
          
        }   
        public override string Avanzar()
        {
            return $"Taxi avanzando con {pasajeros} pasajeros arriba...";
        }

        public override string CantidadPax()
        {
            return $"{pasajeros} pasajeros.";
        }

        public override string Detenerse()
        {
            return $"Taxi deteniéndose...";
        }
    }
}
