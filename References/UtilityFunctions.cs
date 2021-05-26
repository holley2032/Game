using System;
using System.Collections.Generic;
using System.Text;

namespace Game.References
{
    public class UtilityFunctions

    {
        /*This method takes a lower and upper bound and asks the user to input a
         * valid integer between those two bounds, inclusive.*/
        public static int InputInteger(int lowerBound, int upperBound)
        {
            bool validInteger = false;
            int result = 0;
            while (validInteger is false)
            {
                try
                {
                    result = int.Parse(Console.ReadLine());
                    if (result >= lowerBound && result <= upperBound)
                    {
                        validInteger = true;
                    }
                    else
                    {
                        InvalidNumberMessage(lowerBound, upperBound);
                    }
                }
                catch (FormatException)
                {
                    InvalidNumberMessage(lowerBound, upperBound);
                }
            }
            return result;
        }
        public static void InvalidNumberMessage(int lowerBound, int upperBound)
        {
            Console.WriteLine($"Please enter a number between {lowerBound} and {upperBound}, inclusive");
        }
    }
}
