namespace Polimorfismo;

public class ManejardorTransaccionesPendientes
{
    public string ProcesarPendientes(IProcesador procesador)
    {
        return procesador.Procesar();
    }
}