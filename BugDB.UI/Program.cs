using BugDB.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BugDB.BL;

namespace BugDatabase
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Lineadded here for home3");
            var clientRepo = new ClientRepository();
            var client = new Client { ContactName = "Dave", Name = "DaveCo" };
            clientRepo.Save(client);
        }
    }
}
