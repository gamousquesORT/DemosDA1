namespace CopyExtensible;

class Program
{
    static void Main(string[] args)
    {
        IInput inputObject = new KeyBoardReader();
        IOutput outputObject = new MonitorOutput();
        
        CopyExtensible copyUtil = new CopyExtensible(inputObject, outputObject);
        copyUtil.CopyStrings();
    }
}