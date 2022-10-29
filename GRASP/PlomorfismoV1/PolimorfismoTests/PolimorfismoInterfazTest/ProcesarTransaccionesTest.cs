using System.Reflection.Metadata.Ecma335;
using PolimorfismoInterfaz;
namespace PolimorfismoInterfazTest;

public class ProcesarTransaccionesTests
{
   
    [Fact]
    public void ShouldReturnMontoGivenProcesarPorMonto()
    {
        IProcesador pm = new ProcesadorPorMonto();
        string result = pm.Procesar();
        Assert.Equal("Monto", result);
    }
    
    [Fact]
    public void ShouldReturnPrioridadGivenProcesarPorPrioridad()
    {
        IProcesador pm = new ProcesadorPorPrioridad();
        string result = pm.Procesar();
        Assert.Equal("Prioridad", result);
    }
    
    [Fact]
    public void ShouldReturnFechadGivenProcesarPorFecha()
    {
        IProcesador pm = new ProcesadorPorFecha();
        string result = pm.Procesar();
        Assert.Equal("Fecha", result);
    }
    
}