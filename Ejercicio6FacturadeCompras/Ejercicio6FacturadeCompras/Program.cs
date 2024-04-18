using System;

class Program
{
    static void Main()
    {
        /*
         Implementa un programa que simule una factura de compra. Solicita al usuario el nombre del artículo, 
         la cantidad y el precio unitario. 
         Calcula el monto total y muestra una factura detallada en la consola.
         */

        Console.WriteLine("Digite el nombre del articulo:");
        string nombreArticulo = Console.ReadLine();
        Console.WriteLine("Digite la cantidad de articulos: ");
        int cantidadArticulos = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite el precio unitario del articulo: ");
        double precioUnitario = Convert.ToDouble(Console.ReadLine());

        double valorTotal = precioUnitario * cantidadArticulos;

        Console.WriteLine("el valor total de " + nombreArticulo + " es: " + valorTotal);
    }
}
