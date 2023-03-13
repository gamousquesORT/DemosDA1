using System;
using System.Collections.Generic;

namespace ejemplosClase;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new List<BlogEntry>();

        var entry = new BlogEntry();
        entry.Post = "Este es un post sobre métodos de instancia";
        list.Add(entry);

        entry = new BlogEntry();
        entry.Post = "Este TAMBIEN es un post sobre métodos de instancia";
        list.Add(entry);

        foreach (var listentry in list)
            Console.WriteLine("El post dice:" + listentry);

        //Atención -  ver cómo se invoca un método de clase
        Console.WriteLine("Este invoca un método de clase que retorna el valor: " + BlogEntry.GetNumberOfPosts());
    }
}