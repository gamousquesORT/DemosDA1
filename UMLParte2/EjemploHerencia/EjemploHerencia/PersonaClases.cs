using System;

namespace EjemploHerencia
{
    public class Persona
    {
        public String Nombre { get; set; }

        public Persona()
        {
            Console.WriteLine("Persona -> Constructor sin parámetros de Persona");
            this.Nombre = "No hay nombre asignado";
        }

        public Persona(string unNombre)
        {
            Console.WriteLine("Persona -> Constructor con parámetros de Persona");
            this.Nombre = unNombre;
        }

        public override string ToString()
        {
            return String.Format("Nombre:{0}", this.Nombre);
        }
    }

    public class Estudiante: Persona
    {
        public int NumeroEstudiante { get; set; }

        public Estudiante()
        {
            Console.WriteLine("Estudiante -> Constructor sin parámetros de Estudiante");
        }

        public Estudiante(string unNombre, int unNroEstudiante)
            :base(unNombre)
        {
            Console.WriteLine("Estudiante -> Constructor con parámetros de Estudiante");
            //this.Nombre = unNombre;
            this.NumeroEstudiante = unNroEstudiante;
        }

        public override string ToString()
        {
            return String.Format("{0}, Nro de estudiante:{1}", base.ToString(), this.NumeroEstudiante);
        }
    }

    public class Empleado : Persona
    {
        public int NumeroEmpleado { get; set; }
        public String Cargo { get; set; }

        public Empleado()
        {
            Console.WriteLine("Empleado -> Constructor sin parámetros de Empleado");
            this.NumeroEmpleado = -1;
        }

        public Empleado(string unCargo)
            : this()
        {
            Console.WriteLine("Empleado -> Constructor con parámetros de Empleado");
            this.Cargo = unCargo;
        }
    }
}