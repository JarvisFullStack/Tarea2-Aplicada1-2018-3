using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Capitulo8
    {
        /// <summary>
        /// Programa para escribir la hora y fecha.
        /// </summary>
        public static void Ejercicio3()
        {
            Console.WriteLine(DateTime.Now.ToString("hh:mm tt yyyy/dd/MM"));
        }

        /// <summary>
        /// Pedir dos cadenas y organiarla.
        /// </summary>
        public static void Ejercicio5()
        {
            Console.WriteLine("Entrada1: ");
            String cadena1 = Console.ReadLine();
            Console.WriteLine("Entrada2: ");
            String cadena2 = Console.ReadLine();
            ArrayList order = new ArrayList();
            order.Add(cadena1);
            order.Add(cadena2);
            order.Sort();
            Console.WriteLine("Ordenado: ");
            foreach (String cadena in order)
            {
                Console.WriteLine("{0}", cadena);
            }
        }


    }
}
