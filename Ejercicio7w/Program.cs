using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            while (true)
            {
                Console.Write("Ingrese un número entero positivo: ");

                // Intentar leer la entrada del usuario y convertirla a un entero
                if (int.TryParse(Console.ReadLine(), out numero) && numero > 0)
                {
                    // Si la conversión es exitosa y el número es positivo, salir del bucle
                    break;
                }
                else
                {
                    // Mostrar mensaje de error si la entrada no es válida
                    Console.WriteLine("Entrada no válida. Por favor, ingrese un número entero positivo.");
                }
            }

            // Mostrar el número ingresado
            Console.WriteLine($"El número ingresado es {numero}.");
        }
    }
}
