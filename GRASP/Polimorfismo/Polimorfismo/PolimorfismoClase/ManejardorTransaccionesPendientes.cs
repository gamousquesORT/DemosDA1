namespace PolimorfismoClase;

public class ManejardorTransaccionesPendientes
{
    public string ProcesarPendientes(Procesador procesador)
    {
        return procesador.Procesar();
    }
}