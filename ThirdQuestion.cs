/*
Input: Consider n, and m as two float inputs
Implementation: Convert float inputs to binary and perform addition and convert the result back to float.
Output: Print the float result
*/
using StaticPrac;

namespace Assignment
{
    internal class ThirdQuestion
    {
        static void Main(string[] args)
        {
            float number1 = 1.1F;
            float number2 = 2.2f;

            int bitsA = BitConverter.SingleToInt32Bits(number1);
            int bitsB = BitConverter.SingleToInt32Bits(number2);

            Console.WriteLine(bitsA + " "+ bitsB);
        }
    }
}
