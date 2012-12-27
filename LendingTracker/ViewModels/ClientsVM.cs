using LendingTrackerLibrary;
using LendingTrackerLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
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

        public void saveClient(DBA.Client clientTO)
        {
            _dataContext.Clients.InsertOnSubmit(clientTO);
            _dataContext.SubmitChanges();
            _clientList.Add(clientTO);

        }


        public DBA.Client getClient(long clientId)
        {
            var query = (from x in _dataContext.Clients where x.id == clientId select x).FirstOrDefault();
            return query;
        }


        internal void updateClient(DBA.Client _client)
        {
            _dataContext.SubmitChanges();
        }
    }
}
