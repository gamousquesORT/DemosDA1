using Adapter;

namespace AdapterTestProject;

public class UnitTest1
{
    [Fact]
    public void ShouldReturn_Temperature_UsingGoogleAPI()
    {

        float expectedDegrees = 31;

        TemperatureAdapter temperatureApi = TemperatureAdapter.CreateApi("Google");
        
        float result = temperatureApi.GetTemperature();
        Assert.Equal(expectedDegrees, result);
    }
    
    [Fact]
    public void ShouldReturn_Temperature_UsingMSFTAPI()
    {

        float expectedDegrees = 32;

        TemperatureAdapter temperatureApi = TemperatureAdapter.CreateApi("MSFT");
        
        float result = temperatureApi.GetTemperature();
        Assert.Equal(expectedDegrees, result);
    }
}