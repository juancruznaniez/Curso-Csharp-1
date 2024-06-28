// See https://aka.ms/new-console-template for more information

// TODO: 1. Hacer un programa que solicite el ingreso de 10 números y que muestre el mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.

// int n, max = 0;

// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
//     if(n > max)
//         max = n;
// }

// Console.WriteLine("El máximo es: " + max);

// * * <<<----------------------------------------------------------------------------------------------------------------------------------------------------------------->>>

// TODO: 2. Hacer un programa que solicite 20 números y calcule y emita por pantalla cuántos son positivos (mayores a cero). Se debe mostrar un solo valor: el conteo final.

// int n, con = 0;

// for (int i = 0; i < 20; i++)
// {
//     Console.WriteLine("Ingrese un nro: ");
//     n = int.Parse(Console.ReadLine());
//     if(n > 0)
//     con++;
// }
// Console.WriteLine("El total de nros positivos es: " + con);


// * * <<<----------------------------------------------------------------------------------------------------------------------------------------------------------------->>>

// TODO: 3. Hacer un programa para mostrar los números del 1 al 10. No se debe realizar ningún pedido de datos.


// for (int i = 1; i < 11; i++)
// {
// Console.WriteLine(i);
// }

// * * <<<----------------------------------------------------------------------------------------------------------------------------------------------------------------->>>

// TODO: 4. Hacer un programa para mostrar los números del 10 al 1. No se debe realizar ningún pedido de datos.

// for (int i = 10; i > 0; i--)
// {
//     Console.WriteLine(i);
// }

// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 5. Hacer un programa que muestre los números del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10, 15, 20.... 100.

// for (int x = 0; x <= 100; x += 5) // La expresión x += 5 es una forma abreviada de escribir x = x + 5.  Al utilizar x += 5, estamos incrementando el valor de x en 5 en cada iteración del bucle. Entonces, en la primera iteración, x será 0, luego 5, luego 10, y así sucesivamente, hasta que x llegue a 100.
// {
//     Console.WriteLine(x);
// }

// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 6. Hacer un programa que solicite UN número y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo. Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.

// int n;

// Console.WriteLine("Ingrese un nro: ");
// n = int.Parse(Console.ReadLine());
// if(n % 2 != 0)
//     Console.WriteLine("Es primo.");

// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 7. Hacer un programa que solicite 10 números y luego mostrar por pantalla el máximo de ellos y la posición en la que fue ingresado.

// int n, max = 0, con = 0;

// for (int i = 0; i < 10; i++)
// {   
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
    
//     if(n > max){
//         max = n;
//         con++;
//     }
//     else
//         max = max;
    
// }

// Console.WriteLine("El máximo es: " + max + " Y fue ingresado en la posición: " + con);

// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 8. Hacer un programa que solicite 20 números y luego mostrar por pantalla el menor de ellos y la posición en la que fue encontrado.

// int n, min = int.MaxValue, pos = 0; // Inicializamos min con int.MaxValue en lugar de 0 para asegurarnos de que cualquier número ingresado se considere menor al principio. Inicializamos pos a 0 para mantener el seguimiento de la posición del número mínimo.


// for (int i = 1; i <= 20; i++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
//     if(n < min){
//         min = n;
//         pos = i;
//     }
// }

// Console.WriteLine("El mínimo es: " + min + " y fue ingresado en la posición: " + pos);

// En C#, `int.MaxValue` es una constante predefinida que representa el valor máximo posible para una variable de tipo entero (`int`). Esta constante tiene un valor de 2,147,483,647.

// Al usar `int.MaxValue`, estamos inicializando la variable `min` con el valor máximo posible para un entero, lo que significa que cualquier otro número que ingresemos en el bucle será menor que este valor. Esto es útil cuando estamos buscando el mínimo de un conjunto de números y queremos asegurarnos de que el primer número ingresado se considere como el mínimo hasta que se encuentre uno menor.

// Entonces, en resumen, al inicializar `min` con `int.MaxValue`, estamos asegurándonos de que el primer número ingresado en el bucle será menor que `min`, sin importar cuál sea ese número. Esto nos permite comenzar la comparación correctamente y encontrar el mínimo adecuadamente en el resto del proceso.


// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 9. Hacer un programa que solicite 20 edades y luego calcule el promedio de edad de aquellas personas mayores a 18 años.

// int edad, mayores = 0, acu = 0;
// float promedio;

// for (int i = 0; i < 20; i++)
// {
//     Console.WriteLine("Ingrese su edad: ");
//     edad = int.Parse(Console.ReadLine());
//     if(edad > 18){
//         mayores++;
//         acu += edad;
//     }
// }
// promedio = acu / mayores;

// Console.WriteLine("El promedio de la edad en mayores es: " + promedio);

// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 10. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo de los números pares y el mínimo de los números impares.

// int n, max = 0, min = 0;
// int contadorPares = 0, contadorImpares = 0;

// for (int i = 0; i < 20; i++)
// {
//     Console.WriteLine("Ingrese un número: ");
//     n = int.Parse(Console.ReadLine());
//     if(n % 2 == 0){
//     contadorPares++;
//     if(contadorPares == 1)
//     max = n;
//     else if(n > max)
//     max = n;
//     }
//     else{
//         contadorImpares++;
//         if(contadorImpares == 1)
//         min = n;
//         else if(n < min)
//         min = n;
//     }
// }

// Console.WriteLine("El max de los pares es: " + max + " y el min de los impares es: " + min);

// * * <<<------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------>>>

// TODO: 11. Hacer un programa para ingresar 10 números y luego calcule y emita el mayor de los primos de la lista. En caso de no haber ningún número primo, deberá aclararlo con un cartel.

int n, max = 0, noHay = 1, con = 0;

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Ingrese un número: ");
    n = int.Parse(Console.ReadLine());

    if(n % 2 != 0){
        max = n;
        con++;
    if(n > max)
        max = n;  
    }
    }
    if(noHay > con){
        Console.WriteLine("No hay números primos");
    }
    Console.WriteLine("El mayor de los nros primos es: " + max);

