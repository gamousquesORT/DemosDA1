using System.Collections.Generic;

namespace ImplementacionHerencia
{
    public class Alumno : Persona  // luego de los : viene la superclase
    {
        public  String ObtenerDatos()
        {
            return String.Format("Alumno ({0}) {1}", Numero, Nombre);
        }
    }
}

