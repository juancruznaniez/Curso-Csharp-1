using System;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: 1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.

            int[] numeros = new int[10];
            int n, max = 0, con = 0;

            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
                numeros[x] = n;
                if(numeros[x] > max){
                    max = numeros[x];
                    con++;
                }
                else
                    numeros[x] = max;
            }
            Console.WriteLine("El valor máximo es: " + max + " y la posición dentro del vector es: " + con);
            
        }
    }
}
