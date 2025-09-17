/*
Input: Consider n, and m as two float inputs
Implementation: Convert float inputs to binary and perform addition and convert the result back to float.
Output: Print the float result
*/
using StaticPrac;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment
{
    internal class ThirdQuestion
    {
        static void Main(string[] args)
        { 
            float number1 = 5.75f;
            float number2 = 1.1f;
            int bits1 = BitConverter.SingleToInt32Bits(number1);
            string binary1 = Convert.ToString(bits1, 2).PadLeft(32, '0');
            int bits2 = BitConverter.SingleToInt32Bits(number2);
            string binary2 = Convert.ToString(bits2, 2).PadLeft(32, '0');
            Console.WriteLine(binary1+"\n"+binary2);
        }
    }
}
