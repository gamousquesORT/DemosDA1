using System;

namespace ImplementacionHerencia
{
    public class Persona
    {
        public String Nombre { get; set; }   // donde están los atributos en la clase?
        public int Numero { get; set; }      // son properties y se pueden escribir así C# esconde el atributo


        public override string ToString()
        {
            return "Este es el ToString de Persona -  Número:"  + this.Numero + " y Nombre:" + this.Nombre;
        }
 

        // la palabra virtual indica que el método se puede redefinir en las sublcases (override)
        // si no está redefinido y se invoca sobre un objeto de la subclase se invoca este
        public virtual String ObtenerDatos()
        {
            return String.Format("Este es el obtenerDatos de la  Persona ({0}) - {1}", Numero, Nombre);
        }
    }
}