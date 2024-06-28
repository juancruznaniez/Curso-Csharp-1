using System;

namespace Vectores
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO:  VECTORES. ARRAY. ARREGLO

            int n;
            int[] numeros = new int [10]; // Asi se genera un Vector.
            //  0 1 2 3 4 5 6 7 8 9
            // |7| | | | | |1| | | |      // ---->> estos son los indices de memoria del vector.

            // * * Forma clásica de cargar el vector.
            // numeros[6] = 1;
            // numeros[0] = 7;

            // n = numeros[6] + numeros[0];

            // * * Forma de carga por ciclo for.

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese su nota... ");
            //     n = int.Parse(Console.ReadLine());
            //     numeros[x] = n; // va a cargar segun las vueltas que de el x del ciclo, en este caso son 10 notas (10 vueltas).
            // }

            // // Sacar promedio

            // int acu = 0, promedio;

            // for (int x = 0; x < 10; x++)
            // {
            //     acu += numeros[x]; // Entonces el acumulador va a acumular todas las notas que pasaron por el vector en el ciclo anterior.
            // }

            // promedio = acu / 10;

            // Console.WriteLine("Su promedio de notas es: " + promedio);

            // * * <<<---------------------------------------------------------------------------------------------------------------------------------------------------------------->>>

            // TODO: VECTORES DOUBLE.

            // int (long, short) --> hermanos
            // float - double - decimal --> hermanos.

            double[] muestraMatutina = new double[31]; // ej, para poder cargar la temperatura para cada mañana de los dias del mes.
            double[] muestraVespertina = new double[31];
            double[] muestraNocturna = new double[31];
            int dia;
            double temperatura;


            // * Registro Matutino
            Console.WriteLine("Ingrese el registro matutino: ");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese el dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la temperatura registrada: ");
                temperatura = double.Parse(Console.ReadLine());

                muestraMatutina[dia-1] = temperatura; // utilizo la variable dia porque puede ser que se carguen los dias de forma desordenada. Entonces al utilizar la variable dia se guardan correctamente en el vector. El -1 es porque el vector comienza en 0 y los dias van hasta 31.
            }

            // * Registro Vespertino
            Console.WriteLine("Ingrese el registro vespertino: ");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese el dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la temperatura registrada: ");
                temperatura = double.Parse(Console.ReadLine());

                muestraVespertina[dia-1] = temperatura;
            }

            // * Registro Noxturno
            Console.WriteLine("Ingrese el registro nocturno: ");
            for (int x = 0; x < 31; x++)
            {
                Console.WriteLine("Ingrese el dia: ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la temperatura registrada: ");
                temperatura = double.Parse(Console.ReadLine());

                muestraNocturna[dia-1] = temperatura;
            }

            // * * Leer vectores

            double acu = 0;
            double promedio;

            for (int x = 0; x < 31; x++)
            {
                acu += muestraMatutina[x];
            }

            promedio = acu / 31;

            Console.WriteLine("El promedio de temperatura matutina del mes es de: " + promedio + " ºC");
        }
    }
}
