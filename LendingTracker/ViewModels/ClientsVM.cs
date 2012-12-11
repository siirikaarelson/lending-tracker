using LendingTrackerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class ClientVM
    {
       
        public ClientVM()
        {
            
        }

        public List<Client> getClients()
        {
            using (DBA.LINQtoSQLclassesDataContext db = new DBA.LINQtoSQLclassesDataContext())
            {
                var clients = from x in db.Clients
                              select new Client
                                  (x.id,
                                  x.Name);
                return clients.ToList();
            }
        }

        public void saveClient(string fullName)
        {

            DBA.Client client = new DBA.Client();
            client.Name = fullName;
            client.Surname = "TESt";
            client.IDnumber = 12;

            using (DBA.LINQtoSQLclassesDataContext db = new DBA.LINQtoSQLclassesDataContext())
            {
                db.Clients.InsertOnSubmit(client);
                db.SubmitChanges();
                Console.WriteLine(client.id);
            }

        }


        internal void saveClient(object p)
        {
            throw new NotImplementedException();
        }
    }
}
