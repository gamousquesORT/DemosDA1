namespace Adapter.Implementation;

public class GoogleTemperatureAdapter : TemperatureAdapter
{
    private GoogleAPI _api = new GoogleAPI();
    public override float GetTemperature()
    {
        return _api.TEMP();
    }
    
}

// esto seria la clase que goggle provee y que el Adaptador esconde
public class GoogleAPI
{
    public float TEMP() { return 31;}
}