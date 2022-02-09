using System;
using System.ComponentModel.DataAnnotations;


namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }  // primary key 
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public string Gerne { get; set;}
        public decimal Price { get; set; }
    }
}
