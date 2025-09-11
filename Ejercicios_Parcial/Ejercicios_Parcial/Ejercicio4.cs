using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


/*
namespace Ejercicios_Parcial
{
    internal class Ejercicio4
    {

        static void Main()
        {

            Console.WriteLine("Ingrese un texto para analizar:");
            string texto = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(texto))
            {
                Console.WriteLine("El texto no puede estar vacío.");
                return;
            }

            string textoNormalizado = texto.ToLower();
            int totalCaracteresConEspacios = texto.Length;
            int totalCaracteresSinEspacios = texto.Replace(" ", "").Length;


            var palabras = Regex.Matches(textoNormalizado, @"\b\w+\b")
                         .Cast<Match>()
                         .Select(m => m.Value)
                         .ToList();

            int numeroPalabras = palabras.Count;


            int numeroOraciones = Regex.Split(texto, @"[.!?]+")
                                  .Where(s => !string.IsNullOrWhiteSpace(s))
                                  .Count();

            //palabra mas larga y mas corta

            string palabraMasLarga = palabras.OrderByDescending(p => p.Length).FirstOrDefault();
            string palabraMasCorta = palabras.OrderBy(p => p.Length).FirstOrDefault();


            //frecuencia de cada vocal

            var vocales = "aeiou";
            var frecuenciaVocales = vocales.ToDictionary(
                v => v,
                v => textoNormalizado.Count(c => c == v)
            );


            var conteoIniciales = palabras
            .GroupBy(p => p[0])   
            .OrderBy(g => g.Key)
            .Select(g => new { Letra = g.Key, Cantidad = g.Count() });


            Console.WriteLine("\nResultado del texto:");
            Console.WriteLine($"- Total de caracteres (con espacios): {totalCaracteresConEspacios}");
            Console.WriteLine($"- Total de caracteres (sin espacios): {totalCaracteresSinEspacios}");
            Console.WriteLine($"- Número de palabras: {numeroPalabras}");
            Console.WriteLine($"- Número de oraciones: {numeroOraciones}");
            Console.WriteLine($"- Palabra más larga: {palabraMasLarga}");
            Console.WriteLine($"- Palabra más corta: {palabraMasCorta}");

            Console.WriteLine("\nFrecuencia de vocales:");
            foreach (var v in frecuenciaVocales)
            {
                Console.WriteLine($"  {v.Key}: {v.Value}");
            }

            Console.WriteLine("\nConteo de palabras por letra inicial:");
            foreach (var item in conteoIniciales)
            {
                Console.WriteLine($"  {item.Letra}: {item.Cantidad}");
            }
        }

    }
}

*/