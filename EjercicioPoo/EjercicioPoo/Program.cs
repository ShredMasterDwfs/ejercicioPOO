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

                    while (pax < 0 || pax > 60)
                    {
                        Console.WriteLine("Debe ingresar un número positivo y menor a 60.");
                        Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipo} Nro.{i - modificador}:");
                        pax = int.Parse(Console.ReadLine());
                    }
                    
                    Omnibus Obj = new Omnibus(pax);
                    transportes[i] = $"{Obj.TipoTransporte()} {i + 1}:\t {Obj.CantidadPax()}";
                } 
                else
                {
                    tipo = "Taxi";
                    modificador = 4;
                    Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipo} Nro.{i - modificador}:");
                    int pax = int.Parse(Console.ReadLine());

                    while (pax < 0 || pax > 4)
                    {
                        Console.WriteLine("Debe ingresar un número positivo y menor a 5.");
                        Console.WriteLine($"Ingrese la cantidad de pasajeros para el {tipo} Nro.{i - modificador}:");
                        pax = int.Parse(Console.ReadLine());
                    }

                    Taxi Obj = new Taxi(pax);
                    transportes[i] = $"{Obj.TipoTransporte()} {i - modificador}: \t  {Obj.CantidadPax()}";
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

