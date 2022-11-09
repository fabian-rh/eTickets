using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Producer {

        [Key]
        public int id { get; set; }
        public string profilePictureURL { get; set; }
        public string fullname { get; set; }
        public string bio { get; set; }

        //Relationships
        public List<Movie> movies { get; set; }


    }
}
