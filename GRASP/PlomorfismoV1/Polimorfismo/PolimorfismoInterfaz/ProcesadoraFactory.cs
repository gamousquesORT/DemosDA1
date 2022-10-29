namespace PolimorfismoInterfaz;

public class ProcesadoraFactory
{
    
    public enum Ordenador
    {
        FECHA,
        MONTO,
        PRIORIDAD
    };

    
    public  IProcesador Create(ProcesadoraFactory.Ordenador e)
    {
        IProcesador? retVal  = null;
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