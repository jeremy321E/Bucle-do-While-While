using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario el número para calcular el factorial
            Console.Write("Ingrese un número entero no negativo para calcular su factorial: ");

            int numero;
            // Verificar que el número ingresado sea válido
            if (!int.TryParse(Console.ReadLine(), out numero) || numero < 0)
            {
                Console.WriteLine("Por favor, ingrese un número entero no negativo.");
                return;
            }

            // Calcular el factorial
            long factorial = 1;
            int i = 1;

            while (i <= numero)
            {
                factorial *= i;
                i++;
            }

            // Mostrar el resultado
            Console.WriteLine($"El factorial de {numero} es {factorial}.");
        }
    }
}
