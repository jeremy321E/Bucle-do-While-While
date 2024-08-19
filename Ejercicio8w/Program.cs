using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inicializar saldo
            decimal saldo = 1000.00m; // Saldo inicial
            bool continuar = true;

            while (continuar)
            {
                // Mostrar menú
                Console.Clear();
                Console.WriteLine("Bienvenido al cajero automático");
                Console.WriteLine("1. Consultar saldo");
                Console.WriteLine("2. Retirar dinero");
                Console.WriteLine("3. Depositar dinero");
                Console.WriteLine("4. Salir");
                Console.Write("Seleccione una opción: ");

                // Leer la opción del usuario
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        // Consultar saldo
                        Console.WriteLine($"Su saldo actual es: {saldo:C}");
                        break;

                    case "2":
                        // Retirar dinero
                        Console.Write("Ingrese el monto a retirar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal montoRetiro) && montoRetiro > 0)
                        {
                            if (montoRetiro <= saldo)
                            {
                                saldo -= montoRetiro;
                                Console.WriteLine($"Se han retirado {montoRetiro:C}. Su saldo actual es: {saldo:C}");
                            }
                            else
                            {
                                Console.WriteLine("Saldo insuficiente.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido. Ingrese un número positivo.");
                        }
                        break;

                    case "3":
                        // Depositar dinero
                        Console.Write("Ingrese el monto a depositar: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal montoDeposito) && montoDeposito > 0)
                        {
                            saldo += montoDeposito;
                            Console.WriteLine($"Se han depositado {montoDeposito:C}. Su saldo actual es: {saldo:C}");
                        }
                        else
                        {
                            Console.WriteLine("Monto inválido. Ingrese un número positivo.");
                        }
                        break;

                    case "4":
                        // Salir
                        continuar = false;
                        Console.WriteLine("Gracias por usar el cajero automático. ¡Hasta luego!");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                        break;
                }

                // Esperar al usuario para que pueda leer el mensaje antes de continuar
                if (continuar)
                {
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                }
            }
        }
    }
}
