using System;

namespace FizzBuzzLogic
{
    public class FizzBuzz
    {
        public string[] CheckNumberArray(int[] numbers)
        {
            string[] results = new string[numbers.Length];
            int i = 0;
            foreach (var n in numbers )
            {
                results[i++] = CheckNumber(n);
            }

            return results;
        }
        public String CheckNumber(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException("wrong parameter");

            if (DividedByThree(number) && DividedByFive(number))
            {
                return "FizzBuzz";
            } else if (DividedByThree(number))
                return "Fizz";
            else if (DividedByFive(number))
            {
                return "Buzz";
            }
            else
            {
                return number.ToString();
            }
        }

        private static bool DividedByFive(int number)
        {
            return number % 5 == 0;
        }

        private static bool DividedByThree(int number)
        {
            return number % 3 ==0;
        }
    }
}