using PolimorfismoClase;
namespace PolimorfismoClaseTest;

public class ProcesarTransaccionesTests
{
    private ManejardorTransaccionesPendientes mtp = new ManejardorTransaccionesPendientes();
    
    [Fact]
    public void ShouldReturnMontoGivenProcesarPorMonto()
    {
        Procesador pm = new ProcesadorPorMonto();
        string result = mtp.ProcesarPendientes(pm);
        Assert.Equal("Monto", result);
    }
    
    [Fact]
    public void ShouldReturnPrioridadGivenProcesarPorPrioridad()
    {
        Procesador pm = new ProcesadorPorPrioridad();
        string result = mtp.ProcesarPendientes(pm);
        Assert.Equal("Prioridad", result);
    }
    
      [Fact]
       public void ShouldReturnFechadGivenProcesarPorFecha()
       {
           Procesador pm = new ProcesadorPorFecha();
           Assert.Throws<NotImplementedException>(() => mtp.ProcesarPendientes(pm));
           
  //         string result = mtp.ProcesarPendientes(pm);
  //         Assert.Equal("Fecha", result);
       }
       
}