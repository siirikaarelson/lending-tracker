using LendingTracker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.Helpers
{
    public class DatabaseHelper
    {
        DBA.LINQtoSQLclassesDataContext _dataContext;

        public DatabaseHelper()
        {
            _dataContext = new DBA.LINQtoSQLclassesDataContext();
        }
      
      
        public bool hasDatabase() {
            return _dataContext.DatabaseExists();
        }

        public void createDatabase() 
        {
            _dataContext.CreateDatabase();
        }

        internal void createSampleData(bool isFullDataNeeded)
        {
            if (isFullDataNeeded)
            {
                ClientVM _clientVM = new ClientVM(_dataContext);
                _clientVM.createSampleClients();

                MoviesVM _moviesVM = new MoviesVM(_dataContext);
                _moviesVM.createSampleMovies();
            }

            UserVM _userVM = new UserVM(_dataContext);
            _userVM.createDefaultUser();

        }
    }
}
