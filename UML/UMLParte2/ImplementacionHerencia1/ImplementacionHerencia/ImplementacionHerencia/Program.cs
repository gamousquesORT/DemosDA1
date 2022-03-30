/*
 * Este es un ejemplo para mostrar qué pasa cuando NO se usan los modiicadores que habilitan la herencia en C#
 */

using System;

namespace ImplementacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("-------------(1)--------------");
            Alumno a = new Alumno();
            a.Numero = 534123;
            a.Nombre = "gastón";
            Console.WriteLine("El número de estudiantes es {0} y su nombre es: {1}", a.Numero, a.Nombre);
            Console.WriteLine("El Tostring de almuno retorna - {0}", a.ToString()); // se ejecuta el de ??
          

            Console.ReadLine();

            Console.WriteLine("-------------(2)--------------");
            Docente docente = new Docente();
            docente.Nombre = "Maria";
            docente.Numero = 12345;
            docente.FechaIngereso = DateTime.Today;
            
            // Qué método se invoca en cada caso que sigue?
            // porqué no aparece la fecha de ingreso? Ayuda: ver que tipo es la variable (a) !!!!!!!
            Console.WriteLine("Los datos de la persona son - {0} ", a.ObtenerDatos());
            
            Console.ReadLine();
            
            Console.WriteLine("-------------(3)--------------");
            // Qué método se invoca en cada caso que sigue?
            // ver de qué tipo es docente?
            Console.WriteLine("Los datos del docente son {0} - ", docente.ObtenerDatos());
            
            Console.ReadLine();
            
            Console.WriteLine("-------------(4)--------------");    
            // Qué método se invoca en cada caso que sigue?
            // porque siendo un docente NO APARECE fecha de ingereso??? 
            // Ayuda: a que clase pertenece otraPersona?
            Persona otraPersona = docente;
            Console.WriteLine("Los datos del otraPersona son - {0} ", otraPersona.ObtenerDatos());

        }
    }
}