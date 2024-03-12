using System;

namespace Static;

internal class Program
{
    private static void Main(string[] args)
    {
        var socio1 = new Socio(" Maria", "12345");
        var socio2 = new Socio(" Gaston", " 34567");
        Console.WriteLine("Nombre socio {0} - {1} - {2}", socio1.GetId(), socio1.Nombre, socio1.Ci);
        Console.WriteLine("Nombre socio {0} - {1} - {2}", socio2.GetId(), socio2.Nombre, socio2.Ci);
        Console.WriteLine("acceso desde instanica a atributo clase {0}", socio1.AccesoAtributoOrdinalSocios());
        Console.WriteLine("acceso desde método de instancia a método clase {0}", socio1.AccesoMétodoNuevoSocio());
    }
}

public class Socio
{
    private static long ordinalSocios;

    //atributos de instancia
    private readonly long id;

    static Socio() // se invoa automatcamente previo a la creación de la primera instancia
    {
        ordinalSocios = 0;
    }

    public Socio()
    {
        Saldo = 0;
        id = NuevoSocio();
    }

    public Socio(string nom, string ci) : this()
    {
        Nombre = nom;
        this.Ci = ci;
    }

    public string Nombre { get; set; }

    public string Ci { get; set; }

    public float Saldo { get; set; }

    public long GetId()
    {
        return id;
    }

    private static long NuevoSocio()
    {
        return ++ordinalSocios;
    }

    public long AccesoAtributoOrdinalSocios()
    {
        return ++ordinalSocios;
    }

    public long AccesoMétodoNuevoSocio()
    {
        return NuevoSocio();
    }
    // otros métodos
}