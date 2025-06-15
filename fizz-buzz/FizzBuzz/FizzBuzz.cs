using System;
using System.Security.AccessControl;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static void Run()
        {
            for (int i = 1; i <= 100; i++)
            {
                System.Console.WriteLine(CheckNumber(i));
            }
        }
        public static string CheckNumber(int number)
        {
            if (CheckIsBuzz(number) && CheckIsFizz(number)) {
                return "FizzBuzz";
            }
            
            if (CheckIsFizz(number))
            {
                return "Fizz";
            }

            if (CheckIsBuzz(number)) {
                return "Buzz";
            }
            
            return number.ToString();
        }

        private static bool CheckIsFizz(int number)
        {
            return number % 3 == 0;
        }
        
        private static bool CheckIsBuzz(int number)
        {
            return number % 5 == 0;
        }
        
    }
}