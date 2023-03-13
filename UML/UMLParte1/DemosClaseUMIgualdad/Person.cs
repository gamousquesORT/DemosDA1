using System;

namespace DemosClase;

public class Person
{
    private const int MaxCi = 11;
    private string _ci;

    public Person(string name)
    {
        Name = name ?? throw new ArgumentNullException(nameof(name));
    }

    public string CI
    {
        set
        {
            if (value.Length != MaxCi) throw new ArgumentException("CI debe tener 11 caracteres");
            _ci = value;
        }
        get => _ci;
    }

    public string Name { get; set; }
}

/*
    protected bool Equals(Person other)
    {
        return _name == other._name;
    }

    public override bool Equals(object obj)
    {
        if (ReferenceEquals(null, obj)) return false;
        if (ReferenceEquals(this, obj)) return true;
        if (obj.GetType() != this.GetType()) return false;
        return Equals((Person)obj);
    }

    public override int GetHashCode()
    {
        return (_name != null ? _name.GetHashCode() : 0);
    }
        
*/