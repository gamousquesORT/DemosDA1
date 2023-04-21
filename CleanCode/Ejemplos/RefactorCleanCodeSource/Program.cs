public class Program
{
    public static void Main(string[] args)
    {
        String s;
        // Clean Code Book Chapter 2
        s = GetGuessStatistics('C', 4);
        Console.WriteLine(s);

        GetGuessStatistics('E', 3);
        GetGuessStatistics('D', 4);
    }
    
     public static string GetGuessStatistics(char candidate, int count)
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
            return $"There {verb} {number} {candidate}{pluralModifier}";
        }
}