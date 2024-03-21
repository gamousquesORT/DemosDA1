using System;

namespace ImplementacionHerencia
{
    public class Docente  : Persona
    {
         public DateTime FechaIngereso { get; set; }

         public  String ObtenerDatos()
         {
             return string.Format("Docente ({0}) - {1} - Ingresó el {2}", Numero, Nombre, FechaIngereso);
         }
    }
}