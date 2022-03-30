using System;

namespace ImplementacionHerencia
{
    public class Docente  : Persona
    {
         public DateTime FechaIngereso { get; set; }

         public  String ObtenerDatos()
         {
             return string.Format("Este es el ObtenerDatos de Docente - {0}  -  {1}", base.ObtenerDatos(), FechaIngereso);
         }
    }
}