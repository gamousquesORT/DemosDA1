using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemplosDePatrones
{
    // esta es la clase de la que queremos tener una unica instancia
    public class Sistema
    {
        // aca vamos a guardar la unica instancia 
        // de esta clase. Notar que es un atributo de clase
        private static Sistema instancia;

        // Hacer el constructor privado: me asegura que nadie mas puede crear instancias
        private Sistema() {
            // ....
        }

        public static Sistema Instancia {
            get
            {
                if (instancia == null)
                {
                    instancia = new Sistema();
                }
                return instancia;
            }
        }

        // ....
        // logica propia de sistema. En este ejemplo, solo llevar un contador

        private int contador;

        public void Incrementar() {
            this.contador++;
        }

        public int GetValor() {
            return this.contador;
        }
    }
}
