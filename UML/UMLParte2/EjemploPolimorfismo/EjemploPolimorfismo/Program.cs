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
}