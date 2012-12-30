using LendingTrackerLibrary;
using LendingTrackerLibrary.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LendingTracker.ViewModel
{
    public class UserVM
    {
       
        private DBA.LINQtoSQLclassesDataContext _dataContext;

        public UserVM(DBA.LINQtoSQLclassesDataContext dataContext)
        {
            _dataContext = dataContext;
        }

      
        public void saveUser(DBA.User user)
        {
            if (user.id == 0)
            {
                _dataContext.Users.InsertOnSubmit(user);
            }

            _dataContext.SubmitChanges();

        }


        public DBA.User getMainUser()
        {
            var query = (from x in _dataContext.Users where x.Username == "admin" select x).FirstOrDefault();
            return query;
       }

        public void createDefaultUser()
        {
       
            DBA.User user = new DBA.User();
            user.Username = "admin";
            user.Password = createHash("admin");

            _dataContext.Users.InsertOnSubmit(user);
            _dataContext.SubmitChanges();

        
        }

        private static string createHash(string password)
        {
            SHA256Managed hash = new SHA256Managed();
            byte[] passwordBytes = Encoding.UTF8.GetBytes(password);
            byte[] hashBytes = hash.ComputeHash(passwordBytes);
            return Encoding.UTF8.GetString(hashBytes);
        }

        internal bool verifyLogin(string username, string password)
        {
            bool result = false;

            DBA.User user = getMainUser();

            if (user != null && user.Password.Equals(createHash(password)))
            {
                result = true;
            } 


            return result;
        }

        internal void updatePassword(string password)
        {
            DBA.User user = getMainUser();
           
            if (user != null) 
            {
                user.Password = createHash(password);
                _dataContext.SubmitChanges();
            }
         
        }
    }
}
