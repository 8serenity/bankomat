using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bankomat.ClientNamespace;
using Bankomat.AccountNamespace;

namespace Bankomat
{

    namespace BankNamespace
    {
        public class Bank
        {
            private List<Client> clients;
            private int clientsCounter;

            public Bank()
            {
                clientsCounter = 0;
                clients = new List<Client>();
            }

            public void AddClient(string name)
            {
                Client temp=new Client(name);
                clients.Add(temp);
                clientsCounter++;
            }
            
            public int GetClientsCounter()
            {
                return clientsCounter;
            }

            public List<Client> GetClients()
            {
                return clients;
            }


        }
    }
}