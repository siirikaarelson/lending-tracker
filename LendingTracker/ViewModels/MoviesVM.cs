using LendingTrackerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class MoviesVM
    {
       
        public MoviesVM()
        {
            
        }

        public List<Movie> getMovies()
        {
            using (DBA.LINQtoSQLclassesDataContext db = new DBA.LINQtoSQLclassesDataContext())
            {
                var clients = from x in db.Catalogs
                              select new Movie (x.id, x.Title, x.Descr, x.Comment, x.Year);
                return clients.ToList();
            }
        }

        public void saveMovie(Movie movieIn)
        {

            DBA.Catalog movie = new DBA.Catalog();
            movie.Title = movieIn.Title;
            movie.Year = movieIn.Year;
            movie.Descr = movieIn.Description;
            movie.Comment = movieIn.Comment;
            movie.Genre = "TODO";
         
            using (DBA.LINQtoSQLclassesDataContext db = new DBA.LINQtoSQLclassesDataContext())
            {
                db.Catalogs.InsertOnSubmit(movie);
                db.SubmitChanges();
                Console.WriteLine(movie.id);
            }

        }

    }
}
