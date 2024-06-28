using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

            // La resta si el primero es mayor que el segundo.
            // La suma si son iguales.
            // El producto si el primero es menor.
            // Se deberá emitir un cartel por pantalla con el resultado correspondiente.


            int a, b, resultado;

            Console.WriteLine("Ingrese un número: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            b = int.Parse(Console.ReadLine());

            if(a == b)
                resultado = a + b;
            else{
                if(a > b)
                    resultado = a - b;
                    else
                    resultado = a * b;
            }    
            


            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
