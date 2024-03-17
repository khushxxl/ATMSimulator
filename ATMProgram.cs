using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSimulator
{
    public class ATMProgram
    {
        // private Account[] ac = new Account[3];

        List<Account> accounts = new List<Account>();

        public ATMProgram()
        {
            // ac[0] = new Account(300, 1111, 111111);
            //  ac[1] = new Account(750, 2222, 222222);
            //  ac[2] = new Account(3000, 3333, 333333);

            accounts.Add(new Account(300, 1111, 111111));
            accounts.Add(new Account(750, 2222, 222222));
            accounts.Add(new Account(3000, 3333, 333333));
        }

        public List<Account> getAllAccounts() => accounts;

        public void addAccount(Account account)
        {
            accounts.Add(account);
        }

        public Account findAccount(int accountNum)
        {
            for (int i = 0; i < this.accounts.Count(); i++)
            {
                if (accounts[i].getAccountNum() == accountNum)
                {
                    return accounts[i];
                }
            }
            return null;
        }


    }
}
