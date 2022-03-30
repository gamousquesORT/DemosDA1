using System;

namespace EjemploHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creo una persona");
            Persona persona = new Persona();
            Console.WriteLine(persona.ToString());
            Console.WriteLine();

            Console.WriteLine("Creo un estudiante");
            Estudiante estudiante = new Estudiante("Ana", 5432);
            Console.WriteLine(estudiante.ToString());
            Console.WriteLine();

            Console.WriteLine("Creo un empleado");
            Empleado empleado = new Empleado("Gerente");
            Console.WriteLine(empleado.ToString());
            Console.WriteLine();

            Console.WriteLine("Sintaxis C#");
            Empleado empleado2 = new Empleado() { Nombre = "Juan", Cargo = "Gerente", NumeroEmpleado = 1234 };
            Console.WriteLine(empleado2.ToString());

            Console.ReadLine();
        }
    }
}