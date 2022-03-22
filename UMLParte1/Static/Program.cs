using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Socio socio1 = new Socio(" Maria", "12345");
            Socio socio2 = new Socio(" Gaston", " 34567");
            Console.WriteLine("Nombre socio {0} - {1} - {2}", socio1.GetId(), socio1.Nombre, socio1.Ci);
            Console.WriteLine("Nombre socio {0} - {1} - {2}", socio2.GetId(), socio2.Nombre, socio2.Ci);
        }
    }

    public class Socio
    {
        //atributos de instancia
        private long id;
        private String nombre;
        private String ci;
        private float saldo;
        private static long ordinalSocios;

        static Socio()   // se invoa automatcamente previo a la creación de la primera instancia
        {
            ordinalSocios = 0;
        }

        public Socio()
        {
            this.saldo = 0;
            this.id = NuevoSocio();
        }
        public Socio(String nom, String ci) : this()
        {
            this.nombre = nom;
            this.ci = ci;
        }
        
        public string Nombre
        {
            get => nombre;
            set => nombre = value;
        }

        public string Ci
        {
            get => ci;
            set => ci = value;
        }

        public float Saldo
        {
            get => saldo;
            set => saldo = value;
        }

        public long GetId()
        {
            return this.id;
        }
        private static long NuevoSocio()
        {
            return ++ordinalSocios;
        }
        // otros métodos
    }
}