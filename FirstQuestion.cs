/*
 1.Take two strings as input and check whether the second string is a sub-string of the first or not.
If yes, print the number of times occurred in S1 and print the index positions where the string appeared]

i/p : S1 = “abcdabcabd”
        S2 = “ab”
o/p: No.of times occurred = 3
        Index positions = 0 4 7
*/
namespace Assignment
{
    internal class FirstQuestion
    {
        static void Main(string[] args)
        {
            string mainString=Console.ReadLine();
            string target=Console.ReadLine();

            string positions=String.Empty;
            int count = 0, index = mainString.IndexOf(target);

            while (index != -1)
            {
                positions+=" "+index; 
                count++;
                index = mainString.IndexOf(target, index + target.Length); 
            }

            if (count != 0) 
            {
                Console.WriteLine("No.of times occurred = " + count);
                Console.WriteLine("Index positions =" + positions);
            }
            else
            {
                Console.WriteLine("Doesn't exist");
            }
        }
    }
}
