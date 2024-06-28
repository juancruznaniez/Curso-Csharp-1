﻿using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo.  Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

            int n, con = 0;

            Console.WriteLine("Ingrese un número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if(n % i == 0) //Si el resto de dividir i con n da cero es porque es divisible por ese nro y se suma al contador de por cuantos nros es divisible.
                    con++;
            }
            if(con == 2)
                Console.WriteLine("El número ingresado es primo");
            else
                Console.WriteLine("El número ingresado no es primo");
        }
    }
}
