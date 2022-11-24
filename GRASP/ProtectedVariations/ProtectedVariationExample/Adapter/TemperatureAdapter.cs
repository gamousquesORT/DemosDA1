using Adapter.Implementation;

namespace Adapter;

public abstract class  TemperatureAdapter 
{

  
    // factory Method
    public static TemperatureAdapter CreateApi(string api)
    {
        TemperatureAdapter adaptee;
        if (api.Equals("Google"))
        {
            adaptee = new GoogleTemperatureAdapter();
            
        }
        else  if (api.Equals("MSFT"))
        {
            adaptee = new MCRSTemperatureAdapter();
        }
        else
        {
            throw new NotImplementedException();
        }

        return adaptee;
    }
    public virtual float GetTemperature()
    {
        return 31;
    }
}