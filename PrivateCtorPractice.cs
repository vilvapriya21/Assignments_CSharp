using System.Xml.Linq;

namespace Assignment
{
    internal class Employee
    {
        private static int employeeCount;
        int id;
        string name;
        Employee(int id,string name)
        {
            this.id = id;
            this.name = name;
        }
        public static Employee AddEmployee(int id,string name)
        {
            employeeCount++;
            Employee e=new Employee(id, name);
            return e;
        }
        public override string ToString()
        {
            return $"Employee ID: {id}, Name: {name}";
        }
    }
    class MyClass
    {
        static void Main()
        {
            Employee e=Employee.AddEmployee(11, "abcde");
            Console.WriteLine(e);
        }
    }
}
