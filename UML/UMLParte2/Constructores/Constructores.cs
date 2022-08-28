// ESTO ES UN EJEMPLO EVITAR PONER MAS DE UNA CLASE EN UN ARCHIVO .cs
namespace EjemploConstructores 
{
    public class Persona {
        private string _ci = "";
        private string _nombre = "";
        public Persona() 
        {
            _ci = "solo para mostrar que no lo fue inicializado";
            _nombre = "solo para mostrar que no lo fue inicializado";
        }
        public Persona(string ci, string nombre) {
            _ci = ci;
            _nombre = nombre;
        }

        public string CI { set => _ci = value; get =>_ci; }
        public string Nombre {set => _nombre = value; get => _nombre;}

        public override string ToString()
        {
            return String.Format("Cedula:= {0} - Nombre:= {1}", _ci, _nombre);
        }
    }

    public class Funcionario : Persona {
        private long _numeroFuncionario;

        public Funcionario() {
            _numeroFuncionario = -1; // init en -1 por defecto
        }

        public Funcionario(string ci, string nombre, long numeroFunc) 
        : base(ci, nombre)
        {
            _numeroFuncionario = numeroFunc;
        }

        public long NumeroFunicionario {get => _numeroFuncionario;}

        public override string ToString()
        {
            return base.ToString() + String.Format(" - NumeroFuncionario:= {0}", _numeroFuncionario);
        }
    }
}

