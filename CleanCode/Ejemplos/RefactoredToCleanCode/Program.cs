using RefactoredToCleanCode;
public class Program
{
    public static void Main(string[] args)
    {
        // Clean Code Book Chapter 2
        GuessStatisticsMessage cm = new GuessStatisticsMessage();

        Console.WriteLine(        cm.Make('C', 4));
        Console.WriteLine(        cm.Make('E', 3));
        Console.WriteLine(        cm.Make('C', 4));

    }
}