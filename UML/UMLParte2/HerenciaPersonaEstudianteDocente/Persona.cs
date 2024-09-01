namespace HerenciaPersonaEstudianteDocente;

public class Persona
{
    private string _nombre;
    private int _numero;

    public Persona()
    {
        _nombre = "sin asignar";
        _numero = 0;
    }

    public Persona(string nombre, int numero)
    {
        this._nombre = nombre;
        this._numero = numero;
    }

    public String Nombre
    {
        get => _nombre;
        set => _nombre = value;
    }
    
    public int Numero
    {
        get => _numero;
        set => _numero = value;
    }
    
    public string ObtenerDatos()
    {
        return string.Format($"Esta es la persona Numero:{this._numero} con Nombre {this._nombre}");
    }
    
    public override string ToString()
    {
        return string.Format($"Este es el ToString de la clase {typeof(Persona)} con Numero:{this._numero} Nombre {this._nombre}");
    }
}