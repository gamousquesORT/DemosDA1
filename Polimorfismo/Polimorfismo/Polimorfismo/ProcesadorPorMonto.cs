namespace Polimorfismo;

public class ProcesadorPorMonto : IProcesador
{
    public virtual string Procesar()
    {
        return "Monto";
    }
}