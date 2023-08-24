namespace EjercicioED {
    

    public class Program
    {
        static void Main(string[] args)
        {
            // Usage
            Car car = new Car {Make = "Fiat", Model = "580", NumDoors = 4};
            Motorcycle motorcycle = new Motorcycle {Make = "Harley-Davidson", Model = "Sportster", HasSidecar = false};

            Console.WriteLine("----- --------");
            Console.WriteLine("1- Maker:" + car.Make);
            Console.WriteLine("2- Model:" + car.Model);
            Console.WriteLine("3- Doors: " + car.NumDoors);
            car.Drive(); // Output: ??

            Console.WriteLine("-------------");
            Console.WriteLine("4- Maker:" + motorcycle.Make);
            Console.WriteLine("5- Model:" + motorcycle.Model);
            Console.WriteLine("6 - Sidecar:" + motorcycle.HasSidecar);
            motorcycle.Drive(); // Output: ??
            Console.WriteLine("-------------");

            Vehicle newCar = new Car {Make = "Fiat", Model = "580", NumDoors = 4};
            Vehicle newMotorcycle = new Motorcycle {Make = "Harley-Davidson", Model = "Sportster", HasSidecar = false};

            Console.WriteLine("7- Maker:" + newCar.Make);
            Console.WriteLine("8- Model:" + newCar.Model);
            //Console.WriteLine("9- Doors: " + newCar.NumDoors); 
            newCar.Drive(); // Output: ??

            Console.WriteLine("-------------");
            Console.WriteLine("10- Maker:" + newMotorcycle.Make);
            Console.WriteLine("11- Model:" + newMotorcycle.Model); // Output: ??
            //Console.WriteLine("12- Sidecar:" + newMotorcycle.HasSidecar); 
            newMotorcycle.Drive(); // Output: ??
            Console.WriteLine("-------------");

        }
    }
} 