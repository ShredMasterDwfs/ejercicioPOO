using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    public abstract class Transporte
    {
        public int pasajeros { get; set; }

        public Transporte (int pasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public abstract string Avanzar();

        public abstract string Detenerse();

    }
}
