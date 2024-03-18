using System;

namespace Generalizacion
{
    public class Persona
    {
        private string nombre;
        private string cedula;

        public Persona()
        {
            nombre = "sin asignar";
            cedula = "sin asignar";      
        }
        public Persona(string nombre, string cedula)
        {
            this.nombre = nombre;
            this.cedula = cedula;
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }

        }
        public String Cedula
        {
            get { return cedula;}
            set { cedula = value; }
        }
        public override string ToString()
        {
            return string.Format("CI:{0} \nNombre {1}\n", Cedula, Nombre);
        }
    }
}