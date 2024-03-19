using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public class Account
    {
        private int balance;
        private int pin;
        private int accountNum;

        public Account(int balance, int pin, int accountNum)
        {
            this.balance = balance;
            this.pin = pin;
            this.accountNum = accountNum;
        }

        public void setBalance(int newBalance)
        {
            this.balance = newBalance;
        }

        public int getBalance() => this.balance;

        public bool canDecrementBalance(int amount) => this.balance >= amount;

        public bool checkPin(int pinEntered) => this.pin == pinEntered;

        public int getAccountNum() => accountNum;

    }
}
