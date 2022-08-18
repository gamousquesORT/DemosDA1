using System;

namespace ejemplosClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Country uy = new Country("Uruguay", "Montevideo");
            Console.WriteLine("preguntando al pais los datos --> Pais: {0} Capital {1} ", uy.Name, uy.CapitalName);

            Capital capital = uy.Capital;
            Console.WriteLine("Preguntando al pais y la a la capital -->Pais: {0} Capital {1} ", uy.Name,capital.Name);
             
        }
    }
}