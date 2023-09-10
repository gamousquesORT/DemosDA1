namespace FizzBuzzProdCode;

public class FizzBuzz
{
    private const int Fizz = 3; 
    private const int Buzz = 5; 
    private const int MaxNumber = 100; 
    public string Convert(int number)
    {
        string result = ""; 
        if (number >= 0 && number <= MaxNumber )
        {
            result += IsDivisibleByFizz(number);
            result += IsDivisibleByBuzz(number);
            if (result == "")
                result += number.ToString();
        }
        else
        {
            throw new InvalidDataException();
        }

        return result;
    }

    private static string IsDivisibleByBuzz(int num)
    {
        return (num % Buzz == 0) ? "Buzz" : "";
    }

    private static string IsDivisibleByFizz(int num)
    {
        return (num % Fizz == 0) ? "Fizz" : "";
    }


}