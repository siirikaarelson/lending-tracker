using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary
{
    public class Movie
    {
        private int Id { get; set; }
        private string Title{ get; set; }
        private string Description { get; set; }
        private string Comment { get; set; }

        public Movie(int idIn, string titleIn, string descriptionIn, string comment)
        {
            this.Id = idIn;
            this.Title = titleIn;
            this.Comment = comment;
            this.Description = descriptionIn;
        }

    }
}
