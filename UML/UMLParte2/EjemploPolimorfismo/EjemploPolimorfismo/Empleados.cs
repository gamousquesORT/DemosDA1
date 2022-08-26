   
  
 // NO HACER ESTO DE P ONER VARIAS CLASES EN UN ARCHIVO - ES UN EJEMPLO
using System;

namespace EjemploPolimorfismo {

   public abstract class Persona
    {
        public string Nombre { get; set; }

        public abstract void ImprimirDescripcion();

        public virtual void ImprimirNombre()
        {
            Console.WriteLine("Soy una persona, con nombre: {0}", this.Nombre);
        }

        public void MetodoSinEnlaceDinamico()
        {
            Console.WriteLine("MetodoSinEnlaceDinamico de Persona");
        }
    }

    public class Empleado: Persona
    {
        public int NumeroEmpleado { get; set; }
        public override void ImprimirDescripcion()
        {
            Console.WriteLine("Soy un empleado");
        }
        public override void ImprimirNombre()
        {
            Console.WriteLine("Soy un empleado, con nombre: {0}", this.Nombre);
        }

        public void MetodoSinEnlaceDinamico()
        {
            Console.WriteLine("MetodoSinEnlaceDinamico de Empleado");
        }
    }

    public class EmpleadoMensual: Empleado
    {
        public int SalarioMensual { get; set; }

        public override void ImprimirDescripcion()
        {
            Console.WriteLine("Soy un empleado mensual");
        }

        public new void ImprimirNombre()
        {
            Console.WriteLine("Soy un empleado mensual, con nombre: {0}", this.Nombre);
        }
    }

    //public class Otra: EmpleadoMensual
    //{
    //    public override void ImprimirNombre()
    //    {
    //        base.ImprimirNombre();
    //    }
    //}

    public class EmpleadoDiario: Empleado
    {
        public int SalarioDiario { get; set; }

        public override void ImprimirDescripcion()
        {
            Console.WriteLine("Soy un empleado diario");
        }

        public void ImprimirNombre() //Se saca la advertencia con un new
        {
            Console.WriteLine("Soy un empleado diario, con nombre: {0}", this.Nombre);
        }
    }
  }