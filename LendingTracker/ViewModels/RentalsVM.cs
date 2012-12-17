using LendingTrackerLibrary;
using LendingTrackerLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class RentalsVM
    {
        private DBA.LINQtoSQLclassesDataContext _dataContext;
        private ObservableRentals _rentalsList;
       
        public RentalsVM(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ObservableRentals getRentals()
        {
            _rentalsList = new ObservableRentals(_dataContext);
            return _rentalsList;
        }


        public void saveRental(Rental rentalTO)
        {

        }
    }
}
