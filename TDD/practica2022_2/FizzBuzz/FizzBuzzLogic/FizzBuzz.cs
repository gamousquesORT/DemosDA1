namespace FizzBuzzLogic
{

    public class FizzBuzz
    {
        private const string fizz = "Fizz";
        private const string buzz = "Buzz";
        private const string fizzBuzz = "FizzBuzz";
        public String GetFizzBuzz(int number)
        {
            if (number == 3)
                return fizz;
            else if (number == 5)
                return buzz;
            else if (ModuleOfNumber(number))
                return fizzBuzz;
            return number.ToString();
        }

        private static bool ModuleOfNumber(int number)
        {
            return number % 5 == 0 || number % 3 == 0;
        }
    }
}