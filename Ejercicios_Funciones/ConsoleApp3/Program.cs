using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{


    class ProgramaAreas
    {
        static void Main()
        {
            int opcion;
            decimal resultado;
            decimal r;
            decimal num1Ar, num2Ar;

            string continuar;


            do { 

            Console.WriteLine("Cálculos");
            Console.WriteLine("1. Área de un Cuadrado");
            Console.WriteLine("2. Área de un Triángulo");
            Console.WriteLine("3. Área de un Rectángulo");
            Console.WriteLine("4. Sumar: ");
            Console.WriteLine("5. Restar: ");
            Console.WriteLine("6. Multiplicar: ");
            Console.WriteLine("7. Division");
            Console.Write("Elige una opción: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            while (opcion < 1 || opcion > 7)
            {
                Console.Write("Opción inválida. Elige nuevamente (1-7): ");
                opcion = Convert.ToInt32(Console.ReadLine());
            }

            switch (opcion)
            {
                case 1:
                    CalcularAreaCuadrado();
                    break;
                case 2:
                    resultado = CalcularAreaTriangulo();
                    Console.WriteLine("El área del triángulo es: {0}", resultado);
                    break;
                case 3:
                    Console.WriteLine("Introduce la base del rectángulo: ");
                    decimal baseR = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Introduce la altura del rectángulo: ");
                    decimal alturaR = Convert.ToDecimal(Console.ReadLine());

                    resultado = CalcularAreaRectangulo(baseR, alturaR);
                    Console.WriteLine("El área del rectángulo es: {0}", resultado);
                    break;

                case 4:
                    Sumar();
                    break;
                case 5:
                    r = Restar(); //Asinamos el valor devuelto por "Return"
                    //Mostramos el resultado, con la informacion que contiene "r"
                    Console.WriteLine("El resultado de la resta es:{0} ", r);
                    break;
                case 6:
                    Console.WriteLine("Introduce el primer numero: ");
                    num1Ar = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Introduce el segundo numero: ");
                    num2Ar = Convert.ToDecimal(Console.ReadLine());

                    //Invocamos al metodo
                    Multiplicar(num1Ar, num2Ar);
                    break;

                case 7:
                    Console.WriteLine("Introduce el primer numero: ");
                    num1Ar = Convert.ToDecimal(Console.ReadLine());

                    Console.WriteLine("Introduce el segundo numero: ");
                    num2Ar = Convert.ToDecimal(Console.ReadLine());

                    r = Dividir(num1Ar, num2Ar);
                    Console.WriteLine("El resultado de la división es:{0} ", r);
                    break;
            }


            Console.WriteLine("\n¿Quieres realizar otra operación? (s/n): ");
            continuar = Console.ReadLine();

           } while (continuar == "s");

            Console.WriteLine("OK ADIOS");
          
        
        }// Cierre del Main


        //Inicio de los metodos
        static void CalcularAreaCuadrado()
        {
            Console.Write("Introduce el lado del cuadrado: ");
            decimal lado = Convert.ToDecimal(Console.ReadLine());

            decimal area = lado * lado;
            Console.WriteLine("El área del cuadrado es: {0}", area);
        }


        static decimal CalcularAreaTriangulo()
        {
            Console.Write("Introduce la base del triángulo: ");
            decimal base2 = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Introduce la altura del triángulo: ");
            decimal altura2 = Convert.ToDecimal(Console.ReadLine());

            decimal area = (base2 * altura2) / 2;
            return area;
        }


        static decimal CalcularAreaRectangulo(decimal base2, decimal altura2)
        {
            return base2 * altura2;
        }



        static void Sumar()
        {
            //Variables del metodo sumar ()
            decimal num1, num2, resultado;
            Console.WriteLine("Introduce el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            resultado = num1 + num2;
            //Mostramos el resultado
            Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
        }
        static decimal Restar()
        {
            //Variables del metodo Restar ()
            decimal num1, num2, resultado;

            Console.WriteLine("Introduce el primer numero: ");
            num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Introduce el segundo numero: ");
            num2 = Convert.ToDecimal(Console.ReadLine());

            //Operacion 
            resultado = num1 - num2;

            //Devolvemos un tipo al autor de llamado 
            return resultado;
        }

        static void Multiplicar(decimal num1Pa, decimal num2Pa)
        {
            //Declaracion de variables
            decimal resultado;

            //Multiplicacion con los valores que mandan los arguementos
            resultado = num1Pa * num2Pa;

            //Mostramos el resultado
            Console.WriteLine("{0} * {1} = {2}", num1Pa, num2Pa, resultado);
        }

        //[modificador] [tipo] [Nombre] [parametros]
        static decimal Dividir(decimal num1Pa, decimal num2Pa)
        {
            //Variable 
            decimal resultado;
            if (num2Pa != 0)
            {
                //Division con los valores que mandaron los argumentos
                resultado = num1Pa / num2Pa;
            }
            else
            {
                Console.WriteLine("No es prosible dividir entre cero");
                resultado = 0;
            }
            return resultado;
        
         }
     }
}