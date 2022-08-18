using System;

namespace ejemplosClase
{
    class Program
    {
        static void Main(string[] args)
        {

                BlogEntry entry = new BlogEntry();
                entry.PostInfo("Este es un post sobre métodos de clase");
                Console.WriteLine("El post dice:" + entry.postInfoAsText());
                Console.WriteLine("El atributo de clase tiene valor: " + BlogEntry.getNumberOfPosts());
        }
    }
}