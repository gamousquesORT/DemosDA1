using System;


namespace EjemploPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Persona empleado = new Empleado()");
            Persona empleado = new Empleado() { Nombre = "Juan", NumeroEmpleado = 1234 };
            empleado.ImprimirDescripcion();
            empleado.ImprimirNombre();
            empleado.MetodoSinEnlaceDinamico();
            Console.WriteLine();

            Console.WriteLine("Empleado empleado2 = new Empleado()");
            Empleado empleado2 = new Empleado() { Nombre = "Juan", NumeroEmpleado = 1234 };
            empleado2.ImprimirDescripcion();
            empleado2.ImprimirNombre();
            empleado2.MetodoSinEnlaceDinamico();
            Console.WriteLine();

            Console.WriteLine("Persona empleadoMensual = new EmpleadoMensual()");
            Persona empleadoMensual = new EmpleadoMensual() { Nombre = "Juan", NumeroEmpleado = 1234, SalarioMensual = 10000 };
            empleadoMensual.ImprimirDescripcion();
            empleadoMensual.ImprimirNombre();
            Console.WriteLine();

            Console.WriteLine("Persona empleadoDiario = new EmpleadoDiario()");
            Persona empleadoDiario = new EmpleadoDiario() { Nombre = "Juan", NumeroEmpleado = 1234, SalarioDiario = 200 };
            empleadoDiario.ImprimirDescripcion();
            empleadoDiario.ImprimirNombre();
            Console.WriteLine();

            Console.ReadLine();
        }
    }

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
