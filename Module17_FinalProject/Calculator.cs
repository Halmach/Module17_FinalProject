using System;
using System.Collections.Generic;
using System.Text;

namespace Module17_FinalProject
{
    class Calculator
    {
        public static void PerformEstimation(IAccount account)
        {
            account.CalculateInterest();
        }
    }
}
