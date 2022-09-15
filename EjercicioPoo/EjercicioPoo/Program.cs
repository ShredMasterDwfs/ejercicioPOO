using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string tipo;

            string[] transportes = new string[10];

            int modificador = -1;

            for (int i = 0; i < 10; i++)
            {
                if (i < 5)
                {
                    tipo = "ómnibus";
                } else
                {
                    tipo = "taxi";
                    modificador = 4;
                }

                Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipo} Nro.{i - modificador}:");
                int pax = int.Parse(Console.ReadLine());
                transportes[i] = $"{tipo} {i + 1}: {pax} pasajeros.";
            }

            for (int i = 0; i < transportes.Length; i++)
            {
                Console.WriteLine(transportes[i]);
            }
            Console.ReadKey();
            
        }
    }
}
