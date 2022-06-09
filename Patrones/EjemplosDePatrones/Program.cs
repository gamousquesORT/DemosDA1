using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDePatrones
{
    class Program
    {
        static void MainSingleton(string[] args)
        {
            // Sistema.GetInstancia() me permite acceder desde cualquier lado
            // a la unica instancia. Ya no necesito pasarla como parametro de un lado
            // a otro. Ademas de dar una forma de acceso, el patron asegura que esa es la unica
            // instancia de Sistema que va a existir.
            Sistema.Instancia.Incrementar();
            Console.WriteLine($"El contador va en {Sistema.Instancia.GetValor()}");
            // ...
            Sistema.Instancia.Incrementar();
            Sistema unSistema = Sistema.Instancia;
            unSistema.Incrementar();
            Console.WriteLine($"El contador va en {Sistema.Instancia.GetValor()}");
            Console.ReadLine();
        }

        static void Main(string[] args) {
            Pais us = new USA();
            Pais uy = new Uruguay();

            Compra c = new Compra() { Total = 100, Pais=uy };
            Console.WriteLine($"Impuestos en UY: {c.CalcularImpuestos()}");

            c.Pais = us;
            Console.WriteLine($"Impuestos en USA: {c.CalcularImpuestos()}");

            Console.ReadLine();

        }
    }
}
