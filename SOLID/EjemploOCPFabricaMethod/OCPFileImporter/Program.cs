using System;
namespace OCPFileImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? fileType = "";
            
            // Clase que de alto nivel que puede convertir distintos tipos de contenidos
            // sin importar el tipo de archivo
            OCPCompliantClass ocpClass = new OCPCompliantClass();
            
            do
            {
                try
                {
                    Console.Write("Enter a file type (or 'end' to quit): ");
                    fileType = Console.ReadLine();

                    if (fileType != "end")
                    {
                        if (fileType != null)
                        {
                            // La responsabilidad de importar se extrajo a una clase FileImporter que tiene 
                            // subclases que se encargan de importar archivos de distintos tipos
                            // Tiene un método estático Crear que devuelve una instancia de la clase que corresponde
                            // al tipo de archivo que se le pase como argumento
                            ocpClass.Importer = FileImporter.Create(fileType);
                            
                            // la clase OCPCompliantClass no tiene más el código de importación de archivos
                            string result = ocpClass.ImportFile("Nombre del archivo");

                            Console.WriteLine("el contenido importado es : {0}\n", result);
                        }
                    }
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (NotImplementedException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception)
                {
                    Console.WriteLine("disculpe algo salió mal");
                }
            } while (fileType != "end");

            Console.WriteLine("muchas gracias.");
        }
    }
}

