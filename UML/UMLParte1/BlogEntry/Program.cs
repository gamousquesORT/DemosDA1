using System;
using System.Collections.Generic;

namespace ejemplosClase
{
    class Program
    {
        static void Main(string[] args)
        {
                List<BlogEntry> list = new List<BlogEntry>();

                BlogEntry entry = new BlogEntry();
                entry.PostInfo("Este es un post sobre métodos de clase");
                list.Add(entry);

                entry = new BlogEntry();
                entry.PostInfo("Este TAMBIEN es un post sobre métodos de clase");
                list.Add(entry);

                foreach (BlogEntry listentry in list) 
                    Console.WriteLine("El post dice:" + listentry.ToString());
                
                 Console.WriteLine("El atributo de clase tiene valor: " + BlogEntry.getNumberOfPosts());

        }
    }
}