using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: 3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:
            // TODO CADENA FUENTE: “La mar estaba serena"
            // TODO CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
            // TODO CADENA RESULTADO: “Li mir estibi sereni"

            // char letraActual, letraNueva, letra;
            // char[] frase = new char[30];
            // int indice = 0;

            // Console.WriteLine("Ingrese su frase letra por letra:  (finalice presionando '.')");
            // letra = char.Parse(Console.ReadLine());
            // while (letra != '.' && indice < 30)
            // {
            //     frase[indice] = letra;
            //     letra = char.Parse(Console.ReadLine());
            //     indice++;
            // }
            // frase[indice] = '\0'; // me determina el final de la cadena.


            // indice = 0;
            // while (frase[indice] != '\0')
            // {
            //     Console.Write(frase[indice]);
            //     indice++;
                
            // }
            // Console.WriteLine("Ingrese letra a reemplazar: ");
            // letraActual = char.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese letra nueva: ");
            // letraNueva = char.Parse(Console.ReadLine());

            // indice = 0;
            // while (frase[indice] != '\0')
            // {
            //     if(frase[indice] == letraActual)
            //         frase[indice] = letraNueva;

            //     indice++;
            // }

            // Console.WriteLine("La frase nueva es: ");
            // indice = 0;
            // while (frase[indice] != '\0')
            // {
            //     Console.Write(frase[indice]);
            //     indice++;
            // }

            // * * <<<--------------------------------------------------------------------------------------------------------------------------------------------------------------------->>>
            // Otra forma de hacerlo mas sencilla es: 
            // Tener en cuenta que detrás de este poco, ocurre todo lo que se hizo con anterioridad.

            string frase;
            char letraActual;
            char letraNueva;
            Console.WriteLine("Ingrese la frase: ");
            frase = Console.ReadLine();
            Console.WriteLine("Ingrese la letra a reemplazar: ");
            letraActual = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la letra nueva: ");
            letraNueva = char.Parse(Console.ReadLine());

            frase = frase.Replace(letraActual, letraNueva);

            Console.WriteLine("La frase nueva es: ");
            Console.WriteLine(frase);
        }
    }
}
