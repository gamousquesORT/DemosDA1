using System;
using VehicleDomain;

// demo interfaz e implementacion
namespace VehicleUI {
    public class Program {
       static void Main(string[] args)
        {
            IVehicleData ecar = new ElectricCar();
            IVehicleData fcar = new GasolineCar();
            IVehicleData robot = new Robot();
            
            //ecar.BatteryType = "lithium-ion";
            //fcar.Cylinders = 8;
            
            Console.WriteLine("\nElectrico --> Consumo= {0:F} Watts Velocidad= {1:F} Km/h\n\n", ecar.AutonomyKm(2), ecar.CurrentSpeed(2));

            Console.WriteLine("Nafta --> Consumo= {0:F} LTs. Velocidad= {1:F} Km/h\n\n", fcar.AutonomyKm(2), fcar.CurrentSpeed(2));
            
            Console.WriteLine("Robot --> Consumo= {0:F} Watts. Velocidad= {1:F} Km/h\n\n", robot.AutonomyKm(2), robot.CurrentSpeed(2));

            ElectricCar anotherEcar = new ElectricCar();
            anotherEcar.BatteryType = "lithium-ion";
            Console.WriteLine("\nElectrico --> Consumo= {0:F} Watts Velocidad= {1:F} Km/h\n\n", anotherEcar.AutonomyKm(2), anotherEcar.CurrentSpeed(2));

            GasolineCar anotherGCar = new GasolineCar();
            anotherGCar.Cylinders = 8;
            Console.WriteLine("Nafta --> Consumo= {0:F} LTs. Velocidad= {1:F} Km/h\n\n", anotherGCar.AutonomyKm(2), anotherGCar.CurrentSpeed(2));


        }
    }
}