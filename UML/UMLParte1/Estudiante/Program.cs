using System;

namespace ejemplosClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Estudiante est1 = new Estudiante();
            est1.Nombre = "Gaston";
            est1.FechaIngreso = DateTime.Today;

            Estudiante est2 = new Estudiante();
            est2.Nombre = "María José";
            est2.FechaIngreso = DateTime.Today;

            Console.WriteLine("Número: {0} - Nombre: {1} - Fecha: {2}", est1.NumeroEstudiante, est1.Nombre, est1.FechaIngreso);
            Console.WriteLine("Número: {0} - Nombre: {1} - Fecha: {2}", est2.NumeroEstudiante, est2.Nombre, est2.FechaIngreso);
            Console.WriteLine("proximo numero {0}", Estudiante.GetProximoEstudiante());
        }
    }
}