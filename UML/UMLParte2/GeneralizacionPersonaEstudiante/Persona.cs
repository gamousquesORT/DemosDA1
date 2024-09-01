using System;

namespace Generalizacion
{
    public class Persona
    {
        private string _nombre;
        private string _cedula;

        public Persona()
        {
            _nombre = "sin asignar";
            _cedula = "sin asignar";      
        }
        public Persona(string nombre, string cedula)
        {
            this._nombre = nombre;
            this._cedula = cedula;
        }
        public String Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }

        }
        public String Cedula
        {
            get { return _cedula;}
            set { _cedula = value; }
        }
        public override string ToString()
        {
            return string.Format("CI:{0} \nNombre {1}\n", Cedula, Nombre);
        }
    }
}