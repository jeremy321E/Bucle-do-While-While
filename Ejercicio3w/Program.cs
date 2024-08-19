using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10; // Inicializar el número en 10

            // Bucle do-while para imprimir los números de 10 a 0
            do
            {
                Console.WriteLine(numero); // Imprimir el número actual
                numero--; // Decrementar el número
            }
            while (numero >= 0); // Continuar hasta que el número sea menor que 0
        }
    }
}
