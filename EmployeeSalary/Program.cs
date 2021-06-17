using System;

namespace EmployeeSalary
{
    class Program
    {
        static void Main(string[] args)
        {
            FileWorker.CheckFile();
            try
            {
                FileWorker.CheckHeadsQuantity();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
