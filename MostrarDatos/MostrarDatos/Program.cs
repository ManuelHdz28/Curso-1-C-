using System;

class Program
{
    static void Main()
    {
        // formas para mostrar los datos al usuario

        string nombre = "Ana";
        int edad = 20;

        Console.WriteLine(nombre);//forma 1

        Console.WriteLine("nombre: " + nombre); // forma 2

        Console.Write("nombre: "); //forma 3 el write no pone salto de linea
        Console.WriteLine(nombre);

        Console.WriteLine($"Nombre: {nombre}"); // forma 4: concatenar datos

        Console.WriteLine("Nombre: {0} - Edad: {1}", nombre , edad); // forma 5: sirve para arrays


    }
}
