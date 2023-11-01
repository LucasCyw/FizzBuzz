using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    public class FizzBuzzGame
    {
        public static string CountOff(int given_val)
        {
            if (given_val % 3 == 0)
            {
                if (given_val % 5 == 0)
                {
                    return "FizzBuzz";
                }

                return "Fizz";
            }
            else if (given_val % 5 == 0)
            {
                return "Buzz";
            }

            return given_val.ToString();
        }
    }
}
