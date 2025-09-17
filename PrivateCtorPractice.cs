using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public static void AddEmployee(int id,string name)
        {
            employeeCount++;
            new Employee(id, name);
        }
    }
    class MyClass
    {
        static void Main()
        {
            Employee.AddEmployee(11, "abcde");
        }
    }
}
