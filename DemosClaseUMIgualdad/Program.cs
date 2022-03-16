using System;

namespace DemosClase
{
    public class Person
    {
        protected bool Equals(Person other)
        {
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Person)obj);
        }

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }
        

        private string _name;

        public Person(string name)
        {
            _name = name ?? throw new ArgumentNullException(nameof(name));
        }

        public string Name
        {
            get => _name;
            set => _name = value;
        }
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person("Gastón");

            Person personB = new Person("Gastón");

            
            Console.WriteLine( (personA == personB)); //??
            Console.WriteLine( personA.Equals(personB)); //??
                
        }
    }
}
