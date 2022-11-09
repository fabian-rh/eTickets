using eTickets.Data.Enums;
using eTickets.Models;

namespace eTickets.Data {
    public class AppDbInitializer {


        public static void seed(IApplicationBuilder applicationBuilder) {
            //we're creating an application services scope
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope()) {
                var context = serviceScope.ServiceProvider.GetService<AppDBContext>();
                context.Database.EnsureCreated();

                //Cinema
                if (!context.cinemas.Any()) {
                    context.cinemas.AddRange(new List<Cinema>()
                    {
                        new Cinema()
                        {
                            name = "Cinema 1",
                            logo = "http://dotnethow.net/images/cinemas/cinema-1.jpeg",
                            description = "This is the d of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 2",
                            logo = "http://dotnethow.net/images/cinemas/cinema-2.jpeg",
                            description  = "This is the d of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 3",
                            logo = "http://dotnethow.net/images/cinemas/cinema-3.jpeg",
                            description = "This is the d of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 4",
                            logo = "http://dotnethow.net/images/cinemas/cinema-4.jpeg",
                            description = "This is the d of the first cinema"
                        },
                        new Cinema()
                        {
                            name = "Cinema 5",
                            logo = "http://dotnethow.net/images/cinemas/cinema-5.jpeg",
                            description = "This is the d of the first cinema"
                        },
                    });
                    context.SaveChanges();
                }
                //actors
                if (!context.actors.Any()) {
                    context.actors.AddRange(new List<Actor>()
                    {
                        new Actor()
                        {
                            fullname = "Actor 1",
                            bio = "This is the bio of the first actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-1.jpeg"

                        },
                        new Actor()
                        {
                            fullname = "Actor 2",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-2.jpeg"
                        },
                        new Actor()
                        {
                            fullname = "Actor 3",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-3.jpeg"
                        },
                        new Actor()
                        {
                            fullname = "Actor 4",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-4.jpeg"
                        },
                        new Actor()
                        {
                            fullname = "Actor 5",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/actors/actor-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //producers
                if (!context.producers.Any()) {
                    context.producers.AddRange(new List<Producer>()
                    {
                        new Producer()
                        {
                            fullname = "Producer 1",
                            bio = "This is the bio of the first actor",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-1.jpeg"

                        },
                        new Producer()
                        {
                            fullname = "Producer 2",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-2.jpeg"
                        },
                        new Producer()
                        {
                            fullname = "Producer 3",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-3.jpeg"
                        },
                        new Producer()
                        {
                            fullname = "Producer 4",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-4.jpeg"
                        },
                        new Producer()
                        {
                            fullname = "Producer 5",
                            bio = "This is the bio of the second actor",
                            profilePictureURL = "http://dotnethow.net/images/producers/producer-5.jpeg"
                        }
                    });
                    context.SaveChanges();
                }
                //movies
                if (!context.movies.Any()) {
                    context.movies.AddRange(new List<Movie>()
                    {
                        new Movie()
                        {
                            name = "Life",
                            description = "This is the Life movie d",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-3.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(10),
                            cinemaId = 3,
                            producerId = 3,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "The Shawshank Redemption",
                            description = "This is the Shawshank Redemption d",
                            price = 29.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-1.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(3),
                            cinemaId = 1,
                            producerId = 1,
                            movieCategory = MovieCategory.Action
                        },
                        new Movie()
                        {
                            name = "Ghost",
                            description = "This is the Ghost movie d",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-4.jpeg",
                            startDate = DateTime.Now,
                            endDate = DateTime.Now.AddDays(7),
                            cinemaId = 4,
                            producerId = 4,
                            movieCategory = MovieCategory.Drama
                        },
                        new Movie()
                        {
                            name = "Race",
                            description = "This is the Race movie d",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-6.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-5),
                            cinemaId = 1,
                            producerId = 2,
                            movieCategory = MovieCategory.Documentary
                        },
                        new Movie()
                        {
                            name = "Scoob",
                            description = "This is the Scoob movie d",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-7.jpeg",
                            startDate = DateTime.Now.AddDays(-10),
                            endDate = DateTime.Now.AddDays(-2),
                            cinemaId = 1,
                            producerId = 3,
                            movieCategory = MovieCategory.Comedy
                        },
                        new Movie()
                        {
                            name = "Cold Soles",
                            description = "This is the Cold Soles movie d",
                            price = 39.50,
                            imageURL = "http://dotnethow.net/images/movies/movie-8.jpeg",
                            startDate = DateTime.Now.AddDays(3),
                            endDate = DateTime.Now.AddDays(20),
                            cinemaId = 1,
                            producerId = 5,
                            movieCategory = MovieCategory.Drama
                        }
                    });
                    context.SaveChanges();
                }
                //actors & movies
                if (!context.actors_movies.Any()) {
                    context.actors_movies.AddRange(new List<Actor_Movie>()
                    {
                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 1
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 1
                        },

                         new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 2
                        },
                         new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 2
                        },

                        new Actor_Movie()
                        {
                            actorId = 1,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 3
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 3
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 4
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 4
                        },


                        new Actor_Movie()
                        {
                            actorId = 2,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 5
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 5
                        },


                        new Actor_Movie()
                        {
                            actorId = 3,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 4,
                            movieId = 6
                        },
                        new Actor_Movie()
                        {
                            actorId = 5,
                            movieId = 6
                        },
                    });
                    context.SaveChanges();
                }

            }

        }
    }
}
