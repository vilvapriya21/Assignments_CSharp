using System.Xml.Linq;

namespace Assignment
{
    internal class Employee
    {
        private static int _employeeCount;
        private int _id;
        private string _name;
        private Employee(int id,string name)
        {
            this._id = id;
            this._name = name;
        }
        public static Employee AddEmployee(int id,string name)
        {
            _employeeCount++;
            Employee e=new Employee(id, name);
            return e;
        }
        public override string ToString()
        {
            return $"Employee ID: {_id}, Name: {_name}";
        }
        public static int EmployeeCount()
        {
            return _employeeCount;
        }
    }
    class MyClass
    {
        static void Main()
        {
            Employee e=Employee.AddEmployee(11, "abcde");
            Console.WriteLine(e);
            Employee e1 = Employee.AddEmployee(31, "vilva");
            Console.WriteLine(Employee.EmployeeCount());
        }
    }
}
