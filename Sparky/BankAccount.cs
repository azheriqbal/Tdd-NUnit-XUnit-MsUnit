﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class BankAccount
    {
        public int balance { get; set; }

        private readonly ILogBook _logBook;
        public BankAccount(ILogBook logBook)
        {
            balance = 0;
            _logBook = logBook;

        }

        public bool Deposit(int amount)
        {
            _logBook.Message("Deposit was invoked");
            balance += amount;
            return true;
        }

        public bool Withdrww(int amount)
        {
            if(amount <= balance ) 
            {
                balance -= amount;
                return true;   
            }
            return false;
        }

        public int GetBalance()
        {
            return balance;
        }
    }
}
