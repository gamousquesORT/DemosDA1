namespace FizzBuzzlogic;

public class FizzBuzz
{
    private const int FIZZ = 3;
    private const int BUZZ = 5;
    private const int NEGATIVE = 0;
    
    public string CheckNumber(int num)
    {
        if (num <= NEGATIVE )
        throw new System.ArgumentException("Number must be greater than 0");

        if (IsFizzBuzz(num))
        {
            return "FizzBuzz";
        }
        else if (IsFizz(num))
        {
            return "Fizz";
        }
        else if (IsBuzz(num))
        {
            return "Buzz";
        }

        return num.ToString();
    }

    private static bool IsBuzz(int num)
    {
        return (num % BUZZ) == 0;
    }

    private static bool IsFizz(int num)
    {
        return (num % FIZZ) == 0;
    }

    private static bool IsFizzBuzz(int num)
    {
        return IsFizz(num) && IsBuzz(num);
    }
}