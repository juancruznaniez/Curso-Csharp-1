using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {
            // * * FOR CON FOR //

            // int n, acu, promedio;

            // for (int x = 0; x < 10; x++)
            // {
            //     acu = 0;
            //     for (int y = 0; y < 20; y++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     promedio = acu / 20;
            //     Console.WriteLine("El promedio de edad es: " + promedio);
            // }




            // * * FOR CON WHILE //

            // for (int i = 0; i < 10; i++)
            // {
            //     int n, acu, con, promedio;

            //     Console.WriteLine("Ingrese la edad: ");
            //     n = int.Parse(Console.ReadLine());

            //     acu = 0; // fuera del ciclo inicio en 0, luego acumulo.
            //     con = 0;
            //     while (n != 0) // Mientras n sea distinto de 0 te voy a seguir pidiendo la edad.
            //     {
            //         acu += n; // Por cada persona voy a acumular, += la edad.
            //         con++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     promedio = acu / con;
            //     Console.WriteLine("El promedio es: " + promedio);
            // }

            // * * WHILE CON FOR //

            // int n, promedio, acu;
            // Console.WriteLine("Ingrese 1 para comenzar a procesar, o ingrese 0 para terminar: ");
            // n = int.Parse(Console.ReadLine());

            // while (n != 0)
            // {
            //     acu = 0;
            //     for (int i = 0; i < 20; i++)
            //     {
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //         acu += n;
            //     }
            //     promedio = acu / 20;
            //     Console.WriteLine("El promedio es: " + promedio);
            //     Console.WriteLine("Ingrese 1 para comenzar nuevamente o ingrese 0 para finalizar.");
            //     n = int.Parse(Console.ReadLine());
            // }

            // * * WHILE CON WHILE //
            // int n, con, acu, promedio;

            // Console.WriteLine("Ingrese la edad: ");
            // n = int.Parse(Console.ReadLine());
            // while (n > 0)
            // {
            //     acu = 0; // fuera del ciclo inicio en 0, luego acumulo.
            //     con = 0;
            //     while (n != 0) // Mientras n sea distinto de 0 te voy a seguir pidiendo la edad.
            //     {
            //         acu += n; // Por cada persona voy a acumular, += la edad.
            //         con++;
            //         Console.WriteLine("Ingrese la edad: ");
            //         n = int.Parse(Console.ReadLine());
            //     }
            //     promedio = acu / con;
            //     Console.WriteLine("El promedio es: " + promedio);

            //     Console.WriteLine("Ingrese la edad para continuar, o un negativo para cortar: "); // * * Se utiliza esto ya que estamos utilizando el 0 en las dos false del ciclo while.
            //         n = int.Parse(Console.ReadLine());
            // }


            // * * CORTE DE CONTROL //
            // Legajo, edad, sueldo, código equipo(númerico entre 1 y 50)
            int legajo, edad, codigoEquipo;
            float sueldo;
            int equipoActual;

            // Código de equipo
            // 1 River
            // 2 Boca
            // 3 Independiente

            Console.WriteLine("Ingrese el legajo: ");
            legajo = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la edad: ");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el sueldo: ");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el código de equipo: ");
            codigoEquipo = int.Parse(Console.ReadLine());

            while (sueldo > 0)
            {
                equipoActual = codigoEquipo;
                while (codigoEquipo == equipoActual)
                {
                    // Aca procesamos

                    Console.WriteLine("Ingrese el legajo: ");
                    legajo = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la edad: ");
                    edad = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el sueldo: ");
                    sueldo = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese el código de equipo: ");
                    codigoEquipo = int.Parse(Console.ReadLine());
                }
            }



        }
    }
}
