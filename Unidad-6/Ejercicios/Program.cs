using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: 1. Hacer un programa para ingresar 10 números. El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.

            // * * Resolución con 1 ciclo //

            // int n, con = 0;

            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine("Ingrese un número: ");
            //     n = int.Parse(Console.ReadLine());

            //     if(n % 2 != 0){
            //         con++;
            //     }
            // }

            // Console.WriteLine("La cantidad total de nros primos es: " + con);


            // * * Resolución con 2 ciclos //
            // * Si el nro fue divisible 2 veces es primo, si fue divisible mas veces no lo es.
            // int n, con, conPrimos = 0;

            // for (int x = 0; x < 10; x++)
            // {
            //     Console.WriteLine("Ingrese un número: ");
            //     n = int.Parse(Console.ReadLine());
            //     con = 0;
            //     for (int y = 1; y <= n; y++)
            //     {
            //         if (n % y == 0)
            //             con++;
            //     }
            //     if (con == 2) // Si es divisible 2 veces es primo.
            //         conPrimos++;

            // }
            // Console.WriteLine("Los números primos son en total: " + conPrimos);

            // * <<<--------------------------------------------------------------------------------------------------------------------------->>

            // TODO: 2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros. Se pide determinar e informar:
            // TODO:       El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
            // TODO:       Informar cuántos grupos están formados por todos números ordenados de mayor a menor.

            // int n, conImpares, conNumeros, grupoimparesMaximo = 0, min, contadorOrdenados = 0;
            // double porcentajeImpares, porcentajeMaximo = -1;
            // bool banderaOrdenados;

            // for (int x = 0; x < 5; x++)
            // {
            //     conNumeros = 0;
            //     conImpares = 0;
            //     banderaOrdenados = true; // la inicializo en true porque voy a asumir que los valores estan ordenados.
            //     Console.WriteLine("Ingrese un número: ");
            //     n = int.Parse(Console.ReadLine());
            //     min = n;
            //     while (n != 0) //Si el nro es distinto de 0 quiere decir que te puedo pedir otro número.
            //     {
            //         conNumeros++;
            //         if (n % 2 != 0)
            //         {
            //             conImpares++;

            //             // punto b
            //             if (n <= min)
            //                 min = n;
            //             else
            //                 banderaOrdenados = false;
            //         }
            //         n = int.Parse(Console.ReadLine()); // Para solucionarlo, debes mover la línea n = int.Parse(Console.ReadLine()); fuera del bloque if. Así el programa solicitará un nuevo número en cada iteración del bucle while, independientemente de si el número anterior fue par o impar
            //     }
            //     porcentajeImpares = conImpares * 100 / conNumeros;
            //     if (porcentajeImpares > porcentajeMaximo)
            //     {
            //         porcentajeMaximo = porcentajeImpares;
            //         grupoimparesMaximo = x + 1;
            //     }
            //     // punto b
            //     if (banderaOrdenados) // No se pone el true porque es un bool y su valor solo es true o false. Ya le di el true con anterioridad..
            //         contadorOrdenados++;
            // }

            // Console.WriteLine("El grupo con mayor número de impares es: " + grupoimparesMaximo);
            // Console.WriteLine("La cantidad de grupos con nros ordenados es: " + contadorOrdenados);

            // * <<<--------------------------------------------------------------------------------------------------------------------------------------------------->>>

            // TODO: 3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero. El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.

            int n, contador, contadorGrupos = 0; // Si yo pongo que n es igual a 1 va a entrar a la primer vuelta si o si


            do
            {
                contadorGrupos++;
                contador = 0;
                Console.WriteLine("Ingrese un número: ");
                n = int.Parse(Console.ReadLine());

                while (n > 0)
                {
                    n = int.Parse(Console.ReadLine());
                    contador++;
                }

                Console.WriteLine("La cantidad del grupo " + contadorGrupos + " es de " + contador + " Números");
            } while (n >= 0);



        }
    }
}