namespace EjemplosDePatrones
{
    class Program
    {
        static void Main(string[] args)
        {
            Pais us = new USA();
            Pais uy = new Uruguay();

            Compra c = new Compra() {Total = 100, Pais = uy};
            Console.WriteLine($"Impuestos en UY: {c.CalcularImpuestos()}");

            c.Pais = us;
            Console.WriteLine($"Impuestos en USA: {c.CalcularImpuestos()}");

            Console.ReadLine();

        }
    }
    
}