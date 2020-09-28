using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database
{
    public class Client
    {
        public string name { get; set; }
        public List<Client> Clients()
        {
            var clients = new List<Client>();
            clients.Add(new Client() { name = "Gustavo" });
            return clients;
        }
    }
}
