using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("1. C5-E4");
                Console.WriteLine("2. C5-E5");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("3. C6-E1");
                Console.WriteLine("4. C6-E3");
                Console.WriteLine("5. C6-E4");
                Console.WriteLine("6. C6-E5");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("7. C7-E1");
                Console.WriteLine("8. C7-E2");
                Console.WriteLine("9. C7-E5");
                Console.WriteLine();
                Console.WriteLine("===================================================");
                Console.WriteLine();
                Console.WriteLine("10. C8-E3");
                Console.WriteLine("11. C8-E5");               
                Console.WriteLine();
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Capitulo5.Ejercicio4(3);
                        Console.ReadKey();
                        break;
                    case 2:
                        Capitulo5.Ejercicio5(3);
                        Console.ReadKey();
                        break;
                    case 3:
                        Capitulo6.Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 4:
                        Capitulo6.Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 5:
                        Capitulo6.Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 6:
                        Capitulo6.Ejercicio4();
                        Console.ReadKey();
                        break;
                    case 7:
                        //Capitulo6.Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 8:
                        Capitulo7.Ejercicio1();
                        Console.ReadKey();
                        break;
                    case 9:
                        Capitulo7.Ejercicio2();
                        Console.ReadKey();
                        break;
                    case 10:
                        Capitulo7.Ejercicio5();
                        Console.ReadKey();
                        break;
                    case 11:
                        Capitulo8.Ejercicio3();
                        Console.ReadKey();
                        break;
                    case 12:
                        Capitulo8.Ejercicio5();
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opcion != -1);
        }
    }
}
