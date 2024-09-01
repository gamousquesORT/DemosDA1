namespace HerenciaPersonaEstudianteDocente;

public class Docente : Persona
{
    private DateTime _fechaIngreso;
    
    public Docente()
    {
        _fechaIngreso = DateTime.Now;
    }
    
    public Docente(DateTime fechaIngreso, string nombre, int numero) : base(nombre, numero)
    {
        this._fechaIngreso = fechaIngreso;
    }
    
    public DateTime FechaIngreso
    {
        get => _fechaIngreso;
    }
    
    public string ObtenerDatos()
    {
        return string.Format($"Este el el docente Numero:{this.Numero} con Nombre {this.Nombre} y Fecha de ingreso: {this.FechaIngreso.ToString()}");
    }
    
    public override string ToString()
    {
        return string.Format($"Este es el ToString de la clase {typeof(Persona)} con Numero:{this.Numero} Nombre {this.Nombre} y Fecha de ingreso: {this.FechaIngreso.ToString()}");
    }

}