using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CheckNumber(int number)
        {
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