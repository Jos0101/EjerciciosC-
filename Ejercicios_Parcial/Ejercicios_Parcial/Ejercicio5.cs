using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicios_Parcial
{
    internal class Ejercicio5
    {

        enum Dificultad
        {
            Facil = 1,
            Medio = 2,
            Dificil = 3
        }

        static void Main()
        {
            Random random = new Random();
            List<int> puntuaciones = new List<int>();
            bool jugarDeNuevo;

            Console.WriteLine("Bienvenido al Juego de Adivinanza Mejorado");

            do
            {
                Console.WriteLine("\nSeleccione nivel de dificultad:");
                Console.WriteLine("1. Fácil (1 - 50)");
                Console.WriteLine("2. Medio (1 - 100)");
                Console.WriteLine("3. Difícil (1 - 200)");

                if (!Enum.TryParse(Console.ReadLine(), out Dificultad dificultad))
                {
                    Console.WriteLine("Dificultad inválida, se usará por defecto: Medio.");
                    dificultad = Dificultad.Medio;
                }

                // Definir rango según dificultad (switch expression)
                int rangoMax;
                switch (dificultad)
                {
                    case Dificultad.Facil:
                        rangoMax = 50;
                        break;
                    case Dificultad.Medio:
                        rangoMax = 100;
                        break;
                    case Dificultad.Dificil:
                        rangoMax = 200;
                        break;
                    default:
                        rangoMax = 100;
                        break;
                }

                int numeroSecreto = random.Next(1, rangoMax + 1);
                int intentos = 0;
                int intentoJugador;

                Console.WriteLine($"\nHe pensado un número entre 1 y {rangoMax}. ¡Intenta adivinarlo!");

                do
                {
                    Console.Write("Tu intento: ");
                    if (!int.TryParse(Console.ReadLine(), out intentoJugador))
                    {
                        Console.WriteLine("Entrada inválida. Debe ser un número.");
                        continue;
                    }

                    intentos++;

                    if (intentoJugador == numeroSecreto)
                    {
                        Console.WriteLine($"¡Correcto! Adivinaste en {intentos} intentos.");
                        puntuaciones.Add(intentos);
                        break;
                    }

                    int diferencia = Math.Abs(numeroSecreto - intentoJugador);

                    string pista;
                    if (diferencia <= 5)
                    {
                        pista = "Muy cerca";
                    }
                    else if (diferencia <= 15)
                    {
                        pista = "Alto / Bajo";
                    }
                    else
                    {
                        pista = "Muy lejos";
                    }

                    Console.WriteLine(intentoJugador > numeroSecreto
                        ? $"{pista} → El número secreto es más bajo."
                        : $"{pista} → El número secreto es más alto.");

                } while (true);

                Console.Write("\n¿Quieres jugar otra partida? (s/n): ");
                string respuesta = Console.ReadLine().ToLower();
                jugarDeNuevo = respuesta == "s";

            } while (jugarDeNuevo);

            if (puntuaciones.Any())
            {
                Console.WriteLine("\nResultados finales generales:");
                Console.WriteLine($"- Partidas jugadas: {puntuaciones.Count}");
                Console.WriteLine($"- Mejor puntuación (menos intentos): {puntuaciones.Min()}");
                Console.WriteLine($"- Promedio de intentos: {puntuaciones.Average():F2}");
                Console.WriteLine("- Todas las puntuaciones: " + string.Join(", ", puntuaciones.OrderBy(p => p)));
            }

            Console.WriteLine("\nGracias por jugar.");
        }
    }
}
