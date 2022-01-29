using System;
using System.Collections.Generic;
using System.Text;

namespace Module17_FinalProject
{
    class SimpleAccount : AbstractAccount , IAccount
    {
        public void CalculateInterest()
        {
            // расчет процентной ставки обычного аккаунта по правилам банка
            Interest = Balance * 0.4;

            if (Balance < 1000)
                Interest -= Balance * 0.2;

            if (Balance < 50000)
                Interest -= Balance * 0.4;

            Console.WriteLine("Тип аккаунта: Обычный");
            Console.WriteLine($"Сумма по процентной ставке: {Interest}");
        }
    }
}
