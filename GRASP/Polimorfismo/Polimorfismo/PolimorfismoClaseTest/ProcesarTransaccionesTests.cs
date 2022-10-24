using PolimorfismoClase;
namespace PolimorfismoClaseTest;

public class ProcesarTransaccionesTests
{
    
    [Fact]
    public void ShouldReturnMontoGivenProcesarPorMonto()
    {
        Procesador pm = new ProcesadorPorMonto();
        string result = pm.Procesar();
        Assert.Equal("Monto", result);
    }
    
    [Fact]
    public void ShouldReturnPrioridadGivenProcesarPorPrioridad()
    {
        Procesador pm = new ProcesadorPorPrioridad();
        string result = pm.Procesar();
        Assert.Equal("Prioridad", result);
    }
    
      [Fact]
       public void ShouldReturnFechadGivenProcesarPorFecha()
       {
           Procesador pm = new ProcesadorPorFecha();
           string result = pm.Procesar();
          Assert.Equal("Fecha", result);
       }
       
}