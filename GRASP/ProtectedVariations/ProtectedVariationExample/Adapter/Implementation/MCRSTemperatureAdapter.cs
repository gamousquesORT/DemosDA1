namespace Adapter.Implementation;

public class MCRSTemperatureAdapter : TemperatureAdapter
{
    private MSFTWeatherApi _api = new MSFTWeatherApi();
    public override float GetTemperature()
    {
        return _api.GetMSWeatherTemp();
    }

}

public class MSFTWeatherApi
{
    public float GetMSWeatherTemp()
    {
        return 32;
    }
}