using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de la cantidad de litros vendidos según la siguiente escala:

            // Si vende menos de 100 litros, no hay descuento.
            // Si vende entre 101 y 300 litros, el descuento es del 10%.
            // Si vende entre 301 y 500 litros, el descuento es del 15%.
            // Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
            // Hacer un programa que solicite el ingreso del importe total de la venta y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..


            // float importeTotal, litros;
            // Console.WriteLine("Ingrese el importe de la venta: ");
            // importeTotal = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese los litros: ");
            // litros = float.Parse(Console.ReadLine());




            // (((EN ESTE EJEMPLO ME OBLIGÓ A PONER UN CONSOLE WRITELINE EN CADA IF PORQUE SINO ME DABA ERROR DE VARIABLE NO ASIGNADA)))

            // float litros, importe, importeFinal;

            // Console.WriteLine("Ingrese el importe de la venta: ");
            // importe = float.Parse(Console.ReadLine());
            // Console.WriteLine("Ingrese los litros: ");
            // litros = float.Parse(Console.ReadLine());

            // if(litros < 100){
            //     importeFinal = importe;
            //     Console.WriteLine("Su importe a pagar es: " + importeFinal);
            //     }
            // else if(litros > 100 && litros <= 300){
            //     importeFinal = importe * 0.90F;
            //     Console.WriteLine("Su importe a pagar es: " + importeFinal);
            //     }
            // else if(litros > 300 && litros <= 500){
            //     importeFinal = importe * 0.85F;
            //     Console.WriteLine("Su importe a pagar es: " + importeFinal);
            //     }
            // else if(litros > 500){
            //     importeFinal = importe * 0.75F;
            //     Console.WriteLine("Su importe a pagar es: " + importeFinal);
            //     }


            // EN ESTE EJEMPLO TODO OK.
            float litros, importe;

            Console.WriteLine("Ingrese el importe de la venta: ");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese los litros: ");
            litros = float.Parse(Console.ReadLine());

            if (litros > 500)
                importe *= 0.75F;
            else if (litros > 300)
                importe *= 0.85F;
            else if (litros > 100)
                importe *= 0.90F;

            Console.WriteLine("Su importe a pagar es: " + importe);
        }


    }
}
