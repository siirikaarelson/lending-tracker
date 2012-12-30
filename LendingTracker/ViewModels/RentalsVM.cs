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
            if (_rentalsList == null)
            {
                _rentalsList = new ObservableRentals(_dataContext);
            }
            return _rentalsList;
        }


        internal void saveOrUpdateRental(DBA.Rental _rental)
        {
            bool save = false;

            if (_rental.id == 0)
            {
                _dataContext.Rentals.InsertOnSubmit(_rental);
                save = true;
            }

            _dataContext.SubmitChanges();

            if (save)
            {
                _rentalsList.Add(_rental);
            }
        }
    }
}
