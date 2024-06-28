using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: 2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que son mayores al promedio.

            int[] numeros = new int[10];
            int n, promedio, max = 0, con = 0, acu = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                numeros[x] = int.Parse(Console.ReadLine());
                acu += numeros[x];
                con++;
            }
            promedio = acu / con;
            Console.WriteLine("El promedio es: " + promedio);
            
            for (int x = 0; x < 10; x++)
            {
                
                if(numeros[x] > promedio){
                    Console.WriteLine("Este numero fue mayor al promedio: " + numeros[x]);
                }
            }

            
        }
    }
}
