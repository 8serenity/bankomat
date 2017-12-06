using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat
{
    namespace AccountNamespace
    {
        public class Account
        {
            private int accountID;
            private string name;
            private string password;
            private double amountMoney;
            static Random random;

            static Account()
            {
                random = new Random();
            }

            public Account(string name)
            {
                this.name = name;
                accountID = random.Next(10000000, 100000000);
                password = random.Next(1000, 10000).ToString();
                amountMoney = 0;
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

            public string GetPassword()
            {
                return password;
            }

            public int GetAccountID()
            {
                return accountID;
            }
            public double GetMoneyAmmount()
            {
                return amountMoney;
            }

            public void SetMoneyAmount(int money)
            {
                amountMoney = money;
            }

            public void AddMoney(int money)
            {
                amountMoney += money;
            }

            public string GetName()
            {
                return name;
            }
        }
    }
}