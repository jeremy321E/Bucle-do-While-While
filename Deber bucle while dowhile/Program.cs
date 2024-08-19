using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deber_bucle_while_dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear una instancia de Random para generar números aleatorios
            Random random = new Random();

            // Generar un número aleatorio entre 1 y 100
            int numeroAleatorio = random.Next(1, 101);

            // Variable para almacenar la adivinanza del usuario
            int adivinanza = 0;

            // Mensaje inicial
            Console.WriteLine("He generado un número aleatorio entre 1 y 100.");
            Console.WriteLine("Intenta adivinar el número.");

            // Bucle while para seguir pidiendo intentos hasta que el usuario acierte
            while (adivinanza != numeroAleatorio)
            {
                // Solicitar al usuario que ingrese una adivinanza
                Console.Write("Ingresa tu adivinanza: ");
                adivinanza = int.Parse(Console.ReadLine());

                // Verificar la adivinanza
                if (adivinanza < numeroAleatorio)
                {
                    Console.WriteLine("Demasiado bajo. Intenta de nuevo.");
                }
                else if (adivinanza > numeroAleatorio)
                {
                    Console.WriteLine("Demasiado alto. Intenta de nuevo.");
                }
                else
                {
                    Console.WriteLine("¡Felicidades! Has adivinado el número.");
                }
            }
        }
    }
}
