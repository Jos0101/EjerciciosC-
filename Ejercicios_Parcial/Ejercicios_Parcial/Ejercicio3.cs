using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 
namespace Ejercicios_Parcial
{
    internal class Ejercicio3
    {

        static void Main()
        {

            string[] unidades = { "", "uno", "dos", "tres", "cuatro", "cinco", "seis", "siete", "ocho", "nueve" };
            string[] especiales = { "diez", "once", "doce", "trece", "catorce", "quince", "dieciséis", "diecisiete", "dieciocho", "diecinueve" };
            string[] decenas = { "", "", "veinte", "treinta", "cuarenta", "cincuenta", "sesenta", "setenta", "ochenta", "noventa" };
            string[] centenas = { "", "ciento", "doscientos", "trescientos", "cuatrocientos", "quinientos", "seiscientos", "setecientos", "ochocientos", "novecientos" };


            int numero;


            do
            {
                Console.Write("Ingrese un número (1-999, 0 para salir): ");
                string entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out numero))
                {
                    Console.WriteLine("Entrada inválida. Intente de nuevo.");
                    continue;
                }

                if (numero == 0) break;

                if (numero < 1 || numero > 999)
                {
                    Console.WriteLine("Número fuera de rango (1-999).");
                    continue;
                }

                string resultado = ConvertirNumeroAPalabras(numero, unidades, especiales, decenas, centenas);
                Console.WriteLine($"{numero} = \"{resultado}\"");

            } while (numero != 0);


        }


        static string ConvertirNumeroAPalabras(int numero, string[] unidades, string[] especiales, string[] decenas, string[] centenas)
        {
            if (numero == 100) return "cien";

            int centena = numero / 100;
            int resto = numero % 100;
            int decena = resto / 10;
            int unidad = resto % 10;

            string resultado = "";

          
            if (centena > 0)
                resultado += centenas[centena] + " ";

            // Casos especiales 10-19
            if (resto >= 10 && resto <= 19)
            {
                resultado += especiales[resto - 10];
            }
            // Caso especial 20-29
            else if (resto >= 20 && resto <= 29)
            {
                if (resto == 20)
                    resultado += "veinte";
                else
                    resultado += "veinti" + unidades[unidad];
            }
            // Casos 30-99
            else
            {
                if (decena > 0)
                {
                    resultado += decenas[decena];
                    if (unidad > 0)
                        resultado += " y " + unidades[unidad];
                }
                else if (unidad > 0)
                {
                    resultado += unidades[unidad];
                }
            }

            return resultado.Trim();
        }
    

        }

    }
 
*/
