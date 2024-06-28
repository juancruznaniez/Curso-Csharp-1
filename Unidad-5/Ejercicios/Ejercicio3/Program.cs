using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

            int edad, promedio, con = 0, acu = 0;

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Ingrese su edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    acu += edad;
                    con++;
                }
            }
            promedio = acu / con;


            Console.WriteLine("El promedio de edad de personas mayores es: " + promedio);
        }
    }
}
