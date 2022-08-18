namespace ejemplosClase
{
    public class Country
    {
        private Capital capital;
        private string coutryName;

        public Country(string countryName, string capitalName)
        {
            this.coutryName = countryName;
            capital = new Capital(this, capitalName);
        }
       
        public string Name
        {
            get { return coutryName; }
        }

        public string CapitalName
        {
            get { return capital.Name; }
        }

        public Capital Capital
        {
            get { return capital; }
        }
    }
}