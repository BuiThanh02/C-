using System;

namespace VD13
{
    class Employee
    {
        privateint _empId;
        private string _empName;
        privateint _age;
        private double _salary;
        Employee(int id, string name, int age, double sal)
        {
            Console.WriteLine(“Constructor for Employee called”) ;
        }
        static void Main(string[] args)
        {
            Employee objEmp = new Employee(1, “John”, 45, 35000);
            Console.WriteLine(“Employee ID: “ +objEmp._empId);
            Console.WriteLine(“Employee Name: “ +objEmp._empName);
            Console.WriteLine(“Age: “ +objEmp._age);
            Console.WriteLine(“Salary: “ +objEmp._salary);
        }

    }
}
