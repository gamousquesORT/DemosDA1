using System;

namespace ejemplosClase;

public class Estudiante
{
    private static long _proximoNumeroEstudiante;
    private string _nombre;

    static Estudiante()
    {
        _proximoNumeroEstudiante = 1;
    }

    public Estudiante()
    {
        NumeroEstudiante = _proximoNumeroEstudiante++;
    }

    public long NumeroEstudiante { get; }

    public DateTime FechaIngreso { set; get; }

    public string Nombre
    {
        get => _nombre;
        set => _nombre = value ?? throw new ArgumentNullException(nameof(value)); //esto es un if para probar si es null
    }

    public static long GetProximoEstudiante()
    {
        return _proximoNumeroEstudiante;
    }
}