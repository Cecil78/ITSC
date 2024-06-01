using System;

namespace EJconversion29
{
    public class Program
    {
        static void Main(string[] args)
        {
            double Metros = 1609.344; //Una milla = 1609.344 metros
            double Kilometros = 1.60934; //Una milla = 1.60934 kilómetros
            double resultado;
            int numeroMilla;
            Console.WriteLine("Ingrese las millas que desea convertir \n");

            numeroMilla = Convert.ToInt32(Console.ReadLine());
            resultado = numeroMilla * Metros;

            Console.WriteLine("{0} millas es igual a {1} metros",
            numeroMilla, resultado);

            resultado = numeroMilla * Kilometros;

            Console.WriteLine("{0} millas es igual a {1} kilometros", numeroMilla, resultado);

            Console.ReadKey();
        }
    }
}

