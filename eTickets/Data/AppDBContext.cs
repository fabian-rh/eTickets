using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace eTickets.Data {
    public class AppDBContext : DbContext{
        //we're passing the parameters options to the base class
        public AppDBContext(DbContextOptions<AppDBContext> options) : base (options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new {
                am.actorId,
                am.movieId
            });


            //Define relationships between entities
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.actors_movies).HasForeignKey(m => m.movieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.actors_movies).HasForeignKey(m => m.actorId);

            //Define table names

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Actor> actors { get; set; }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Actor_Movie> actors_movies { get; set; }
        public DbSet<Cinema> cinemas { get; set; }
        public DbSet<Producer> producers { get; set; }


    }
}
