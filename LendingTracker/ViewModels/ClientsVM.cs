using LendingTrackerLibrary;
using LendingTrackerLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class ClientVM
    {
        private ObservableClients _clientList;
        private DBA.LINQtoSQLclassesDataContext _dataContext;
      
        public ClientVM(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ObservableClients getClients()
        {
            _clientList = new ObservableClients(_dataContext);
            return _clientList;
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

            _dataContext.Clients.InsertOnSubmit(client);
            _dataContext.SubmitChanges();
            _clientList.Add(client);
            

        }
    }
}
