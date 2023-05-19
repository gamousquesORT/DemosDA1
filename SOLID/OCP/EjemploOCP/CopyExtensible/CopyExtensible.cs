namespace CopyExtensible;

public class CopyExtensible
{
    private IInput _input;
    private IOutput _output;

    public CopyExtensible(IInput input, IOutput output)
    {
        _input = input;
        _output = output;
    }

    public void CopyStrings()
    {
            string inputValue;

            while ((inputValue = _input.Read()) != "")
                _output.Write(inputValue);
    }
}


public interface IInput
{
    string Read();
}

public interface IOutput
{
    void Write(string outputValue);
}


public class KeyBoardReader : IInput
{
    public string Read()
    {
        Console.Write("->");
        return Console.ReadLine();
    }
}

public class MonitorOutput : IOutput
{
    public void Write(string outputValue)
    {
        Console.Write("<-");
        Console.WriteLine(outputValue);
    }
}
