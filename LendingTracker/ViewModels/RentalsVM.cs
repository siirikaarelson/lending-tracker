using LendingTrackerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class RentalsVM
    {
        private List<Rental> _rentals;

        public List<Rental> Rentals
        {
            get { return _rentals; }
            set { _rentals = value; }
        }

        public RentalsVM()
        {
            using (DBA.LINQtoSQLclassesDataContext db = new DBA.LINQtoSQLclassesDataContext())
            {
                var rentals = from x in db.Rentals
                              select new Rental
                                  (x.id,
                                  x.Client.FirstName,
                                  x.Client.LastName,
                                  x.StartDate,
                                  x.EndDate,
                                  x.Notify,
                                  x.Comment,
                                  x.Catalog.Title);
                this._rentals = rentals.ToList();
            }
        }
    }
}
