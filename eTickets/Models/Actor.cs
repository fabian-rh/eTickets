﻿using System.ComponentModel.DataAnnotations;

namespace eTickets.Models {
    public class Actor {

        [Key]
        public int id { get; set; }
        public string profilePictureURL { get; set; }
        public string fullname { get; set; }
        public string bio { get; set; }

        //Relationships
        public List<Actor_Movie> actors_movies { get; set; }





    }
}
