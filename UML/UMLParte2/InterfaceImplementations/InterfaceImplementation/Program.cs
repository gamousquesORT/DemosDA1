using System;

namespace CarData {
    public class Program {
       static void Main(string[] args)
        {
            ICarData ecar = new ElectricCar();
            ICarData fcar = new GasolineCar();

            Console.WriteLine("\nElectrico --> Consumo= {0:F} Watts Velocidad= {1:F} Km/h\n\n", ecar.AutonomyKm(2), ecar.CurrentSpeed(2));

            Console.WriteLine("Nafta --> Consumo= {0:F} LTs. Velocidad= {1:F} Km/h\n\n", fcar.AutonomyKm(2), fcar.CurrentSpeed(2));
           
        }
    }
}