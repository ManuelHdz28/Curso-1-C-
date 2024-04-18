using System;

class Program
{
    static void Main()
    {

        float peso = 70;
        double altura = 1.75;
        double imc;

        imc = peso / (altura * altura);
        Console.WriteLine("su masa corporal es de: " + imc);
    }
}
