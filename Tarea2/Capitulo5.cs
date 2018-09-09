using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2
{
    class Capitulo5
    {


        
            /// <summary>
            ///  Funcion para calcular
            /// el factorial de un numero n.
            /// </summary>
            /// <param name="n"></param>
            /// <returns>int</returns>
            public static int Ejercicio4(int n)
            {
                if (n < 2) return n;
                return (n * Ejercicio4(n-1));
               
            }

            /// <summary>
            ///   Funcion que retorna una palabra
            /// correspondiente al numero introducido.
            /// </summary>
            /// <param name="n"></param>
            /// <returns></returns>
            public static String Ejercicio5(int numero)

            {
                switch (numero)
                {
                    case 0:
                        return "cero";
                    case 1:
                        return "uno";
                    case 2:
                        return "dos";
                    case 3:
                        return "tres";
                    case 4:
                        return "cuatro";
                    case 5:
                        return "cinco";
                    case 6:
                        return "seis";
                    case 7:
                        return "siete";
                    case 8:
                        return "ocho";
                    case 9:
                        return "nueve";
                    default:
                        return "Numero incorrecto";
                }
            }
        
}
