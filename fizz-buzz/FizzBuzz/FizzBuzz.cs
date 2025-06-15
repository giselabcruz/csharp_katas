using System;

namespace FizzBuzz
{
    public class FizzBuzz
    {
        public static string CheckNumber(int number)
        {
            return CheckIsFizz(number);
            
        }

        private static string CheckIsFizz(int number)
        {
            return number % 3 == 0 ? "Fizz" : number.ToString();
        }
    }
}