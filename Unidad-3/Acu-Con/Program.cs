using System;

namespace Acu_Con
{
    class Program
    {
        static void Main(string[] args)
        {
            // Acumuladores y Contadores: 

            int contador = 0, e1 = 20, e2 = 13, e3 = 30;
            int acumulador = 0;
            int promedio;

            if(e1 > 18){
                contador++;
                acumulador += e1;
            }
            if(e2 > 18){
                contador++;
                acumulador = acumulador + e2;
            }
            if(e3 > 18){
                contador++;
                acumulador += e3;
            }
            promedio = acumulador / contador;

            Console.WriteLine("El conteo es: " + promedio);

            // El acumulador acumula las edades (50) y el contador cuenta las que son mayores de edad (2). Por eso el promedio es 50.

        }
    }
}
