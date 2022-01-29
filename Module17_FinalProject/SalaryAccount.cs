using System;
using System.Collections.Generic;
using System.Text;

namespace Module17_FinalProject
{
    class SalaryAccount : AbstractAccount , IAccount
    {
        public void CalculateInterest()
        {
            // расчет процентной ставк зарплатного аккаунта по правилам банка
            Interest = Balance * 0.5;

            Console.WriteLine("Тип аккаунта: Зарплатный");
            Console.WriteLine($"Сумма по процентной ставке: {Interest}");
        }
    }
}
