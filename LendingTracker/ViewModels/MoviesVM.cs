using LendingTrackerLibrary;
using LendingTrackerLibrary.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class MoviesVM
    {
        private DBA.LINQtoSQLclassesDataContext _dataContext;
        private ObservableMovies _moviesList;
       
        public MoviesVM(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public ObservableMovies getMovies()
        {
            _moviesList = new ObservableMovies(_dataContext);
            return _moviesList;
        }

        public void saveMovie(DBA.Movie movie)
        {
            _dataContext.Movies.InsertOnSubmit(movie);
            _dataContext.SubmitChanges();
            _moviesList.Add(movie);
        }

        public void updateMovie(DBA.Movie _movie)
        {
            _dataContext.SubmitChanges();
        }
    }
}
