using System;
using System.Collections.Generic;
using SingletonClassic.DTO;

namespace SingletonClassic
{
    // This basic example is not thread safe
    public sealed class MyAppController
    {
        // Notar que el atributo _instance es Estático
        private static readonly MyAppController instance = new MyAppController();
        
        // Notar que la lista es un atributo de clase
        private List<User> _users;
        
        static MyAppController()
        {
        }
        // Constructor de instancias privado para que nadie haga new!!
        private MyAppController()
        {
            _users = new List<User>();
            Console.WriteLine("Initializing controller instance attributes");
        }
        
        // Metodo para obtener la unica instancia que puede existir  de Controlladora
        public static MyAppController GetInstance()
        {
            return instance;
        }

        // método alternativo al de arriba es solo una forma de escrbir
        public static MyAppController Instance => instance;

        //--------------------------------------------
        // Metodos especificos de la clase Controlador
        //--------------------------------------------
        public void AddUser(UserDTO userData)
        {
            _users.Add(new User(userData.ID, userData.Name));
        }

        public List<User> GetAllUsers()
        {
            return _users;
        }
    }
}