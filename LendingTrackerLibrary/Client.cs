using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary
{
    public class Client
    {
        private int Id { get; set; }
        private string FullName{ get; set; }
        private string Description { get; set; }
        private string Comment { get; set; }

        public Client(int idIn, string fullName)
        {
            this.Id = idIn;     
            this.FullName = fullName;
        }

    }
}
