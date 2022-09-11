namespace FizzBuzzLogic;

public class FizzBuzz
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";
    private const string fizzBuzz = "FizzBuzz";
    public String GetFizzBuzz(int number)
    {
        if (number <= 100)
        {
            if (number == 3)
                return Fizz;
            else if (number == 5)
                return Buzz;
            else if (ModuleOfNumber(number))
                return fizzBuzz;
            return number.ToString();
        }
        else
        {
            throw new ArgumentOutOfRangeException("el valor es mayor a 100");
        }
    }

    private static bool ModuleOfNumber(int number)
    {
        return number % 5 == 0 || number % 3 == 0;
    }
}