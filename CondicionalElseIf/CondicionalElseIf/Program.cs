using System;

class Program
{
    static void Main()
    {
        // CONDICIONAL ELSEIF

        Console.WriteLine("Ingresa tu Edad: ");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad <= 0)
        {
            Console.WriteLine("La edad no es valida");
        }else if (edad <= 12)
        {
            Console.WriteLine("Eres un niño");
        }else if(edad <= 18)
        {
            Console.WriteLine("Eres un Adolecente");
        }else if (edad <= 30)
        {
            Console.WriteLine("Eres un adulto joven");
        }else
        {
            Console.WriteLine("eres un adulto");
        }
    }
}
