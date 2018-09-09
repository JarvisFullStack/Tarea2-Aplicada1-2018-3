using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Capitulo7
    {
        /// <summary>
        /// Calcular promedio, calificacion maxima y minima utiliando arrayList de collections.
        /// </summary>
        public static void Ejercicio1() 
        {
            int salida = 0;
            int i = 0;
            ArrayList acalificaciones = new ArrayList();
            float calificacion = 0f;




            float maxima = 0f;
            float minima = 100f;

            Console.WriteLine("Cuando Desee terminar de agregar notas , digite -1\n");
            do
            {
                Console.WriteLine("Digite la calificacion del estudiante: {0}", i + 1);
                calificacion = Convert.ToSingle(Console.ReadLine());
                
                if (maxima < calificacion)
                    maxima = calificacion;
                if (minima > calificacion && calificacion != -1)
                    minima = calificacion;
                if (calificacion == -1)
                    salida = Convert.ToInt32(calificacion);
                else
                    acalificaciones.Add(calificacion);
                i++;

            } while (salida != -1);

          
            float promedio = 0f;
            
           
           
            foreach (float n in acalificaciones)
            {
                promedio += n;
            }
            Console.WriteLine("Promedio: " + promedio / acalificaciones.Count);
            Console.WriteLine("NotaMaxima: " + maxima);
            Console.WriteLine("NotaMinima: " + minima);
        }

        /// <summary>
        /// Utilizar una tabla hash para crear un diccionario.
        /// </summary>
        public static void Ejercicio2()
        {
            Hashtable dic = new Hashtable();
            Console.WriteLine("Cantidad de conceptos a agregar:");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Palabra: ");
                String palabra = Console.ReadLine();
                Console.WriteLine("Significado: ");
                String definicion = Console.ReadLine();
                dic.Add(palabra, definicion);
            }
            foreach (DictionaryEntry d in dic)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }


















        /// <summary>
        /// Hacer una agenda telefonica que guarde el nombre de la persona y su numero de telefono.
        /// </summary>
        public static void Ejercicio5() 
        {
            Hashtable contactos = new Hashtable();
            Console.WriteLine("Cantidad Contactos: ");
            int j = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < j; i++)
            {
                Console.WriteLine("Nombre: ");
                String nombre = Console.ReadLine();
                Console.WriteLine("Numero telefonico: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                contactos.Add(nombre, numero);
            }
            foreach (DictionaryEntry d in contactos)
            {
                Console.WriteLine("{0}: {1}", d.Key, d.Value);
            }
        }
    }
}
