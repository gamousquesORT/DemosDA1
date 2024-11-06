using System;

namespace OCPFileImporter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fileType;
            try
            {

                do
                {
                    Console.Write("Enter a file type (or 'end' to quit): ");
                    fileType = Console.ReadLine();

                    if (fileType != "end")
                    {
                        Console.WriteLine($"You entered: {fileType}");
                    }

                    FileImporter importer = FileImporter.Create(fileType);
                    string result = importer.ImportFile("Nombre del archivo");
                    Console.WriteLine("el contenido importado es : {0}", result);

                } while (fileType != "end");
                Console.WriteLine("muchas gracias.");
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


        }
    }
}

