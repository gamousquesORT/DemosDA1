// See https://aka.ms/new-console-template for more information

using Adapter;

// llama a una fabrica de proveedores de temperatura, en este caso MSFT y Google

TemperatureAdapter temperatureAdapter = TemperatureAdapter.CreateApi("MSFT");

// como se ve abajo se llama a GetTemperature y simpre contest, no importa si es MSFT o Google
Console.WriteLine("La temperatura es {0}", temperatureAdapter.GetTemperature());

temperatureAdapter = TemperatureAdapter.CreateApi("Google");

// como se ve abajo se llama a GetTemperature y simpre contest, no importa si es MSFT o Google
Console.WriteLine("La temperatura es {0}", temperatureAdapter.GetTemperature());