using System;

namespace ImplementacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------(1)--------------");
            // Qué método se invoca en cada caso que sigue?
            Alumno a = new Alumno();
            a.Numero = 534123;
            a.Nombre = "gastón";
            Console.WriteLine("El número de estudiantes es {0} y  su nombre es: {1}", a.Numero, a.Nombre);
            Console.WriteLine("El Tostring retorna: {0}", a.ToString());

            Console.ReadLine();
            
            Console.WriteLine("-------------(2)--------------");
            Docente docente = new Docente();
            docente.Nombre = "Maria";
            docente.Numero = 12345;
            docente.FechaIngereso = DateTime.Today;
            
            // Qué método se invoca en cada caso que sigue?
            Console.WriteLine("Los datos de la persona son {0} ", a.ObtenerDatos());
            
            Console.ReadLine();
            
            Console.WriteLine("-------------(3)--------------");
            
            // nota que el obtener datos escribe 2 veces? porqué?
            Console.WriteLine("Los datos del docente son : {0} ", docente.ObtenerDatos());
            
            Console.ReadLine();
            

            Console.WriteLine("-------------(4)--------------");
            // se puede hacer esto? qué método se invoca?
            Persona otraPersona = docente;
            Console.WriteLine("Los datos de la otra persona (el docente) son {0} ", otraPersona.ObtenerDatos());

        }
    }
}