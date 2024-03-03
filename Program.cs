using System;

namespace ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Descripción: Una aplicación de consola que calcula la propina basada en el monto total de la factura
            //y el porcentaje de propina ingresado por el usuario.

            Console.WriteLine("Calcular el porcentaje de la propina");

            Console.WriteLine("Ingrese el monto total");
            double montoA = double.Parse(Console.ReadLine());

            Console.WriteLine("El la cantidad de propina");
            double totalPropina = double.Parse(Console.ReadLine());

            double porcentajePropina = (totalPropina / montoA) * 100;

            Console.WriteLine($"El porcentaje de la propina fue de {porcentajePropina}%");

            Console.ReadKey();

        }
    }
}
