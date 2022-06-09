using System;

namespace EjemplosDePatrones
{

    public class Pago
    {
        public int Monto { get; set; }

        public int Usuario { get; set; }

    }

    public class ProcesadorPagos
    {

        // Este algoritmo nunca cambia
        // es la "plantilla" o el "template"
        public void Procesar(Pago p) {
            if (CalcularProbabilidadFraude(p) != "ALTO") {
                if (!EsDeUsuarioBloquedo(p)) {
                    var cobro = Cobrar(p);
                    // ....
                }
            }
        }

        // tengo metodos que definen cada paso
        // y que las clases pueden sobre escribir para redefinir
        // como se resuelve cada paso.
        protected virtual object Cobrar(Pago p)
        {
            // En general en la clase base hay una implementacion por defecto para cada
            // paso

            // logica para cobrar ...
            return new Cobro();
        }

        protected bool EsDeUsuarioBloquedo(Pago p)
        {
            throw new NotImplementedException();
        }

        protected string CalcularProbabilidadFraude(Pago p)
        {
            throw new NotImplementedException();
        }
    }

    internal class Cobro
    {
        public Cobro()
        {
        }
    }
}
