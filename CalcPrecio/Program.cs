using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Ingrese el precio original del producto: ");
            double precioOriginal = double.Parse(Console.ReadLine());

            if (precioOriginal > 100)
            {
                double descuento = precioOriginal * 0.10;
                double precioFinal = precioOriginal - descuento;
                Console.WriteLine($"Precio final con descuento: {precioFinal:C}");
            }
            else
            {
                Console.WriteLine($"El precio original es menor o igual a Q100. No se aplica descuento.");
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Ingrese un valor numérico válido para el precio.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error inesperado: {ex.Message}");
        }
    }
}
