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
            Assert.Equal("1", ret);
        }
    }
}