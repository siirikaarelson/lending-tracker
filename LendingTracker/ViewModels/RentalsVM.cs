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


        internal void saveOrUpdateRental(DBA.Rental _rental)
        {

            if (_rental.id == 0)
            {
                _dataContext.Rentals.InsertOnSubmit(_rental);
            }

            _dataContext.SubmitChanges();

            if (_rental.id == 0)
            {
                _rentalsList.Add(_rental);
            }
        }
    }
}
