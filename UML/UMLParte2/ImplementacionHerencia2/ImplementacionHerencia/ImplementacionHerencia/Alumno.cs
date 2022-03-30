using System.Collections.Generic;

namespace ImplementacionHerencia
{
    public class Alumno : Persona  // luego de los : viene la superclase
    {
        private List<Carrera> carreras = new List<Carrera>();
        public List<Carrera> Carreras { get; set; }
    }
}


//ignorar la desprolijidad
public class Carrera
{
}