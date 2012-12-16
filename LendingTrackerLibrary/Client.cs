using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary
{
    public class Client
    {

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public long? IDCode { get; set; }
        public string Comment { get; set; }
        public bool VIP { get; set; }
        public bool Problematic { get; set; }
        public string DocumentNumber { get; set; }


        public Client(int idIn, string firstName, string lastName, string phone, 
            string email, long? idCode, string comment, bool vip, bool problematic, string documentNumber)
        {
            this.Id = idIn;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.Email = email;
            this.IDCode = idCode;
            this.Comment = comment;
            this.VIP = vip;
            this.Problematic = problematic;
            this.DocumentNumber = documentNumber;

        }

        public Client()
        {
          
        }



    }
}
