using System;

namespace SingletonClassic
{
    class Program
    {
        static void Main(string[] args)
        {
            Database db1 = Database.GetInstance();
            db1.DataBaseName = "BD de Gaston";
            Console.WriteLine("Nombre Base de Datos {0}", db1.DataBaseName);
            
            
            Database db2 = Database.GetInstance();
            db2.DataBaseName = "BD de Maria";
            Console.WriteLine("Nombre Base de Datos {0}", db2.DataBaseName);
        }
    }
}