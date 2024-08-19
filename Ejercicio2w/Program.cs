using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese un número
            Console.Write("Ingresa un número entero positivo: ");
            int numero = int.Parse(Console.ReadLine());

            // Validar que el número sea positivo
            if (numero <= 0)
            {
                Console.WriteLine("El número debe ser mayor que 0.");
                return;
            }

            // Inicializar variables
            int contadorPares = 0;
            int i = 1;

            // Bucle while para contar los números pares
            while (i <= numero)
            {
                if (i % 2 == 0) // Verificar si el número es par
                {
                    contadorPares++;
                }
                i++;
            }

            // Mostrar el resultado
            Console.WriteLine($"La cantidad de números pares desde 1 hasta {numero} es: {contadorPares}");
        }
    }
    }
}
