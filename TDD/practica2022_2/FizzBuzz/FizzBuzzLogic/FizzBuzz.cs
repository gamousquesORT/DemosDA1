namespace FizzBuzzLogic;

public class FizzBuzz
{
    public const int MinArgumentNumber = 0;
    public const int MaxArgumentNumber = 100;
    
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    public String CheckFizzBuzz(int number)
    {
        if (number >= MinArgumentNumber && number <= MaxArgumentNumber)
        {
            if (number == 3)
                return Fizz;
            else if (number == 5)
                return Buzz;
            else if (ModuleOfNumber(number))
                return Fizz+Buzz;
            return number.ToString();
        } else {
            throw new ArgumentOutOfRangeException("el valor debe estar entre 0 y 100");
        }
    }

    private static bool ModuleOfNumber(int number)
    {
        return number % 5 == 0 || number % 3 == 0;
    }
}