using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de los dos primeros es mayor al producto del segundo con el tercero.


            int a, b, c;

            Console.WriteLine("Ingrese un número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número: ");
            c = int.Parse(Console.ReadLine());

            if ((a + b) > (b * c))
            {
                Console.WriteLine("La suma de los primeros es mayor al producto del 2do con el 3ro");
            }
            else if ((a + b) < (b * c))
            {
                Console.WriteLine("El producto del 2do con el 3ro es mayor");
            }

        }
    }
}
