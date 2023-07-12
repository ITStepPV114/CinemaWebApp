using CinemaWebApp.Models;
using Microsoft.AspNetCore.SignalR;

namespace CinemaWebApp.Service
{
    public static class MovieService
    {
        public static List<Movie> Movies { get; set; }
        static int nextId = 0;
        static  MovieService() {
            Movies = new List<Movie>(); 
            FullData();
        }

        public static List<Movie> GetAll() => Movies;
        public static Movie? Get(int id)=>Movies.FirstOrDefault(x => x.Id == id);
        public static void Add(Movie movie) { 
            movie.Id = ++nextId;
            Movies.Add(movie);
        }

        public static void Update(Movie movie)
        {
            int index = Movies.FindIndex(x=>x.Id==movie.Id);
            if (index == -1) return;
            Movies[index] = movie;
        }
        public static void FullData()
        {
           
            Movies.Add(new Movie()
            {
                Id = ++nextId,
                Title = "Title1",
                Director = "Autor1",
                Style = "Thirller",
                ShortDescription = "Info...",
                Sessions = new List<Session>
                {
                    new Session()
                    {
                        Id=1,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(10,30)
                    },
                     new Session()
                    {
                        Id=2,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(14,30)
                    },
                     new Session()
                    {
                        Id=3,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(17,30)
                    }
                }

            });
            Movies.Add(new Movie()
            {
                Id = ++nextId,
                Title = "Title2",
                Director = "Autor2",
                Style = "Fantasy",
                ShortDescription = "Info...",
                Sessions = new List<Session>
                {
                    new Session()
                    {
                        Id=4,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(12,15)
                    },
                     new Session()
                    {
                        Id=5,
                        DateSession=new DateTime(2023,07,12),
                        TimeSession=new TimeOnly(14,30)
                    },
                     new Session()
                    {
                        Id=6,
                        DateSession=new DateTime(2023,07,11),
                        TimeSession=new TimeOnly(17,30)
                    }
                }

            });
        }
    }
}
