using System;

namespace Generalizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------(1)-----------\n");
            // El estudiante qué hereda de persona? 
            // que es propio de la clase Estudiante?
            Estudiante alumno = new Estudiante();
            alumno.Nombre = "Gaston";
            alumno.Cedula = "123456778=2";
            alumno.NumeroEstudiante = 159345;
            Console.WriteLine(alumno.ToString() + " \n");
            Console.ReadLine();
            
            // notar el Tipo de la variable alumno 
            // es valido hacer eso? 
            // hay algun error?

            Console.WriteLine("--------(2)-----------\n");
            Persona alumnoDos = new Estudiante(); //No Compila porque será?
            alumnoDos.Nombre = "Alumno dos";
            alumnoDos.Cedula = "3344558-0";
            alumnoDos.NumeroEstudiante = 159345;
            Console.WriteLine(alumnoDos.ToString() + " \n");            

            Console.ReadLine();

            Console.WriteLine("--------(3)-----------\n");
            // Qué métodos se llaman en este caso?
            Estudiante alumnoTres = new Estudiante("Marta", "4.333.221-2", 250345);
            Console.WriteLine(alumnoTres.ToString()+ " \n");
            Console.ReadLine();

            Console.WriteLine("--------(4)-----------\n");
            // Qué métodos se llaman en este caso?
            String nombre = "una Persona", ci = "4.543.2345-1";
            Persona unaPersona = new Persona(nombre, ci);
            Console.WriteLine(unaPersona.ToString()+ " \n");
              
        }
    }
}