using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary.Data
{
    public class ObservableRentals : ObservableCollection<DBA.Rental>
    {
        public ObservableRentals(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            foreach (DBA.Rental thisRental in dataContext.Rentals)
            {
                this.Add(thisRental);
            }

        }
    }
}
