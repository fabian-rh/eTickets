using eTickets.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eTickets.Models{
    public class Movie {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imageURL { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public MovieCategory movieCategory { get; set; }

        //Relationships
        public List<Actor_Movie> actors_movies { get; set; }

        //Cinema
        public Cinema cinema { get; set; }


        [ForeignKey("cinemaId")]

        public int cinemaId { get; set; }

        //Producer
        public Producer producer { get; set; }

        [ForeignKey("producerId")]
        public int producerId { get; set; }


    }//class
}//namespace
