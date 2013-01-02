using DBA;
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

            if (_clientList == null)
            {
                _clientList = new ObservableClients(_dataContext);
            }

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

        public void createSampleClients()
        {
            DBA.Client client = new DBA.Client();
            client.FirstName = "Juhan";
            client.LastName = "Kalamees";
            client.Email = "juhan@kalamees.ee";
            client.DocumentNumber = "123 DOC MNR";
            client.VIP = true;
            client.Phone = "241423123";
            client.IDCode = 12345670;

            saveClient(client);


            DBA.Client client2 = new DBA.Client();
            client2.FirstName = "Kala";
            client2.LastName = "Viidikas";
            client2.Email = "viidikas@viidaikas.ee";
            client2.DocumentNumber = "12334444 DOC MNR";
            client2.VIP = false;
            client2.Phone = "23333";
            client2.IDCode = 12345671;

            saveClient(client2);


            DBA.Client client3 = new DBA.Client();
            client3.FirstName = "Suur";
            client3.LastName = "Loom";
            client3.Email = "666@6666.ee";
            client3.DocumentNumber = "66666 DOC MNR";
            client3.VIP = false;
            client3.Problematic = true;
            client3.IDCode = 12345673;

            saveClient(client3);

        }
    }
}
