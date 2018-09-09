using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Capitulo6
    {

        /// <summary>
        ///  Utilizar arreglo Jagged para calcular el promedio.
        /// </summary>
        public static void Ejercicio1()
        {
            int nalumnos = 0, nsalon = 0;
            float acum = 0.0f;
            float promedio = 0.0f;

            Console.Write("Salones: ");
            nsalon = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[nsalon][];

            for (int i = 0; i < nsalon; i++)
            {
                Console.Write("Alumnos en Curso: " + (i + 1));

                nalumnos = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[nalumnos];
            }

            for (int i = 0; i < nsalon; i++)
            {
                Console.WriteLine("Salon: " + (i + 1));
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Estudiante  " + (1 + j));
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (int i = 0; i < nsalon; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    acum += (float)calificaciones[i][j];

                }
            }
            promedio = acum / (nalumnos * nsalon);
            Console.WriteLine("El promedio es:" + promedio);
        }




        /// <summary>
        ///   Calcular la menor calificacion utilizando un 
        /// arreglo jagged.
        /// </summary>
        public static void Ejercicio2()
        {
            int nalumnos = 0, ncursos = 0, i = 0, j = 0;
            float minima = 100.0f;

            Console.Write("Cantidad Cursos: ");

            ncursos = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[ncursos][];

            for (i = 0; i < ncursos; i++)
            {
                Console.Write("Salon " + (i + 1) + " Cantidad estudiantes: ");
                nalumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new float[nalumnos];
            }

            for (i = 0; i < ncursos; i++)
            {
                Console.WriteLine("Aula: " + (i + 1));
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Nota: ");
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (i = 0; i < ncursos; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] < minima)
                    {
                        minima = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("Nota Minima: " + minima);
        }

        /// <summary>
        /// Determinar la mayor
        /// </summary>
        public static void Ejercicio3()
        {
            int nalumnos = 0, ncursos = 0, i = 0, j = 0;
            float maxima = 0;
            Console.Write("Cantidad Cursos: ");
            ncursos = Convert.ToInt32(Console.ReadLine());
            float[][] calificaciones = new float[ncursos][];
            for (i = 0; i < ncursos; i++)
            {
                Console.Write("Salon " + (i + 1) + " Cantidad estudiantes: ");
                nalumnos = Convert.ToInt32(Console.ReadLine());
                calificaciones[i] = new float[nalumnos];
            }

            for (i = 0; i < ncursos; i++)
            {
                Console.WriteLine("Aula: " + (i + 1));
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Nota: ");
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (i = 0; i < ncursos; i++)
            {
                for (j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    if (calificaciones[i][j] > maxima)
                    {
                        maxima = calificaciones[i][j];
                    }
                }
            }
            Console.WriteLine("Nota Maxima: " + maxima);
        }






        /// <summary>
        /// Modificar el programa anterior para que utilice funciones.
        /// </summary>
        public static void Ejercicio4()
        {
            int nalumnos = 0, nsalon = 0;
            float acum = 0.0f;
            float promedio = 0.0f;
            Console.Write("Cantidad Aulas:  ");
            nsalon = Convert.ToInt32(Console.ReadLine());

            float[][] calificaciones = new float[nsalon][];

            for (int i = 0; i < nsalon; i++)
            {
                Console.Write("Estudiantes para aula: " + (i + 1));

                nalumnos = Convert.ToInt32(Console.ReadLine());

                calificaciones[i] = new float[nalumnos];
            }

            for (int i = 0; i < nsalon; i++)
            {
                Console.WriteLine("Para el aula:  " + (i + 1));
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    Console.Write("Nota estudiante: " + (1 + j));
                    calificaciones[i][j] = Convert.ToSingle(Console.ReadLine());
                }

            }

            for (int i = 0; i < nsalon; i++)
            {
                for (int j = 0; j < calificaciones[i].GetLength(0); j++)
                {
                    acum += calificaciones[i][j];

                }
            }
            promedio = acum / (nalumnos * nsalon);
            Console.WriteLine("Promedio es: " + promedio);
        }

        /// <summary>
        /// Pasar arreglo jagged como argumento
        /// </summary>
        /// <param name="a">Arreglo jagged</param>
        public static void Ejercicio5(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.GetLength(0); j++)
                {
                    Console.WriteLine("{0}", a[i][j]);
                }
            }


        }
    }
}
