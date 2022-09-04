using System;
// emo interfaz e implementacion
namespace CarData {
    public class Program {
       static void Main(string[] args)
        {
            ICarData ecar = new ElectricCar();
            ICarData fcar = new GasolineCar();

            //ecar.BatteryType = "lithium-ion";
            //fcar.Cylinders = 8;
            
            Console.WriteLine("\nElectrico --> Consumo= {0:F} Watts Velocidad= {1:F} Km/h\n\n", ecar.AutonomyKm(2), ecar.CurrentSpeed(2));

            Console.WriteLine("Nafta --> Consumo= {0:F} LTs. Velocidad= {1:F} Km/h\n\n", fcar.AutonomyKm(2), fcar.CurrentSpeed(2));

            ElectricCar anotherEcar = new ElectricCar();
            anotherEcar.BatteryType = "lithium-ion";
            Console.WriteLine("\nElectrico --> Consumo= {0:F} Watts Velocidad= {1:F} Km/h\n\n", anotherEcar.AutonomyKm(2), anotherEcar.CurrentSpeed(2));

            GasolineCar anotherGCar = new GasolineCar();
            anotherGCar.Cylinders = 8;
            Console.WriteLine("Nafta --> Consumo= {0:F} LTs. Velocidad= {1:F} Km/h\n\n", anotherGCar.AutonomyKm(2), anotherGCar.CurrentSpeed(2));


        }
    }
}