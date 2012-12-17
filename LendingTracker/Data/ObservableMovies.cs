using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary.Data
{
    public class ObservableMovies : ObservableCollection<DBA.Movie>
    {
        public ObservableMovies(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            foreach (DBA.Movie thisMovie in dataContext.Movies)
            {
                this.Add(thisMovie);
            }

        }
    }
}
