using System.Runtime.InteropServices;
using FizzBuzz;
using Xunit;

namespace FizzBuzzTest
{
    public class FizzBuzzGameTest
    {
        [Fact]
        public void Should_return_given_number_string_when_countOff_given_normal_number()
        {
            // Given
            var given_val = 2;
            // When

            var ret = FizzBuzzGame.CountOff(given_val);

            //then
            Assert.Equal("2", ret);
        }

        [Fact]
        public void Should_return_fizz_when_countOff_given_fizz_number()
        {
            // Given
            var given_val = 3;
            // When

            var ret = FizzBuzzGame.CountOff(given_val);

            //then
            Assert.Equal("Fizz", ret);
        }

        [Fact]
        public void Should_return_buzz_when_countOff_given_buzz_number()
        {
            // Given
            var given_val = 5;
            // When

            var ret = FizzBuzzGame.CountOff(given_val);

            //then
            Assert.Equal("Buzz", ret);
        }

        [Fact]
        public void Should_return_FizzBuzz_when_countOff_given_FizzBuzz_number()
        {
            // Given
            var given_val = 15;
            // When

            var ret = FizzBuzzGame.CountOff(given_val);

            //then
            Assert.Equal("FizzBuzz", ret);
        }
    }
}