/*
Input: Consider n, and m as two float inputs
Implementation: Convert float inputs to binary and perform addition and convert the result back to float.
Output: Print the float result
*/

namespace Assignment
{
    internal class ThirdQuestion
    {
        static string FloatToBinary(float number)
        {
            int bits = BitConverter.SingleToInt32Bits(number);
            string binary = Convert.ToString(bits, 2).PadLeft(32, '0');
            return binary;
        }

        static float AddFloats(float a, float b)
        {
            string binA = FloatToBinary(a);
            string binB = FloatToBinary(b);

            int expA = Convert.ToInt32(binA.Substring(1, 8), 2);
            int expB = Convert.ToInt32(binB.Substring(1, 8), 2);

            // normalized mantissas as integers
            long mantA = Convert.ToInt64("1" + binA.Substring(9), 2);
            long mantB = Convert.ToInt64("1" + binB.Substring(9), 2);

            // Align exponents
            while (expA < expB)
            {
                mantA >>= 1; // shift right for alignment
                expA++;
            }
            while (expB < expA)
            {
                mantB >>= 1;
                expB++;
            }

            long sumMant = mantA + mantB;
            int resultExp = expA;

            // Normalize if sumMant overflows 24 bits
            if ((sumMant & (1L << 24)) != 0)
            {
                sumMant >>= 1;
                resultExp++;
            }

            // Take 23 bits for mantissa (drop implicit 1)
            long mantissaResult = sumMant & 0x7FFFFF;

            string resultBinary = "0" + Convert.ToString(resultExp, 2).PadLeft(8, '0') +
                                  Convert.ToString(mantissaResult, 2).PadLeft(23, '0');

            return BinaryToFloat(resultBinary);
        }

        static float BinaryToFloat(string binary)
        {
            int sign = binary[0] == '0' ? 1 : -1;
            int exponent = Convert.ToInt32(binary.Substring(1, 8), 2) - 127;
            string mantissaBits = binary.Substring(9);

            double mantissa = 1.0; // implicit leading 1
            for (int i = 0; i < mantissaBits.Length; i++)
            {
                if (mantissaBits[i] == '1')
                    mantissa += Math.Pow(2, -(i + 1));
            }

            return (float)(sign * mantissa * Math.Pow(2, exponent));
        }

        static void Main(string[] args)
        {
            float number1 = 5.75f;
            float number2 = 1.1f;

            float addedBinary = AddFloats(number1, number2);
            Console.WriteLine(addedBinary); // Should print ~6.85
        }
    }
}

