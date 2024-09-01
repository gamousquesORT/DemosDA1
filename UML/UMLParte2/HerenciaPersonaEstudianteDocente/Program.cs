// See https://aka.ms/new-console-template for more information

using HerenciaPersonaEstudianteDocente;

Console.WriteLine("--- Llamada a ObtenerDatos");
foreach(Persona p in LoadData())
{
    Console.WriteLine(p.ObtenerDatos());
}

Console.WriteLine("\n--- Llamada a ToString");
foreach(Persona p in LoadData())
{
    Console.WriteLine(p.ToString());
}


List<Persona> LoadData()
{
    List<Persona> personas = new List<Persona>();

    personas.Add(new Alumno("Juan", 123));
    personas.Add(new Docente(DateTime.Today,"Pedro", 456));
    personas.Add(new Alumno("Maria", 789));
    personas.Add(new Docente(DateTime.Today,"Ana", 101112));
    personas.Add(new Persona("Carlos", 131415));

    return personas;    
}   