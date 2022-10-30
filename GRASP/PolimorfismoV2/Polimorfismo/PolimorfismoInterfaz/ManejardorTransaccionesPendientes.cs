using System.Security.Cryptography;

namespace PolimorfismoInterfaz;

// not used. If you want to preserve the original design you could use it.
public class ManejardorTransaccionesPendientes
{
    public void ProcesarPendientes(IProcesadoraFactory factory)
    {
        List<IProcesar> procesadorasPendientes = new List<IProcesar>();
        
        procesadorasPendientes.Add(factory.Create(IProcesadoraFactory.Ordenador.FECHA));
        procesadorasPendientes.Add(factory.Create(IProcesadoraFactory.Ordenador.MONTO));
        procesadorasPendientes.Add(factory.Create(IProcesadoraFactory.Ordenador.PRIORIDAD));

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
    }
}