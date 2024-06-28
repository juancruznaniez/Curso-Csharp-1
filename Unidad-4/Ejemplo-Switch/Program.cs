using System;

namespace Ejemplo_Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // Switch

            // char letra = 'A';
            char letra;
            Console.WriteLine("Ingrese una letra");
            letra = char.Parse(Console.ReadLine());

            switch(letra){
                case 'J':
                    Console.WriteLine("Tu nombre comienza con J");
                    break;

                case 'L':
                    Console.WriteLine("El nombre del GOAT comienza con L");
                    break;

                case 'K':
                    break;

                case 'N':
                    break;

                default: 
                    Console.WriteLine("No coincide con ninguna");
                    break;
                
            }


        }
    }
}
