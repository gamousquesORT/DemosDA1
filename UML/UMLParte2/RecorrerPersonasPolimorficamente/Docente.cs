using System;

namespace ImplementacionHerencia
{
    public class Docente  : Persona
    {
         public DateTime FechaIngereso { get; set; }

         public override String ObtenerDatos()
         {
             return string.Format("  {0} -  y que ingresó: {1}", base.ObtenerDatos(), FechaIngereso);
         }
    }
}