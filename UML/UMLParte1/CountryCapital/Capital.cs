namespace ejemplosClase;

public class Capital
{
    private Country country;

    public Capital(Country country, string cityName)
    {
        this.Name = cityName;
        this.country = country;
    }

    public string Name { get; }

    public string CountryName => country.Name;

    public void setCountry(Country country)
    {
        this.country = country;
    }
}