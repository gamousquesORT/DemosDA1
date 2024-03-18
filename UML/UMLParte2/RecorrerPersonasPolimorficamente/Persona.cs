using System;

namespace ImplementacionHerencia
{
    public class Persona
    {
        public String Nombre { get; set; }   // donde están los atributos en la clase?
        public int Numero { get; set; }      // son properties y se pueden escribir así C# esconde el atributo


        // la palabra virtual indica que el método se puede redefinir en las sublcases (override)
        // si no está redefinido y se invoca sobre un objeto de la subclase se invoca este
        public virtual String ObtenerDatos()
        {
            return String.Format(" Persona ({0}) - {1}", Numero, Nombre);
        }
    }
}