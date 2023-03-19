using System;
namespace EjemploConstructores 
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1- Creo una persona SIN argumentos");
            Persona persona = new Persona();
            Console.WriteLine(persona.ToString()+"\n");
            Console.ReadLine();

            Console.WriteLine("2- Creo una persona CON argumentos");
            persona = new Persona("5.456.456-1", "Pedro Casas");
            Console.WriteLine(persona.ToString()+"\n");
            Console.ReadLine();

            Console.WriteLine("3- Creo un funcionario SIN argumentos");
            Empleado empleado = new Empleado();
            Console.WriteLine(empleado.ToString()+"\n");
            Console.ReadLine();

            Console.WriteLine("4- Creo un funcionario CON argumentos");
            empleado = new Empleado("6.342.123-0", "María Casas", 34567);
            Console.WriteLine(empleado.ToString()+"\n");
            Console.ReadLine();
        }
    }
}
