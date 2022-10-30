namespace ImplementationClase;

public abstract class Procesador
{
    public abstract string Procesar();

    public enum Ordenador
    {
        FECHA,
        MONTO,
        PRIORIDAD
    };

    
    public static Procesador Create(Procesador.Ordenador e)
    {
        Procesador? retVal  = null;
        switch (e)
        {
            case Ordenador.FECHA :
                retVal =  new ProcesadorPorFecha();
                break;
            case Ordenador.MONTO:
       
                retVal =  new ProcesadorPorMonto();
                break;
            case Ordenador.PRIORIDAD:
       
                retVal =  new ProcesadorPorPrioridad();
                break;
            default:
                retVal =  new ProcesadorPorPrioridad();
                break;
        }

        return retVal;

    }

}