using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingTrackerLibrary
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Comment { get; set; }
        public int Year { get; set; }

        public Movie(int idIn, string titleIn, string descriptionIn, string comment, int year)
        {
            this.Id = idIn;
            this.Title = titleIn;
            this.Comment = comment;
            this.Description = descriptionIn;
            this.Year = year;
        }

        public Movie()
        {
           
        }

    }
}
