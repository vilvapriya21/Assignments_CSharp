namespace StaticPrac
{
    class A{
        public static int a ;
        public int count;
        public A()
        {
            count = (++a) - 10;
        }
        public static void m1()
        {
            Console.WriteLine("static method");
        }
    }
    internal class StaticPractice
    {

        static void Main(string[] args)
        {
            A obj1=new A();
            Console.WriteLine(A.a+" "+obj1.count);
            A obj2=new A();
            Console.WriteLine(A.a + " " + obj2.count);
            A obj3=new A();
            Console.WriteLine(A.a+" "+obj3.count);

        }
    }
}
