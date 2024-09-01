namespace HerenciaPersonaEstudianteDocente;

public class Alumno : Persona
{
    private List<Carrera> _carreras;
    
    public Alumno()
    {
        _carreras = new List<Carrera>();
    }
    
    public Alumno(string nombre, int numero) : base(nombre, numero)
    {
        _carreras = new List<Carrera>();
    }
    
    public override string ToString()
    {
        return string.Format($"Este es el ToString de la clase {typeof(Persona)} con Numero:{this.Numero} Nombre {this.Nombre}");
    }
    
}


public class Carrera
{
    
}