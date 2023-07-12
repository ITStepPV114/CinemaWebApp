using CinemaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CinemaWebApp.Service;

namespace CinemaWebApp.Pages
{
    [IgnoreAntiforgeryToken]
    public class CreateMovieModel : PageModel
    {
        public string Message { get; set; }
        public void OnGet()
        {
        }
        public IActionResult OnPost(Movie movie)
        {

            Message = $"{movie.Title}";
            MovieService.Add(movie);
            return RedirectToPage("Index");
            //return Page();
        }
        //public void OnPost(string Title, string Director, string Style, string ShortDescripton)
        //{

        //    Message = $"{movie.Title}";
        //    Message = $"{Title} {Director}";
        //}
    }
}
