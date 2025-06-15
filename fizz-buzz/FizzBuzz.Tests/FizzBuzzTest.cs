
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
    }
}