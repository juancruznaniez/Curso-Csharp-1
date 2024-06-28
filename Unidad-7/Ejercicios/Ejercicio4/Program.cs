using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: 4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con los siguientes datos: 
            // - Número de Artículo (1 a 15) 
            // - Cantidad Vendida 

            // Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
            // Se pide determinar e informar:
            // a) El número de artículo que más se vendió en total.
            // b) Los números de artículos que no registraron ventas.
            // c) Cuantas unidades se vendieron del número de artículo 10.

            int nroArticulo;
            int cantidad;
            int[] totalCantidadVendida = new int[15];

            for (int x = 0; x < 10; x++) // Da 15 vueltas y me inicializa en 0 todos los elementos. Asi yo en el ciclo while puedo contar en ese vector que esta inicializado en 0
            {
                totalCantidadVendida[x] = 0;
            }

            Console.WriteLine("Ingrese el nro de articulo: ");
            nroArticulo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantidad = int.Parse(Console.ReadLine());

            while (nroArticulo != 0)
            {
                totalCantidadVendida[nroArticulo - 1] += cantidad; // Quiero que me cargue la cantidad en el nro de articulo que carga la persona -1 (ya que el vector comienza en 0)

                Console.WriteLine("Ingrese el nro de articulo: ");
                nroArticulo = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantidad = int.Parse(Console.ReadLine());
            }

            // * Punto A: Tengo que buscar un máximo dentro del vector y su posción(para obtener el nro de articulo).
            int maxCantidad = totalCantidadVendida[0];
            int nroMaximo = 1;
            for (int x = 0; x < 10; x++)
            {
                if(totalCantidadVendida[x] > maxCantidad){
                    maxCantidad = totalCantidadVendida[x];
                    nroArticulo = x + 1;
                }
            }
            Console.WriteLine("El producto mas vendido es el: " + nroArticulo + " con la cantidad de: " + maxCantidad);

            // * Punto B:
            for (int x = 0; x < 10; x++)
            {
                if(totalCantidadVendida[x] == 0){
                    Console.WriteLine("El producto " + (x + 1) + " no tuvo ventas");
                }
            }

            // * Punto C:
            Console.WriteLine("La cantidad vendida del articulo 10 es de: " + totalCantidadVendida[9]);

        }
    }
}
