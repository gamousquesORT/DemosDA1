using PolimorfismoClase.implementation;
namespace PolimorfismoClase;


// not used. If you want to preserve the original design you could use it.
public class ManejardorTransaccionesPendientes
{
    public string ProcesarPendientes(Procesador procesador)
    {
        return procesador.Procesar();
    }
}