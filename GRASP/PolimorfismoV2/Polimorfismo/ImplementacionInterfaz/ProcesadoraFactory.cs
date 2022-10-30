using PolimorfismoInterfaz;

namespace ImplementacionInterfaz;

public class ProcesadoraFactory : IProcesadoraFactory
{
    public  IProcesar Create(IProcesadoraFactory.Ordenador e)
    {
        IProcesar? retVal  = null;
        switch (e)
        {
            case IProcesadoraFactory.Ordenador.FECHA :
                retVal =  new ProcesadorPorFecha();
                break;
            case IProcesadoraFactory.Ordenador.MONTO:
       
                retVal =  new ProcesadorPorMonto();
                break;
            case IProcesadoraFactory.Ordenador.PRIORIDAD:
       
                retVal =  new ProcesadorPorPrioridad();
                break;
            default:
                retVal =  new ProcesadorPorPrioridad();
                break;
        }

        return retVal;

    }

}