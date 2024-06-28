using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

            int a, b, c, d; 
            double cien = 100;

            Console.WriteLine("Ingrese un número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el último número: ");
            d = int.Parse(Console.ReadLine());

            if(a > cien)
            Console.WriteLine("El primer valor: " + a + " Es mayor a 100.");
            if(b > cien)
            Console.WriteLine("El segundo valor: " + b + " Es mayor a 100.");
            if(c > cien)
            Console.WriteLine("El tercer valor: " + c + " Es mayor a 100.");
            if(d > cien)
            Console.WriteLine("El cuarto valor: " + d + " Es mayor a 100.");



        }
    }
}
