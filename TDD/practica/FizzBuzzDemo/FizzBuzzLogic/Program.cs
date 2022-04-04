using System;

namespace FizzBuzzLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fb = new FizzBuzz();
            for (int i = 1;  i<=100 ; i++)
            Console.WriteLine(fb.CheckNumber(i));
        }
    }
}