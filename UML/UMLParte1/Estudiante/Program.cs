using System;

namespace ejemplosClase;

internal class Program
{
    private static void Main(string[] args)
    {
        var est1 = new Estudiante();
        est1.Nombre = "Gaston";
        est1.FechaIngreso = DateTime.Today;
        est1.Celular = "598989765";

        var est2 = new Estudiante();
        est2.Nombre = "María José";
        est2.FechaIngreso = DateTime.Today;
        est2.Celular = "598989796";

        Console.WriteLine("Número: {0} - Nombre: {1} - Fecha: {2} - celular: {3}", est1.NumeroEstudiante, est1.Nombre,
            est1.FechaIngreso, est1.Celular);
        Console.WriteLine("Número: {0} - Nombre: {1} - Fecha: {2} - celular: {3}", est2.NumeroEstudiante, est2.Nombre,
            est2.FechaIngreso, est2.Celular);
        Console.WriteLine("proximo numero {0}", Estudiante.GetProximoEstudiante());
        Console.WriteLine("--------- ---- ---------[enter]");

        Console.ReadLine();
        
        var est3 = new Estudiante();
        est3.Nombre = "María José";
        est3.FechaIngreso = DateTime.Today;
        est3.Celular = "598989796";
        Console.WriteLine("est1 == est3? {0} ", est1 == est3);
        Console.WriteLine("--------- ---- ---------[enter]");
        Console.WriteLine("est1.Nombre == est3.Nombre? {0} ", est1.Nombre == est3.Nombre);
    }
}