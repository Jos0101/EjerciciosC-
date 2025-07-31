using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Estructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* EJERCICIO 1
             
            int resultado = 5 * 10; // Este comentario de línea no se ve afectadoint opcion;
            do
            {
                Console.WriteLine("--- MENÚ ---");
                Console.WriteLine("1. Sumar");
                Console.WriteLine("2. Restar");
                Console.WriteLine("3. Salir");
                Console.Write("Selecciona una opción: ");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingresa el primer numero: ");
                        int a = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa el segundo numero: ");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado de la suma: {a + b}");
                        break;
                    case 2:
                        Console.Write("Ingresa el primer numero : ");
                        int x = int.Parse(Console.ReadLine());
                        Console.Write("Ingresa el segundo numero : ");
                        int y = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Resultado de la resta: {x - y}");
                        break;
                    case 3:
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

            } while (opcion != 3);
             
            */

            /* EJERCICIO 2

              Console.WriteLine("Cuantos numeros desea ingresar?: ");
              int cantidad = int.Parse(Console.ReadLine());
              int suma = 0;


              for (int i = 0; i < cantidad; i++)
              {
                  Console.WriteLine($"Numero: {i + 1}");
                  int num = int.Parse(Console.ReadLine());

                  suma += num;
               }

              Console.WriteLine($"La suma total es : {suma}");
             */





            /* EJERCICIO 3 

             string contrasena = "123";
             int intentos = 0;
             string acceso;

             while (intentos < 3) {

             Console.WriteLine("Ingrese la contrasena");
             acceso = Console.ReadLine();

             if (acceso == contrasena) {
                 Console.WriteLine("Ingreso exitoso");
                 break;

             }else
             {
                 Console.WriteLine("Contrasena Incorrecta");
                 intentos++;
                 }
               {
             }
          }  */






            /* EJERCICIO 4

           Console.WriteLine("Cuantas calificaciones desea agregar");
           double n = double.Parse(Console.ReadLine());
           int contador = 0;
           double suma = 0;


           while (contador < n)
           {

               Console.Write($"Ingrese calificación {contador + 1} (0 a 10): ");
               double nota = double.Parse(Console.ReadLine());

               if (nota >= 0 && nota <= 10)
               {
                   suma += nota;
                   contador++;

               }
               else
               {
                   Console.WriteLine("Calificacion no valida. Intentelo de nuevo");

               }
           }
               double promedio = suma / n;
               Console.WriteLine($"Promedio:  {promedio} ");


               if (promedio < 6)
                   Console.WriteLine("Rendimiento: Bajo");
               else if (promedio <= 8)
                   Console.WriteLine("Rendimiento: Regular");
               else
                   Console.WriteLine("Rendimiento: Excelente");
            */







            //EJERCICIO 5

            string respuesta;

            do
            {
                Console.WriteLine("Ingrese el producto a agregar: ");
                string producto = Console.ReadLine();

                Console.WriteLine("Ingrese el precio : ");
                double precio = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese la cantidad : ");
                int cantidad = int.Parse(Console.ReadLine());

                double total = precio * cantidad;


                if (cantidad > 0 && precio > 0)
                {
                    Console.WriteLine($"Producto: {producto}");
                    Console.WriteLine($"Precio: {precio:C}");
                    Console.WriteLine($"Cantidad: {cantidad}");
                    Console.WriteLine($"Total a pagar: {total:C}");
                }
                else
                {
                    Console.WriteLine("Cantidad o precio inválidos. No se puede calcular el total.");
                }

                Console.Write("¿Desea agregar otro producto? (s/n): ");
                 respuesta = Console.ReadLine();
                Console.WriteLine();

            } while (respuesta == "s");
 
                Console.WriteLine("Gracias!");
        

        }


    }
    }
