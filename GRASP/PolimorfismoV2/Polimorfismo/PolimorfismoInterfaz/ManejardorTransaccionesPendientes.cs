namespace PolimorfismoInterfaz;

// not used. If you want to preserve the original design you could use it.
public class ManejardorTransaccionesPendientes
{
    public string ProcesarPendientes(IProcesador procesador)
    {
        return procesador.Procesar();
    }
}