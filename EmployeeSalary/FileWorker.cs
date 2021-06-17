using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace EmployeeSalary
{
    static class FileWorker
    {
        public static List<Employee> Employees { get; private set; } = new List<Employee>();
        public static Dictionary<string, int> Deps { get; private set; } = new Dictionary<string, int>();
        public static void CheckFile()
        {
            string[] file = File.ReadAllLines("file.txt");
            for (int i = 0; i < file.Length; i++)
            {
                string[] split = file[i].Split(";");
                string name = split[0];
                string depName = split[1];
                int salary = int.Parse(split[2]);
                bool head;
                if (split.Length == 4)
                {
                    head = Convert.ToBoolean(split[3]);
                }
                else
                {
                    head = false;
                }
                Employee employee = new Employee(name, depName, salary, head);
                Employees.Add(employee);
            }
        }
        public static void CheckHeadsQuantity()
        {
            for (int i = 0; i < Employees.Count; i++)
            {
                if (!Deps.ContainsKey(Employees[i].DepName))
                {
                    if (Employees[i].Head)
                        Deps.Add(Employees[i].DepName, 1);
                    else
                        Deps.Add(Employees[i].DepName, 0);
                }
                else if (Employees[i].Head)
                {
                    int value = Deps.GetValueOrDefault(Employees[i].DepName);
                    if (value + 1 > 0 && value + 1 <= 2)
                        Deps[Employees[i].DepName] = ++value;
                    else
                        throw new Exception("Incorrect heads quantity");
                }
            }
        }
    }
}
