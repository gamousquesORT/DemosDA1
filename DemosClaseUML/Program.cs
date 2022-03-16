using System;

namespace DemosClase
{
    public class Persona
    {
        protected bool Equals(Persona other)
        {
            return _name == other._name;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Persona)obj);
        }

        public override int GetHashCode()
        {
            return (_name != null ? _name.GetHashCode() : 0);
        }
        

        private string _name;

        public Persona(string name)
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
            Persona pa = new Persona("Gastón");

            Persona pb = new Persona("Gastón");

            
            Console.WriteLine( (pa == pb)); //??
            Console.WriteLine( pa.Equals(pb)); //??
                
        }
    }
}
