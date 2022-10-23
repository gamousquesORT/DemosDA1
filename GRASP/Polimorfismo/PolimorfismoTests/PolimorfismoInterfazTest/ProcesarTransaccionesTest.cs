using System.Reflection.Metadata.Ecma335;
using PolimorfismoInterfaz;
namespace PolimorfismoInterfazTest;

public class ProcesarTransaccionesTests
{
    private ManejardorTransaccionesPendientes mtp = new ManejardorTransaccionesPendientes();
    
    [Fact]
    public void ShouldReturnMontoGivenProcesarPorMonto()
    {
        IProcesador pm = new ProcesadorPorMonto();
        string result = mtp.ProcesarPendientes(pm);
        Assert.Equal("Monto", result);
    }
    
    [Fact]
    public void ShouldReturnPrioridadGivenProcesarPorPrioridad()
    {
        IProcesador pm = new ProcesadorPorPrioridad();
        string result = mtp.ProcesarPendientes(pm);
        Assert.Equal("Prioridad", result);
    }
    
/*    [Fact]
    public void ShouldReturnFechadGivenProcesarPorFecha()
    {
        IProcesador pm = new ProcesadorPorFecha();
        string result = mtp.ProcesarPendientes(pm);
        Assert.Equal("Fecha", result);
    }
    */
}