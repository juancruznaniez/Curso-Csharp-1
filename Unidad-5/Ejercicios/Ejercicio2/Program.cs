﻿using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.
            int n, max = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                if (i == 0)
                    max = n;
                else
                {
                    if (n > max)
                        max = n;
                }
            }

            Console.WriteLine("El número máximo es: " + max);
        }
    }
}
