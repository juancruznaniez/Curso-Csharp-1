using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {

            // // Paso 0: Declarar variables (Pedir permiso de almacenamiento al sistema operativo)
            // // Tipo de dato: int (nº enteros) ; float (nº con coma) ; char (para tipo de datos letras, un char admite una letra) ; bool ( admite V o F)
            int n1, n2, resultado;

            // Paso 1: Pedir valores y guardarlos en las variables

            Console.WriteLine("Ingrese un número: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro número: ");
            n2 = int.Parse(Console.ReadLine());

            //Paso 2: Realizar Cálculo

            resultado = n1 + n2;

            //Paso 3: Emitir resultados


            Console.WriteLine("El resultado es: " + resultado); 


        }
    }
}
