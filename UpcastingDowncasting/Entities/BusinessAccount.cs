using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDowncasting.Entities
{
    class BusinessAccount : Account
    {
        public double Loanlimit { get; set; }

        public BusinessAccount() { }

        public BusinessAccount(int number, string holder, double balance, double loanlimit)
            : base(number, holder, balance)
        {
            Loanlimit = loanlimit;
        }

        public void Loan(double amount)
        {
            if (amount <= Loanlimit)
            {
                Balance += amount;
            }
        }
    }
}
