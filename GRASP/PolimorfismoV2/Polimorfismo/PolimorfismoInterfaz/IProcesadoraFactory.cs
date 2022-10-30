namespace PolimorfismoInterfaz;



public interface IProcesadoraFactory
{
    public enum Ordenador
    {
        FECHA,
        MONTO,
        PRIORIDAD
    };

     IProcesar Create(Ordenador e);

}