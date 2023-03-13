namespace ejemplosClase;

public class Country
{
    public Country(string countryName, string capitalName)
    {
        Name = countryName;
        Capital = new Capital(this, capitalName);
    }

    public string Name { get; }

    public string CapitalName => Capital.Name;

    public Capital Capital { get; }
}