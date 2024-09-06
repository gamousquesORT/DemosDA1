
using HerenciaEInterfaz;

List<Animal> animales = new List<Animal>
{
    new Perro { Nombre = "Firulais" },
    new Gato { Nombre = "Garfield" },
    new Aguaviva { Nombre = "Medusa" }
};

Console.WriteLine("-- Animales que se mueven ---");
foreach (Animal a in animales)
{
    a.Moverse();
}



List<IHablar> habladores = new List<IHablar>
{
    new Perro { Nombre = "Pluto" },
    new Gato { Nombre = "Garfield" }
};

Console.WriteLine("\n-- Animales que se hablan ---");

foreach (IHablar a in habladores)
{
    a.Hablar();   
}
