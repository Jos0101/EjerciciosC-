using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //EJERCICIO 1
            Console.Write("Ingresa la base: ");
            double baseRect = double.Parse(Console.ReadLine());

            Console.Write("Ingresa la altura : ");
            double altura = double.Parse(Console.ReadLine());

            double area = baseRect * altura;
            Console.WriteLine($"el area es: {area} metros cuadrados");


            //EJERCICICIO 2 
            Console.Write("ingrese el nombre del estudiante ");
            string estudiante = Console.ReadLine();

            Console.Write("Ingrese la nota 1: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 2: ");
            double nota2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la nota 3: ");
            double nota3 = double.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3) / 3;
            if (nota1 <= 10 || nota2 <= 10 || nota3 <= 10)
            {
                Console.WriteLine($"El promedio del estudiante es : {promedio}");
            }


            //EJERCICIO 3
            Console.Write("Ingrese la temperatura en celsius ");
            int gradosC = int.Parse(Console.ReadLine());

            double gradosF = (gradosC * 9 / 5) + 32;
            Console.WriteLine($"temperatura en Grados Fahrenheit:  {gradosF}");


            //EJERCICIO 4
            Console.Write("Ingrese cantidad en dolares ");
            int CantidadDolares = int.Parse(Console.ReadLine());

            double tasaCambio = 8.75;
            double colones = tasaCambio * CantidadDolares;
            Console.WriteLine($"Dolares convertidos a colones : {colones}");



            //EJERCICIO 5
            Console.Write("Ingrese su edad ");
            int edad = int.Parse(Console.ReadLine());


            int mesesVividos = edad * 12;
            Console.WriteLine($"meses vividos : {mesesVividos}");

            int diasVividos = edad * 365;
            Console.WriteLine($"dias vivios : {diasVividos}");


            //EJERCICIO 6
            Console.Write("Ingrese la medida del primer lado:");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la medida del segundo lado:");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la medida del tercer lado:");
            double lado3 = double.Parse(Console.ReadLine());

            double perimetro = lado1 + lado2 + lado3;
            Console.WriteLine($"El perímetro del triángulo es: {perimetro}");




            //EJERCICIO 7
            Console.Write("Ingrese un número:");
            double numero = double.Parse(Console.ReadLine());

            double cuadrado = Math.Pow(numero, 2);
            double raizCuadrada = Math.Sqrt(numero);

            Console.WriteLine($"El cuadrado de {numero} es: {cuadrado}");
            Console.WriteLine($"La raíz cuadrada de {numero} es: {raizCuadrada}");

















        }
    }
}

