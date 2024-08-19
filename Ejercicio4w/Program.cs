using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4w
{
    internal class Program
    {
        static void Main(string[] args)
        {


            bool continuar = true; // Controla la ejecución del bucle
            while (continuar)
            {
                // Mostrar el menú
                Console.WriteLine("Menú:");
                Console.WriteLine("1. Sumar dos números");
                Console.WriteLine("2. Restar dos números");
                Console.WriteLine("3. Multiplicar dos números");
                Console.WriteLine("4. Dividir dos números");
                Console.WriteLine("5. Salir");
                Console.Write("Elige una opción (1-5): ");

                // Leer la opción del usuario
                int opcion;
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número entre 1 y 5.");
                    continue;
                }

                // Ejecutar la opción seleccionada
                switch (opcion)
                {
                    case 1:
                        RealizarOperacion("suma");
                        break;

                    case 2:
                        RealizarOperacion("resta");
                        break;

                    case 3:
                        RealizarOperacion("multiplicación");
                        break;

                    case 4:
                        RealizarOperacion("división");
                        break;

                    case 5:
                        continuar = false;
                        Console.WriteLine("¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, ingrese un número entre 1 y 5.");
                        break;
                }
            }
        }

        static void RealizarOperacion(string tipoOperacion)
        {
            // Solicitar dos números al usuario
            Console.Write($"Ingrese el primer número para la {tipoOperacion}: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Ingrese el segundo número para la {tipoOperacion}: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Realizar la operación y mostrar el resultado
            double resultado = 0;
            switch (tipoOperacion)
            {
                case "suma":
                    resultado = num1 + num2;
                    break;

                case "resta":
                    resultado = num1 - num2;
                    break;

                case "multiplicación":
                    resultado = num1 * num2;
                    break;

                case "división":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: División por cero no permitida.");
                        return;
                    }
                    break;
            }

            Console.WriteLine($"El resultado de la {tipoOperacion} es: {resultado}");
        }
    }
