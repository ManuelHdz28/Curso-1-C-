using System;

class Program
{
    static void Main()
    {

        //entrada de teclado
        Console.WriteLine("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();//para que el usuario escriba

        Console.WriteLine("ingresa tu edad: ");
        int edad =  Convert.ToInt32(Console.ReadLine());// los tipos numericos se tienen que convertir antes

        
        Console.WriteLine("hola " + nombre + " Tienes " + edad + " años.");
        
    }
}
