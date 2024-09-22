namespace Domain;

public class User
{
    private int _number;
    private string _name;
    
    public int Number { 
        get { return _number;}
        set
        {
            if (value <= 0 || value >= 10000)
                throw new ArgumentException("el numero debe ser positivo y  menor que 10000");
            else
                _number = value;
        }
    }

    public string Name
    {
        set
        {
            if (value.Length == 0)
                throw new AggregateException("el nombre no puede ser vacio");
            else
                _name = value;
        }
        get { return _name.ToUpper(); }
    }
}
