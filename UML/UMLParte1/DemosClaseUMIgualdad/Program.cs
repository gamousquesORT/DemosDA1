using System;

namespace DemosClase;

internal class Program
{
    private static void Main(string[] args)
    {
        var personA = new Person("Gastón");

        var personB = new Person("Gastón");


        Console.WriteLine(personA == personB); //??
        Console.WriteLine(personA.Name == personB.Name); //
    }
}
//            Console.WriteLine( personA.Equals(personB)); //??