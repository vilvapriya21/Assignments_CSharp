using System.Diagnostics;

namespace GarbageC
{
    class Person
    {
        int a = 10;
    }
    class Person2 
    {
        public int a;
    }
    internal class GarbageCollectionPractice
    {
        static Person p=new Person();   
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
           // Person p=new Person();
            //Person p1 = p;
            Console.WriteLine($"Initial Gen : {GC.GetGeneration(p)} at {sw.ElapsedMilliseconds} ms");
            Console.WriteLine(GC.GetGeneration(p));
         //   int[] a = new int[100000];
         //   Console.WriteLine($"a : {GC.GetGeneration(a)}");
            for (int i = 0; i < 100000; i++)
            {
                Person k=new Person();
            }

           // GC.Collect(); // force collection
            Console.WriteLine($"Gen after GC1 : {GC.GetGeneration(p)} at {sw.ElapsedMilliseconds} ms");
            int j = 0;
            //p = null;
           // for(j=0; j < 100; j++) 
            GC.Collect();
            Console.WriteLine($"Gen after GC2 : {GC.GetGeneration(p)} at {sw.ElapsedMilliseconds} ms");


            //Console.WriteLine($"p Gen after GC: {GC.GetGeneration(p)}"); // Gen 1 or 2
            //Console.WriteLine($"p1 Gen after GC: {GC.GetGeneration(p1)}");
            
        }
    }
}
