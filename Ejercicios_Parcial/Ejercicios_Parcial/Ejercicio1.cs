using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
namespace Ejercicios_Parcial
{


   internal class Ejercicio1
   {
       static void Main(string[] args)



       {

           int cantidadNotas = 0;
           double[] notas;


           while (true)
           {
                Console.Write("Ingrese la cantidad de notas que desea procesar (entre 2 y 10): ");
               if (int.TryParse(Console.ReadLine(), out cantidadNotas) && cantidadNotas >= 2 && cantidadNotas <= 10)
                   {
                       break;
                   }
               Console.WriteLine("Cantidad inválida. Intente nuevamente.");
           }

           notas =  new double[cantidadNotas];

           for (int i = 0; i < cantidadNotas; i++)
           {
               double nota;

               while (true)
               {
                   Console.Write($"Ingrese la nota #{i + 1} (0 - 10): ");
                   if (double.TryParse(Console.ReadLine(), out nota) && nota >= 0 && nota <= 10)
                   {
                       notas[i] = nota;
                       break;
                   }
                   Console.WriteLine(" Nota inválida. Debe estar entre 0 y 10.");
               }
           }


           //calcular el promedio, menor y mayor nota
           double sumaNotas = notas.Sum();
           double promedio = sumaNotas / cantidadNotas;
           double menorNota = notas.Min();
           double mayorNota = notas.Max();

           Console.WriteLine($"\nResultados:");
           Console.WriteLine($"Promedio de notas: {promedio:F2}");


           Console.WriteLine($"Menor nota: {menorNota:F2}");
           Console.WriteLine($"Mayor nota: {mayorNota:F2}");



           if (promedio >= 7)
               Console.WriteLine("El estudiante aprobo.");
           else
               Console.WriteLine("El estudiante reprobo.");



       }
   }
}

*/
