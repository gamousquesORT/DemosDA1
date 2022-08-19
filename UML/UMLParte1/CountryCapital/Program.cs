using System;

namespace ejemplosClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Country uy = new Country("Uruguay", "Montevideo");
            Console.WriteLine("preguntando al pais los datos --> Pais: {0} Capital {1} ", uy.Name, uy.CapitalName);

            //Pedimos al pais su capital
            Capital capital = uy.Capital;
            Console.WriteLine("Capital {0} ",capital.Name);
             
        }
    }
}