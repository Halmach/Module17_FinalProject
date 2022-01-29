using System;

namespace Module17_FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryAccount salary = new SalaryAccount() { Balance = 100000 };
            SimpleAccount simple = new SimpleAccount() { Balance = 45000 };

            Calculator.PerformEstimation(salary);
            Console.WriteLine();
            Calculator.PerformEstimation(simple);
        }
    }
}
