using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary.Data
{
    public class ObservableClients : ObservableCollection<DBA.Client>
    {
        public ObservableClients(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            foreach (DBA.Client thisClient in dataContext.Clients)
            {

                //Client cl = new Client();

                //cl.Id = thisClient.id;
                //cl.FirstName = thisClient.FirstName;
                //cl.LastName = thisClient.LastName;
                //cl.Phone = thisClient.Phone;
                //cl.Email = thisClient.Email;
                //cl.IDCode = thisClient.IDCode;
                //cl.Comment = thisClient.Comment;
                //cl.VIP = thisClient.VIP;
                //cl.Problematic = thisClient.Problematic;
                //cl.DocumentNumber = thisClient.DocumentNumber;

          
        
                this.Add(thisClient);
            }

        }
    }
}
