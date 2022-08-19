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
                entry.PostInfo("Este es un post sobre métodos de instancia");
                list.Add(entry);

                entry = new BlogEntry();
                entry.PostInfo("Este TAMBIEN es un post sobre métodos de instancia");
                list.Add(entry);

                foreach (BlogEntry listentry in list) 
                    Console.WriteLine("El post dice:" + listentry.ToString());
                
                 Console.WriteLine("Este invoca un método de clase que retorna el valor: " + BlogEntry.getNumberOfPosts());

        }
    }
}