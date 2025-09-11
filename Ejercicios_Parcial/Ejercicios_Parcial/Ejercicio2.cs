using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
namespace Ejercicios_Parcial
{
    internal class Ejercicio2
    {

        class Producto
        {
            public string Nombre { get; set; }
            public double Precio { get; set; }
            public int Cantidad { get; set; }

            public double ValorTotal => Precio * Cantidad;
        }


        class Inventario
        {
            static void Main()
            {
                List<Producto> inventario = new List<Producto>();
                int opcion;

                do
                {
                    Console.WriteLine("\nGESTOR DE INVENTARIO");
                    Console.WriteLine("1. Agregar producto");
                    Console.WriteLine("2. Buscar producto por nombre");
                    Console.WriteLine("3. Mostrar todos los productos");
                    Console.WriteLine("4. Calcular valor total del inventario");
                    Console.WriteLine("5. Salir");
                    Console.Write("Seleccione una opción: ");

                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        Console.WriteLine("Opción inválida. Intente de nuevo.");
                        continue;
                    }

                    switch (opcion)
                    {
                        case 1:
                            AgregarProducto(inventario);
                            break;
                        case 2:
                            BuscarProducto(inventario);
                            break;
                        case 3:
                            MostrarProductos(inventario);
                            break;
                        case 4:
                            CalcularValorTotal(inventario);
                            break;
                        case 5:
                            Console.WriteLine("Saliendo del programa...");
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Intente de nuevo.");
                            break;
                    }
                } while (opcion != 5);
            }
        }

        static void AgregarProducto(List<Producto> inventario)
        {

            Console.Write("Ingrese el nombre del producto: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el precio del producto: ");

            if (!double.TryParse(Console.ReadLine(), out double precio) || precio < 0)
            {
                Console.WriteLine("Precio inválido. Debe ser un número positivo.");
                return;
            }
            Console.Write("Ingrese la cantidad del producto: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad < 0)
            {
                Console.WriteLine("Cantidad inválida. Debe ser un número entero positivo.");
                return;
            }
            inventario.Add(new Producto { Nombre = nombre, Precio = precio, Cantidad = cantidad });
            Console.WriteLine("Producto agregado exitosamente.");

        }


        static void BuscarProducto(List<Producto> inventario)
        {
            Console.Write("Ingrese el nombre del producto a buscar: ");
            string nombre = Console.ReadLine();

            var encontrados = inventario.Where(p => p.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

            if (encontrados.Any())
            {
                Console.WriteLine("\nProductos encontrados:");
                foreach (var p in encontrados)
                {
                    Console.WriteLine($"- {p.Nombre} | Precio: {p.Precio:C2} | Cantidad: {p.Cantidad} | Valor total: {p.ValorTotal:C2}");
                }
            }
            else
            {
                Console.WriteLine("No se encontró el producto.");
            }
        }



        static void MostrarProductos(List<Producto> inventario)
        {

            if (!inventario.Any())
            {
                Console.WriteLine("El inventario está vacío.");
                return;
            }

            Console.WriteLine("\nLista de productos en inventario:");
            foreach (var p in inventario)
            {
                Console.WriteLine($"{p.Nombre} | Precio: {p.Precio:C2} | Cantidad: {p.Cantidad} | Valor total: {p.ValorTotal:C2}");
            }
        }

        static void CalcularValorTotal(List<Producto> inventario)
            {
            
            double valorTotal = inventario.Sum(p => p.ValorTotal);
            Console.WriteLine($"\nValor total del inventario: {valorTotal:C2}");


        }
    }
}
*/





         

