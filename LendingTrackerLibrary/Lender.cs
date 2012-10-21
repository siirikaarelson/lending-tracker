using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary
{
    public class Lender
    {
        private string _name;
        private Gender _gender;

        public Gender Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public Lender()
        {
        }
       
    }
}
