namespace Generalizacion
{
    public class Estudiante : Persona
    {
        private int _numeroEstudiante;

        public Estudiante(string nombre, string cedula, int numeroEstudiante) : base(nombre, cedula)
        {
            this._numeroEstudiante = numeroEstudiante;
        }

        public Estudiante()
        {
            _numeroEstudiante = 0;
        }

        public int NumeroEstudiante
        {
            set { _numeroEstudiante = value;}
            get { return _numeroEstudiante; }
        }
       
        // Notar que dice override! porqué será?
        public override string ToString()
        {
            return string.Format("{0}\nNúmero estudiante: {1} ", base.ToString(), NumeroEstudiante);
        }
    }
}