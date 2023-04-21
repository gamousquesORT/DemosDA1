public class Program
{
    public static void Main(string[] args)
    {
        // Clean Code Book Chapter 2
        PrintGuessStatistics('C', 4);
        PrintGuessStatistics('E', 3);
        PrintGuessStatistics('D', 4);
    }
    
     private static void PrintGuessStatistics(char candidate, int count)
        {
            string number;
            string verb;
            string pluralModifier;

            if (count == 0)
            {
                number = "no";
                verb = "are";
                pluralModifier = "s";
            } else if (count == 1)
            {
                number = "1";
                verb = "is";
                pluralModifier = "";
            } else
            {
                number = count.ToString();
                verb = "are";
                pluralModifier = "s";
            }
            Console.WriteLine($"There {verb} {number} {candidate}{pluralModifier}");
        }
}