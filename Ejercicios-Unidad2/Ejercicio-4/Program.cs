using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // 4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 más una comisión del 5% sobre el total facturado por cada empleado. Hacer un programa para ingresar el total facturado por un empleado y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo. 

            float comision, tfacturado, stotal;
            const float sueldoFijo = 15000;
            const float porcentajeComision = 0.05F;

            Console.WriteLine("Ingrese el total facturado: ");
            tfacturado = float.Parse(Console.ReadLine());
            comision = tfacturado * porcentajeComision; //se le agrega la F para aclarar que es un nº float y no un int, ya que tiene un peso decimal mayor

            
            stotal = comision + sueldoFijo;
            Console.WriteLine("Su sueldo es: " + stotal);
    }
}
}