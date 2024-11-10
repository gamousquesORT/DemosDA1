using System;

namespace OCPFileImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileType = "";

            // se crea la instancia de la clase OCPComliantClass y de la fabrica de convertidores
            ImporterFactory importerFactory = new ImporterFactory();
            
            // se inyecta el convertidor de archivos a la clase OCPComliantClass
            OCPComliantClass ocpClass = new OCPComliantClass(importerFactory);
            
            do
            {
                try
                {
                    Console.Write("Enter a file type (or 'end' to quit): ");
                    fileType = Console.ReadLine();

                    if (fileType != "end")
                    {
                        Console.WriteLine($"You entered: {fileType}");
                        
                        // se importa el archivo
                        string result = ocpClass.ImportFile("Nombre del archivo", fileType);
                        Console.WriteLine("el contenido importado es : {0}", result);
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

