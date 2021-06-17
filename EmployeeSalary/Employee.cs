using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeSalary
{
    class Employee
    {
        public Employee(string name, string depName, int salary, bool head)
        {
            Name = name;
            DepName = depName;
            Salary = salary;
            Head = head;
        }
        public string Name { get; private set; }
        public string DepName { get; private set; } 
        public int Salary { get; private set; }
        public bool Head { get; private set; }
    }
}
