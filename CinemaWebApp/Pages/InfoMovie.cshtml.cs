using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Http;
using CinemaWebApp.Models;
using CinemaWebApp.Service;

namespace CinemaWebApp.Pages
{
    public class InfoMovieModel : PageModel
    {
        public string Message { get; set; }
        public Movie? MovieInfo { get; set; }
        public void OnGet(int id)
        {
            //int id = int.Parse(Request.Query["id"]);
            Message = $"Id:{id}";
            MovieInfo = MovieService.Get(id);
           

        }
    }
}
