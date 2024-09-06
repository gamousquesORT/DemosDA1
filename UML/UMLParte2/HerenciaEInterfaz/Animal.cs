namespace HerenciaEInterfaz;

public class Animal
{
    public string Nombre { get; set; } = null!;

    public virtual void Moverse()
    {
        Console.WriteLine("El animal se mueve");
    }
}

public class Perro : Animal, IHablar
{
    public void Hablar()
    {
        Console.WriteLine("El perro ladra");
    }

    public override void Moverse()
    {
        Console.WriteLine("El perro trepa");
    }
}

public class Gato : Animal, IHablar
{
    public void Hablar()
    {
        Console.WriteLine("El gato maulla");
    }

    public override void Moverse()
    {
        Console.WriteLine("El gato camina");
    }
}

public class Aguaviva : Animal
{
    public override void Moverse()
    {
        Console.WriteLine("La aguaviva flota");
    }
}