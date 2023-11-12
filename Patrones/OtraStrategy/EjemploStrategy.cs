using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDePatrones
{
    // Codigo original, no cumple con OCP
    public class CompraNoOCP
    {
        // Muchos datos
        // ....

        public int Total { get; set; }

        public string Pais { get; set; }

        // Es un algoritmo que tienen distintas implementaciones
        // en este caso, una por pais.
        // Esta solucion no cumple con OCP!!
        public int CalcularImpuestos() {
            var impuestos = 0;

            if (Pais == "uy")
            {
                // Cada una de estas, es una implementacion particlar
                // del algoritmo.
            }
            else if (Pais == "ar") {
                // Quiero poder cambiar la implementacion que se usa
                // en tiempo de ejecucion.
            }

            return impuestos;
        }
    }

    public class Compra
    {
        // Muchos datos
        // ....

        public int Total { get; set; }

        public Pais Pais { get; set; }

        // Es un algoritmo que tienen distintas implementaciones
        // en este caso, una por pais.
        // Esta solucion no cumple con OCP!!
        public int CalcularImpuestos()
        {
            return Pais.CalcularImpuestos(this);
        }
    }

    public interface Pais {
        String Codigo { get; }

        int CalcularImpuestos(Compra unaC);
    }

    public class Uruguay : Pais
    {
        public string Codigo { get { return "uy"; } }

        public int CalcularImpuestos(Compra unaC)
        {
            return (int)(unaC.Total * 0.22);
        }
    }

    public class USA : Pais
    {
        public string Codigo { get { return "us"; } }

        public int CalcularImpuestos(Compra unaC)
        {
            return (int)(unaC.Total * 0.07);
        }
    }
}
