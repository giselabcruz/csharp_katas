
using NUnit.Framework;

namespace FizzBuzz.Tests
{
    public class FizzBuzzTest
    {
        [Test]
        public void Check_multiple_of_three_return_fizz()
        {
            // GIVEN
            var number = 3;
            
            //WHEN
            var expectedNumber = FizzBuzz.CheckNumber(number);
            
            //THEN
            
            Assert.AreEqual(expectedNumber, "Fizz");
        }
        
        [Test]
        public void Check_number_is_not_multiple_of_three_or_five()
        {
            // GIVEN
            var number = 1;
            
            //WHEN
            var expectedNumber = FizzBuzz.CheckNumber(number);
            
            //THEN
            
            Assert.AreEqual(expectedNumber, "1");
        }
        
    }
}