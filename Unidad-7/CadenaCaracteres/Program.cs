using System;

namespace CadenaCaracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            // // Cadena de caracteres
            // char[] frase = new char[10];
            // // BARRA CERO
            // // \0
            // frase[5] = '\0';
            // char[] nombre = new char[11];

            // char letra;
            // int indice = 0;

            // Console.WriteLine("Ingrese su nombre letra por letra... (finalice presionando .)");
            // letra = char.Parse(Console.ReadLine());
            // while(letra != '.' && indice < 10)
            // {
            //     nombre[indice] = letra;
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // // if(indice == 0)
            // //     indice--;
            // nombre[indice] = '\0';

            // // TODO: Leer la cadena de texto (ejecutar)

            // Console.Write("Hola ");
            // indice = 0;
            // while (nombre[indice] != '\0')
            // {
            //     Console.Write(nombre[indice]);
            //     indice++;
            // }

            // * * STRING (Aca hacemos lo mismo que lo anterior pero en 4 lineas de codigo solamente).

            string nombre;
            Console.WriteLine("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}
