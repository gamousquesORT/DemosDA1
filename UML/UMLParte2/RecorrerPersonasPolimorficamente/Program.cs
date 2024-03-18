using System;

namespace ImplementacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------(1)--------------");
            // Qué método se invoca en cada caso que sigue?
            Alumno alumno = new Alumno();
            alumno.Numero = 534123;
            alumno.Nombre = "gastón";
            Console.WriteLine("Obtener Datos de: {0}", alumno.ObtenerDatos());

            Console.ReadLine();
            
            Console.WriteLine("-------------(2)--------------");
            Docente docente = new Docente();
            docente.Nombre = "Maria";
            docente.Numero = 12345;
            docente.FechaIngereso = DateTime.Today;
            
            // Qué método se invoca en cada caso que sigue?
            Console.WriteLine("Obtener Datos de: {0} ", docente.ObtenerDatos());
            
            Console.ReadLine();
            
            Console.WriteLine("-------------(3)--------------");
            
            // se puede hacer esto? qué método se invoca?
            Persona otraPersona = docente;
            Console.WriteLine("Obtener Datos de otra persona (el docente) son {0} ", otraPersona.ObtenerDatos());

        }
    }
}