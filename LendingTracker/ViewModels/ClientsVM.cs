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
                                  x.FirstName,
                                  x.LastName,
                                  x.Phone,


                                  x.Email,
                                  x.IDCode,
                                  x.Comment, 
                                  x.VIP,
                                  x.Problematic,
                                  x.DocumentNumber
                              );
                return clients.ToList();
            }
        }

        public void saveClient(LendingTrackerLibrary.Client clientTO)
        {

            DBA.Client client = new DBA.Client();
            client.FirstName = clientTO.FirstName;
            client.LastName = clientTO.LastName;
            client.DocumentNumber = clientTO.DocumentNumber;
            client.IDCode = clientTO.IDCode;
            client.Phone = clientTO.Phone;
            client.Problematic = clientTO.Problematic;
            client.VIP = clientTO.VIP;
            client.Comment = clientTO.Comment;

            using (DBA.LINQtoSQLclassesDataContext db = new DBA.LINQtoSQLclassesDataContext())
            {
                db.Clients.InsertOnSubmit(client);
                db.SubmitChanges();
            }

        }
    }
}
