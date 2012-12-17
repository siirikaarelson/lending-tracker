using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary
{
    public class Rental
    {
        private int _id;
        private string _clientName;
        private string _clientSurname;
        private string _clientFullName;
        private string _movieName;
        private DateTime _endDate;
        private DateTime _startDate;
        private bool _notify;
        private string _comment;

        public string MovieName
        {
            get { return _movieName; }
            set { _movieName = value; }
        }
        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string ClientName
        {
            get { return _clientName; }
            set { _clientName = value; }
        }
        public string ClientSurname
        {
            get { return _clientSurname; }
            set { _clientSurname = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        public DateTime EndDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }
        public bool Notify
        {
            get { return _notify; }
            set { _notify = value; }
        }
     
        public string ClientFullName
        {
            get { return _clientName+_clientSurname; }
            set { _clientFullName = value; }
        }
     
        public string Comment
        {
            get { return _comment; }
            set { _comment = value; }
        }

        public Rental(int id, string name, string surname, DateTime startdate, 
            DateTime enddate, bool notify, string comment, string moviename)
        {
            this._id = id;
            this._clientName = name;
            this._clientSurname = surname;
            this._startDate = startdate;
            this._endDate = enddate;
            this._notify = notify;
            this._comment = comment;
            this._movieName = moviename;
        }


        public Rental()
        {
        }
    }
}
