// See https://aka.ms/new-console-template for more information

using PolimorfismoInterfaz;

List<IProcesador> procesadorasPendientes = new List<IProcesador>();

procesadorasPendientes.Add(new ProcesadorPorMonto());
procesadorasPendientes.Add(new ProcesadorPorPrioridad());
procesadorasPendientes.Add(new ProcesadorPorFecha());

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