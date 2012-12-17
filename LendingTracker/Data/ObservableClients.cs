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
                this.Add(thisClient);
            }

        }
    }
}
