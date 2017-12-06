using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat.AccountNamespace;
using Bankomat.BankNamespace;
using Bankomat.ClientNamespace;

namespace Bankomat
{
    public class ATM
    {
        private DateTime lastActivity;
        private Client currentClient;
        private Bank currentBank;
        private string password;
        private string currentName;
        private string currentNameAccount;
        private int currentId;
        private bool isSafe;

        public ATM(Bank bank)
        {
            currentBank = bank;
        }

        public void Init()
        {
            Console.WriteLine("Enter your name");
            currentName = Console.ReadLine();
            Console.WriteLine("Enter your name of account");
            currentNameAccount = Console.ReadLine();
            Console.WriteLine("Enter your account id");

            if (int.TryParse(Console.ReadLine(), out currentId))
            {

            }
            else
            {
                Console.WriteLine("Enter normal value of id");
            }
            
            foreach(Client c in currentBank.GetClients())
            {
                if (c.GetName() == currentName)
                {
                   for(int i = 0; i < c.GetAccountCounter(); i++)
                    {
                        if(c.)
                    }
                }
            }

        }

        public void AddMoney(Client temp)
        {
            int answer;
            int amount;
            Console.WriteLine("Which account you want to top up?\nUSD - 1\nTenge - 2\nRuble - 3");
            if (int.TryParse(Console.ReadLine(), out answer))
            {
                switch (answer)
                {
                    case 1:
                        Console.WriteLine("Enter your amount");
                        if (int.TryParse(Console.ReadLine(), out amount))
                        {
                            temp.GetAccountDollar().AddMoney(amount);
                        }
                        else
                        {
                            Console.WriteLine("Please enter normal value");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter your amount");
                        if (int.TryParse(Console.ReadLine(), out amount))
                        {
                            temp.GetAccountTenge().AddMoney(amount);
                        }
                        else
                        {
                            Console.WriteLine("Please enter normal value");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter your amount");
                        if (int.TryParse(Console.ReadLine(), out amount))
                        {
                            temp.GetAccountRuble().AddMoney(amount);
                        }
                        else
                        {
                            Console.WriteLine("Please enter normal value");
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("Please enter normal value");
            }
            lastActivity = DateTime.Now;
        }

        public void ShowBalance(Client temp)
        {
            int answer;
            Console.WriteLine("Which account you want to show?\nUSD - 1\nTenge - 2\nRuble - 3");
            if (int.TryParse(Console.ReadLine(), out answer)) {
                switch (answer)
                {
                    case 1:
                        Console.WriteLine(temp.GetAccountDollar().GetMoneyAmmount());
                        break;
                    case 2:
                        Console.WriteLine(temp.GetAccountTenge().GetMoneyAmmount());
                        break;
                    case 3:
                        Console.WriteLine(temp.GetAccountRuble().GetMoneyAmmount());
                        break;

                }
            };

        }

    }
}
