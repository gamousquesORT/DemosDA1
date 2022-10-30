using PolimorfismoInterfaz;
using ImplementacionInterfaz;

        
IProcesadoraFactory factory = new ProcesadoraFactory();
ManejardorTransaccionesPendientes mProcPend = new ManejardorTransaccionesPendientes();
mProcPend.ProcesarPendientes(factory);

