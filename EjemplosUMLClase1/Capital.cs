namespace ejemplosClase
{
    public class Capital
    {
        private Country country;
        private string cityName;

        public Capital(Country country, string cityName)
        {
            this.cityName = cityName;
            this.country = country     ;
        }

        public string Name
        {
            get { return cityName; }
        }

        public string CountryName
        {
            get { return country.Name; }
        }
        
        public void setCountry(Country country)
        {
            this.country = country;
        }
    }
}