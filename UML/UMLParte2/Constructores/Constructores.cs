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

    public class Empleado : Persona {
        private long _numeroEmpleado;

        public Empleado() {
            _numeroEmpleado = -1; // init en -1 por defecto
        }

        // qué pasa si no se llama al constructor de la clase base? cómo queda inicializado el objeto?
        public Empleado(string ci, string nombre, long numeroFunc) 
        : base(ci, nombre)
        {
            _numeroEmpleado = numeroFunc;
        }

        public long NumeroEmpleadoNumero {get => _numeroEmpleado;}

        public override string ToString()
        {
            return base.ToString() + String.Format(" - NumeroFuncionario:= {0}", _numeroEmpleado);
        }
    }
}

