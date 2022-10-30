// See https://aka.ms/new-console-template for more information

using PolimorfismoInterfaz;

// necesito crear una clase fabrica de Procesadoras
ProcesadoraFactory factory = new ProcesadoraFactory();

List<IProcesador> procesadorasPendientes = new List<IProcesador>();

// se crean las instancias de las procesadoras usando la fabrica
procesadorasPendientes.Add(factory.Create(ProcesadoraFactory.Ordenador.FECHA));
procesadorasPendientes.Add(factory.Create(ProcesadoraFactory.Ordenador.MONTO));
procesadorasPendientes.Add(factory.Create(ProcesadoraFactory.Ordenador.PRIORIDAD));

try {
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