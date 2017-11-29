using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountNamespace
{
    public class Account
    {
        private int accountID;
        private string password;
        private double moneyDollars;
        private double moneyTenge;
        private double moneyRuble;
        Random random = new Random();

        public Account()
        {
            accountID = random.Next(10000000, 100000000);
            moneyDollars = 0;
            moneyRuble = 0;
            moneyTenge = 0;
        }
        public void SetPassword(string password)
        {
            if (this.password != null)
            {
                Console.WriteLine("Enter your old password");
                if (Console.ReadLine() == this.password)
                {
                    this.password = password;
                }
                else
                {
                    Console.WriteLine("Password incorrect");
                }
            }
            else
            {
                this.password = password;
            }
        }

        public int GetAccountID()
        {
            return accountID;
        }
        public double GetMoneyDollars()
        {
            return moneyDollars;
        }

        public double GetMoneyTenge()
        {
            return moneyTenge;
        }

        public double GetMoneyRuble()
        {
            return moneyRuble;
        }

    }
}
