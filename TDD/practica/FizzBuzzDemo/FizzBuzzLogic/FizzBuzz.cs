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
            string result = "";

            if (number <= 0)
                throw new ArgumentOutOfRangeException("wrong parameter");
            else
            {
                result += DividedByThree(number);
                result += DividedByFive(number);
                if (result == "")
                {
                    result = number.ToString();
                }
            }

            return result;
        }

        private  string DividedByFive(int number)
        {
            return (number % 5 == 0) ? "Buzz" : "";
        }

        private  string DividedByThree(int number)
        {
            return (number % 3 ==0) ? "Fizz" : "";
        }
    }
}