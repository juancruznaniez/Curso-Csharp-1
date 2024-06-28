using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // <------------------------------------------------------------------------------------------------------>
            // CICLO FOR (Es exacto, da exactamente la cantidad de vueltas con las que esté configurado).


            // for (int x = 0; x < 5; x++){
            //     Console.WriteLine("Hola, Mundo!");
            // }


            // int n;


            // for (int i = 0; i < 5; i++)
            // {
            // Console.WriteLine("Ingrese un número: ");
            // n = int.Parse(Console.ReadLine());
            // }


            // <------------------------------------------------------------------------------------------------------->
            // CICLO WHILE (Mientras esa condición lógica se cumpla, el ciclo va a seguir iterando).

            // int n, con = 0;

            // Console.WriteLine("Ingrese un número: ");
            // n = int.Parse(Console.ReadLine());
            // while (n != 0)
            // {
            //     con++;
            //     Console.WriteLine("Ingrese un número: ");
            //     n = int.Parse(Console.ReadLine());
            // }

            // Console.WriteLine("Ingresaste " + con + " Números");

            // <-------------------------------------------------------------------------------------------------------->
            // CICLO DO WHILE (Primero ejecuta una vuelta y luego pregunta si sigue).

            int n;
            int con = 0;

            do
            {
                con++;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());
            } while (n != 0);
            
            Console.WriteLine("Ingresaste " + con + " Números");
        }
    }
}
