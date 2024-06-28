using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y la velocidad promedio de un vehículo. Calcular y emitir por pantalla el tiempo aproximado que demandará llegar de un punto a otro teniendo en cuenta los datos ingresados.

            int kilómetros, velocidad, resultado;

            Console.WriteLine("Ingrese kilómetros: ");
            kilómetros = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese velocidad prom de su vehiculo: ");
            velocidad = int.Parse(Console.ReadLine());

            resultado = kilómetros / velocidad;
            Console.WriteLine("Su tiempo en llegar a destino será: " + resultado + " Horas ");
        }
    }
}
