

//***********
// Tener en cuenta que el código de Program NO compila. Hay un error que es necesario arreglarlo. El mismo se dejó
// para que ud. demuestre que comprende la herencia  
//***********

namespace Generalizacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------(1)-----------\n");
            // Estudiante qué hereda de persona? 
            // que es propio de la clase Estudiante?
            Estudiante alumnoUno = new Estudiante();
            alumnoUno.Nombre = "Gaston";
            alumnoUno.Cedula = "123456778=2";
            alumnoUno.NumeroEstudiante = 159345;
            Console.WriteLine(alumnoUno.ToString() + " \n");
            Console.ReadLine();
            
            // notar el Tipo de la variable alumno 
            // es valido hacer eso? 
            // hay algun error?

            Console.WriteLine("--------(2)-----------\n");
            Persona alumnoDos = new Estudiante(); //No Compila porque será?
            alumnoDos.Nombre = "Alumno dos";
            alumnoDos.Cedula = "3344558-0";
            //alumnoDos.NumeroEstudiante = 159345;
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