using System;

namespace DemosClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person("Gastón");

            Person personB = new Person("Gastón");

            
            Console.WriteLine( (personA == personB)); //??
            Console.WriteLine( personA.Name == personB.Name); //
        }
    }
}
//            Console.WriteLine( personA.Equals(personB)); //??