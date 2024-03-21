using System;

namespace ImplementacionHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> personas = new List<Persona>();
            
            CrearPersonas(personas);
            ListarPersonas(personas);
            
        }

        private static void CrearPersonas(List<Persona> personas)
        {
            Alumno alumno = new Alumno();
            alumno.Numero = 534123;
            alumno.Nombre = "gastón";
            personas.Add(alumno);
            
            Docente docente = new Docente();
            docente.Nombre = "Maria";
            docente.Numero = 12345;
            docente.FechaIngereso = DateTime.Today;
            personas.Add(docente);
            
            // solo para mostrar otra forma de inicializar
            docente = new Docente{Nombre = "Jose Enrique Rodo", Numero = 12345, FechaIngereso = DateTime.Today};
            personas.Add(docente);
            
            alumno = new Alumno{Nombre = "Jimena Diaz", Numero = 54321};
            personas.Add(alumno);
        }
        
        
        private static void ListarPersonas(List<Persona> personas)
        {
            int index = 1;
            foreach (Persona p in personas)
            {
                index++;
                Console.WriteLine("{0} -> {1}", index, p.ObtenerDatos());
            }
        }

    }
}