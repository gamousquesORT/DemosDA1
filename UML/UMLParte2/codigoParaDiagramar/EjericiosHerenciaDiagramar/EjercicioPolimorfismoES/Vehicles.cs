namespace EjericiosPolimorfismo
{
    public class Vehicle
    {
        public Vehicle() {}
        public Vehicle(string make, string model)
        {
            Make = make;
            Model = model;
        }

        public string Make { get; set; }
        public string Model { get; set; }

        public void Drive()
        {
            Console.WriteLine("Vehicle is running.");
        }
        
    }

    public class Car : Vehicle
    {
        public Car():base() {}
        public Car(string make, string model, int numDoors) : base(make, model)
        {
            NumDoors = numDoors;
        }
        public int NumDoors { get; set; }
        public void Drive()
        {
            Console.WriteLine("Car is running.");
        }
    }

    public class Motorcycle : Vehicle
    {
        public Motorcycle():base() {}
        public Motorcycle(string make, string model, bool hasSidecar) : base(make, model)
        {
            HasSidecar = hasSidecar;
        }

        public bool HasSidecar { get; set; }
        public void Drive()
        {
            Console.WriteLine("Motorcycle is running.");
        }
    }  
    
}

