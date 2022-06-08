using System;

namespace SingletonClassic
{
    public class Database
    {
        private static Database _instance;

        public string DataBaseName { get; set; }

        private Database()
        {
            _instance = null;
            Console.WriteLine("Initializing database");
        }
        public static Database GetInstance()
        {
            if (_instance == null)
                _instance = new Database();
            return _instance;
        }
        public static Database Instance => _instance;

    }
}