using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Diccionario de palabras
            string[] diccionario = { "manzana", "naranja", "plátano", "fresa", "kiwi", "mango", "sandía" };

            // Crear un generador de números aleatorios
            Random random = new Random();

            // Seleccionar una palabra aleatoria del diccionario
            string palabraAleatoria = diccionario[random.Next(diccionario.Length)];

            // Variable para almacenar la entrada del usuario
            string intentoUsuario = string.Empty;

            // Contador de intentos
            int intentos = 0;

            Console.WriteLine("¡Bienvenido al juego de adivinar la palabra!");
            Console.WriteLine("Intenta adivinar la palabra secreta.");

            // Bucle while para pedir intentos hasta que el usuario acierte
            while (intentoUsuario != palabraAleatoria)
            {
                // Solicitar al usuario que ingrese su intento
                Console.Write("Ingresa tu intento: ");
                intentoUsuario = Console.ReadLine();

                // Incrementar el contador de intentos
                intentos++;

                // Verificar si el intento es correcto
                if (intentoUsuario.Equals(palabraAleatoria, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"¡Felicidades! Has adivinado la palabra '{palabraAleatoria}' en {intentos} intentos.");
                }
                else
                {
                    Console.WriteLine("Intenta nuevamente.");
                }
            }
        }
    }
}
