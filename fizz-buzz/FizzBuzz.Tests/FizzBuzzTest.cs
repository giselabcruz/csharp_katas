
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        [TestCase(3)]
        [TestCase(6)]
        [TestCase(99)]
        [TestCase(69)]
        [TestCase(81)]
        public void Check_multiple_of_three_return_fizz(int number)
        {
            //WHEN
            var expectedNumber = FizzBuzz.CheckNumber(number);
            
            //THEN
            
            Assert.AreEqual(expectedNumber, "Fizz");
        }
        
        [TestCase(1)]
        [TestCase(2)]
        [TestCase(4)]
        [TestCase(7)]
        public void Check_number_is_not_multiple_of_three_or_five(int number)
        {
            //WHEN
            var expectedNumber = FizzBuzz.CheckNumber(number);
            
            //THEN
            Assert.AreEqual(expectedNumber, number.ToString());
        }

        [TestCase(5)]
        [TestCase(10)]
        [TestCase(25)]
        public void Check_number_is_multiple_of_five(int number)
        {
            var expectedNumber = FizzBuzz.CheckNumber(number);
            
            Assert.AreEqual(expectedNumber, "Buzz");
        }
        
        [TestCase(15)]
        [TestCase(30)]
        [TestCase(45)]
        public void Check_number_is_multiple_of_five_and_three(int number)
        {
            var expectedNumber = FizzBuzz.CheckNumber(number);
            
            Assert.AreEqual(expectedNumber, "FizzBuzz");
        }
        
    }
}