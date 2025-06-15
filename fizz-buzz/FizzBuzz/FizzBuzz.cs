using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CheckNumber(int number)
        {
            return CheckIsFizz(number);
            
        }

        public static string CheckIsFizz(int number)
        {
            if (number % 3 == 0)
            {
                return "Fizz";
            }

            return number.ToString();
        }
    }
}