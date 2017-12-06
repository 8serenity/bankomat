using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat.AccountNamespace;

namespace Bankomat
{
    namespace ClientNamespace
    {
        public class Client
        {
            private string name;
            private Account dollarAccount;
            private Account tengeAccount;
            private Account rubleAccount;
            private int accountCounter;

            public Client(string name)
            {
                this.name = name;
                dollarAccount = new Account("Dollar");
                tengeAccount = new Account("Tenge");
                rubleAccount = new Account("Ruble");
                accountCounter = 3;
            }


            public int GetAccountCounter()
            {
                return accountCounter;
            }

            public Account GetAccountDollar()
            {
                return dollarAccount;
            }
            public Account GetAccountTenge()
            {
                return tengeAccount;
            }
            public Account GetAccountRuble()
            {
                return rubleAccount;
            }

            public string GetName()
            {
                return name;
            }
        }
    }
}
