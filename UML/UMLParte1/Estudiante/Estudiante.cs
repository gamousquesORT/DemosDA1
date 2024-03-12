using System;

namespace ejemplosClase;

public class Estudiante
{
    private static long _proximoNumeroEstudiante;
    private string _nombre;
    private string _celular;

    static Estudiante()
    {
        _proximoNumeroEstudiante = 1;
    }

    public Estudiante()
    {
        // notar que no existe el atributo _numero de estudiante, se llama la la property
        NumeroEstudiante = _proximoNumeroEstudiante++;
    }


    // properties auto implementadas
    public long NumeroEstudiante { get; }
    public DateTime FechaIngreso { set; get; }

    // esta es un property con Backing Field porque está declarado explicitamente en los atributos
    public string Nombre
    {
        get => _nombre;
        set => _nombre = value ?? throw new ArgumentNullException(nameof(value)); //esto es un if para probar si es null
    }

    // otra forma de escribir las proerties con atributos definidos
    public string Celular
    {
        set { _celular = value; }
        get { return _celular;  }
    } 
    public static long GetProximoEstudiante()
    {
        
        return _proximoNumeroEstudiante;
    }
    
    // mostrar generar Equals
    
}