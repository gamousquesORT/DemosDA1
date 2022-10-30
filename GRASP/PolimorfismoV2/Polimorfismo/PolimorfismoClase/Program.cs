// See https://aka.ms/new-console-template for more information

using ImplementationClase;

List<Procesador> procesadorasPendientes = new List<Procesador>();

// se crean las procesadoras utilziando un METODO fábrica
procesadorasPendientes.Add(Procesador.Create(Procesador.Ordenador.PRIORIDAD));
procesadorasPendientes.Add(Procesador.Create(Procesador.Ordenador.FECHA));
procesadorasPendientes.Add(Procesador.Create(Procesador.Ordenador.MONTO));

try
{
    // Código Polimórfico
    foreach (var proc in procesadorasPendientes)
    {
        string respuesta = proc.Procesar();
        Console.WriteLine("Llama procesar {0}", respuesta);
    }
}
catch (NotImplementedException e)
{
    Console.WriteLine(e.Message);
}