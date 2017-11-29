using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccountNamespace;

namespace ClientNamespace
{
    public class Client
    {
        private string name;
        private List<Account> clientAccounts;

        public Client(string name)
        {
            this.name = name;
            clientAccounts = new List<Account>();
        }

        public List<Account> GetAccounts()
        {
            return clientAccounts;
        }

        public string GetName()
        {
            return name;
        }
    }
}
