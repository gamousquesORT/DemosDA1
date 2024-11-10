using System;

namespace OCPFileImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string? fileType = "";

            // Clase que de alto nivel que puede convertir disintos tipos de contenidos sin importar el tipo de archivo
            OCPComliantClass ocpClass = new OCPComliantClass();

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
                            // se crea un objeto de tipo FileImporter
                            OcpCompilantClass? importer = OcpCompilantClass.Create(fileType);

                            // se inyecta el objeto FileImporter a la clase de alto nivel
                            ocpClass.Importer = importer;
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

