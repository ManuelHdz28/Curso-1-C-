using System;

class Program
{
    static void Main()
    {
        /*
         Desarrolla un programa que solicite al usuario su nombre y su año de nacimiento. 
         Calcula la edad actual y muestra un mensaje personalizado con el nombre y la edad.
         */

        Console.WriteLine("hola, Digite su nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine(nombre + " digite su año de nacimiento: ");
        int nacimiento = Convert.ToInt32(Console.ReadLine());

        int edad = 2024 - nacimiento;
        
        Console.WriteLine(nombre + " tu edad es: " +  edad);
    }
}
