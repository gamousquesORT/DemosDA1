using System;

namespace SingletonClassic
{
    public class Database
    {
        private static Database instance = null;

        public string DataBaseName { get; set; }

        private Database()
        {
            instance = null;
        }
        public static Database GetInstance()
        {
            if (instance == null)
                instance = new Database();
            return instance;
        }
        

    }
}