using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

            // Solución hecha con contadores:

            int n, min = 0, max = 0;
            int conPares = 0, conImpares = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese un número");
                n = int.Parse(Console.ReadLine()); 
                
                if(n % 2 == 0){     // Acá se traba con pares
                    conPares++;
                    if(conPares == 1)
                    max = n;
                    else if(n > max)
                    max = n;
                } 
                else{              // Acá se trabaja con los impares
                    conImpares++;
                    if(conImpares == 1)
                    min = n;
                    else if(n < min)
                    min = n;
                }
            }
            Console.WriteLine("El max de los nros pares es: " + max + " y el min de los impares es: " + min);

            // Solución hecha con banderas:

            // int n, min = 0, max = 0;
            // int banderaPar = 0, banderaImpar = 0;

            // for (int i = 0; i < 20; i++)
            // {
            //     Console.WriteLine("Ingrese un número");
            //     n = int.Parse(Console.ReadLine()); 
                
            //     if(n % 2 == 0){     // Acá se traba con pares
            //         if(banderaPar == false){ // Arranco diciendo que no tengo par y 
            //         max = n; // (nro inicializado)
            //         banderaPar == true; // termino diciendo que si porque ya tengo un número máximo inicializado.
            //         }
            //         else if(n > max)
            //         max = n;
            //     else{              // Acá se trabaja con los impares
            //         if(banderaImpar == false){ // Arranco diciendo que no tengo impar y 
            //         min = n;    // (nro inicializado)
            //         banderaImpar == true; // termino diciendo que si porque ya tengo un número máximo inicializado.
            //         }
            //         else if(n < min)
            //         min = n;
            //     }
            // }
            // Console.WriteLine("El max de los nros pares es: " + max + " y el min de los impares es: " + min);



        }
    }
}

