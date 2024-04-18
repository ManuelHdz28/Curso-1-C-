using System;

class Program
{
    static void Main()
    {

        /*
         * Desarrolla un programa que pida al usuario dos números enteros. 
           Luego, intercambia los valores de las variables y muestra los resultados antes y 
           después del intercambio.
         */

        Console.WriteLine("escriba el primer numero entero: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("escriba el segundo numero entero: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("numeros antes del cambio:");
        Console.WriteLine("numero 1 = " + numero1);
        Console.WriteLine("numero 2 = " + numero2);

        int cambioNumero = numero1;
        numero1 = numero2;
        numero2 = cambioNumero;

        Console.WriteLine("numeros despues del cambio: ");
        Console.WriteLine("numero 1 = " + numero1);
        Console.WriteLine("numero 2 = " + numero2);
    }
}
