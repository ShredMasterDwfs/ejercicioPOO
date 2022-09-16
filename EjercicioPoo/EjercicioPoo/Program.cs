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
                    tipo = "Omnibus";
                    Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipo} Nro.{i - modificador}:");
                    int pax = int.Parse(Console.ReadLine());
                    Omnibus Obj = new Omnibus(pax);
                    transportes[i] = $"{tipo} {i + 1}: {Obj.CantidadPax()}";
                } 
                else
                {
                    tipo = "Taxi";
                    modificador = 4;
                    Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipo} Nro.{i - modificador}:");
                    int pax = int.Parse(Console.ReadLine());
                    Taxi Obj = new Taxi(pax);
                    transportes[i] = $"{tipo} {i - modificador}: {Obj.CantidadPax()}";
                }
            }

            for (int i = 0; i < transportes.Length; i++)
            {
                Console.WriteLine(transportes[i]);
            }
        Console.ReadKey();  
        }
    }
}
