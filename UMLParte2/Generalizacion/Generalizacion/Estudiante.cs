namespace Generalizacion
{
    public class Estudiante : Persona
    {
        private int numeroEstudiante;

        public Estudiante(string nombre, string cedula, int numeroEstudiante) : base(nombre, cedula)
        {
            this.numeroEstudiante = numeroEstudiante;
        }

        public Estudiante()
        {
            numeroEstudiante = 0;
        }

        public int NumeroEstudiante
        {
            set { numeroEstudiante = value;}
            get { return numeroEstudiante; }
        }
       
        // Notar que dice override! porqué será?
        public override string ToString()
        {
            return string.Format("{0}\nNúmero estudiante: {1} ", base.ToString(), NumeroEstudiante);
        }
    }
}