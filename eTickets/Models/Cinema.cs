using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Cinema {

        [Key]
        public int id { get; set; }
        public string logo { get; set; }
        public string name { get; set; }
        public string description { get; set; }


        //Relationships
        public List<Movie> movies { get; set; }


    }
}
