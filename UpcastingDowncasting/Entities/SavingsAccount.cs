﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UpcastingDowncasting.Entities
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount(){ }

        public SavingsAccount(int number, string holder, double balance, double interestrate)
           : base(number, holder, balance)
        {
            InterestRate = interestrate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
