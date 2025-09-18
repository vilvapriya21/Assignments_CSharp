/*
Find the four adjacent digits in any given number that have the greatest product. What is the value of this product?

i/p: 1234568987458744574664554(input can be any)
o/p: 8 * 9 * 8 * 7 = 4032
*/

namespace Assignment
{
    internal class SecondQuestion
    {
        private static void Main(string[] args)
        {
            string input=Console.ReadLine();

            int maxProduct = 0;
            string result=string.Empty;

            if (input.Length >= 4)
            {
                for (int i = 0; i < input.Length - 3; i++)
                {
                    int digit1 = input[i] - 48;
                    int digit2 = input[i + 1] - '0';
                    int digit3 = input[i + 2] - '0';
                    int digit4 = input[i + 3] - '0';

                    int product = digit1 * digit2 * digit3 * digit4;
                    if (product > maxProduct)
                    {
                        maxProduct = product;
                        result = $"{digit1} * {digit2} * {digit3} * {digit4} = {maxProduct}";
                    }
                }
                Console.WriteLine(result);
            }
            else 
            {
                Console.WriteLine("Number has less than 4 digits");
            }
        }
    }
}
