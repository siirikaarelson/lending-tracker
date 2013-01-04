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

            if (_moviesList == null)
            {
                _moviesList = new ObservableMovies(_dataContext);
            }

            _moviesList.Add(movie);
        }

        public void updateMovie(DBA.Movie movie)
        {
            _dataContext.SubmitChanges();
        }

        public void deleteMovie(DBA.Movie movie)
        {
            if (movie.Rentals == null || movie.Rentals.Count < 1)
            {
                _dataContext.Movies.DeleteOnSubmit(movie);
                _dataContext.SubmitChanges();
                _moviesList.Remove(movie);
            }
            else
            {
                throw new InvalidOperationException("Film(id) on välja laenatud! Välja laentatud filmi ei saa kustutada!");
            }
        }

        public void createSampleMovies()
        {
            DBA.Movie movie = new DBA.Movie();
            movie.Title = "Batman ja Superman";
            movie.Quantity = 3;
            movie.Year = 2012;
            movie.Description = "Superman ja Batman lähevad kala püüdma";
            movie.Comment = "Hirmus film kohe";

            saveMovie(movie);

            DBA.Movie movie2 = new DBA.Movie();
            movie2.Title = "Saag 4";
            movie2.Quantity = 1;
            movie2.Year = 2011;
            movie2.Description = "Saeme aga inimesi seal filmis";
            movie2.Comment = "Hirmus film ka kohe";

            saveMovie(movie2);

            DBA.Movie movie3 = new DBA.Movie();
            movie3.Title = "Jaht Venemoodi";
            movie3.Quantity = 2;
            movie3.Year = 1945;
            movie3.Description = "Täitsa hea film";
            movie3.Comment = "Kalapüügi oma";

            saveMovie(movie3);

        }
    }
}
