using System;
using System.Collections.Generic;
using System.Text;

namespace Finanz_Manager
{
    public class Calculator
    {
        public int calculateBalance(List<int> pAmounts)
        {
            int balance = 0;
            foreach (int amount in pAmounts)
            {
                balance = balance + amount;
            }
            return balance;
        }
    }
}
