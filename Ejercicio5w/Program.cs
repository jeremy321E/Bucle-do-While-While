using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5w
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool jugar = true;

            while (jugar)
            {
                // Mostrar menú y obtener la elección del usuario
                Console.WriteLine("Juego de Piedra, Papel o Tijera");
                Console.WriteLine("1. Piedra");
                Console.WriteLine("2. Papel");
                Console.WriteLine("3. Tijera");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción (1-4): ");

                int eleccionUsuario;
                if (!int.TryParse(Console.ReadLine(), out eleccionUsuario) || eleccionUsuario < 1 || eleccionUsuario > 4)
                {
                    Console.WriteLine("Opción inválida. Por favor, ingrese un número entre 1 y 4.");
                    continue;
                }

                if (eleccionUsuario == 4)
                {
                    jugar = false;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                }

                // Elección del usuario
                string eleccionUsuarioTexto = ObtenerEleccionTexto(eleccionUsuario);
                Console.WriteLine($"Elegiste: {eleccionUsuarioTexto}");

                // Elección de la computadora
                int eleccionComputadora = random.Next(1, 4); // 1 a 3
                string eleccionComputadoraTexto = ObtenerEleccionTexto(eleccionComputadora);
                Console.WriteLine($"La computadora eligió: {eleccionComputadoraTexto}");

                // Determinar el ganador
                string resultado = DeterminarGanador(eleccionUsuario, eleccionComputadora);
                Console.WriteLine(resultado);

                // Espacio entre juegos
                Console.WriteLine();
            }
        }

        static string ObtenerEleccionTexto(int eleccion)
        {
            switch (eleccion)
            {
                case 1: return "Piedra";
                case 2: return "Papel";
                case 3: return "Tijera";
                default: return "Opción desconocida";
            }
        }

        static string DeterminarGanador(int eleccionUsuario, int eleccionComputadora)
        {
            if (eleccionUsuario == eleccionComputadora)
            {
                return "¡Es un empate!";
            }

            if ((eleccionUsuario == 1 && eleccionComputadora == 3) ||
                (eleccionUsuario == 2 && eleccionComputadora == 1) ||
                (eleccionUsuario == 3 && eleccionComputadora == 2))
            {
                return "¡Ganaste!";
            }

            return "¡Perdiste!";
        }
    }
}



