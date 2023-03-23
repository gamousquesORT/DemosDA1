using System;

namespace ImplementacionHerencia
{
    public class Docente  : Persona
    {
         public DateTime FechaIngereso { get; set; }

         public override String ObtenerDatos()
         {
             return string.Format("Este es el obtenerDatos del Docente {0}  -  {1}", base.ObtenerDatos(), FechaIngereso);
         }
    }
}