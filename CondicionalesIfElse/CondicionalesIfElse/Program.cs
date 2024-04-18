using System;

class Program
{
    static void Main()
    {
        //condicional IF y ELSE
        Console.WriteLine("Ingrese su edad");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad >= 18) {
            Console.WriteLine("Eres Mayor de Edad. Puedes Acceder");
        }else { Console.WriteLine("Erese Menor de Edad. No Puedes Acceder"); }
    }
}
