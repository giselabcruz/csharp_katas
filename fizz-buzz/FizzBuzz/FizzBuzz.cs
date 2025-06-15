using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CheckNumber(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            if (number % 5 == 0) {
                return "Buzz";
            }
            return number.ToString();
        }

        private static string CheckIsFizz(int number)
        {
            return number % 3 == 0 ? "Fizz" : number.ToString();
        }
        
        private static string CheckIsBuzz(int number)
        {
            return number % 5 == 0 ? "Buzz" : number.ToString();
        }
        
    }
}