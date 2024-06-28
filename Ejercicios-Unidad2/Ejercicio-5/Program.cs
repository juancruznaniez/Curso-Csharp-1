using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno y luego calcule y emita por pantalla el promedio final.

            float n1, n2, n3, promedioFinal;

            Console.WriteLine("Ingrese su primer nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese su tercer nota: ");
            n3 = float.Parse(Console.ReadLine());
            
            promedioFinal = (n1 + n2 + n3) / 3;
            Console.WriteLine("Su promedio final es: " + promedioFinal);


        }
    }
}
