using CinemaWebApp.Models;
using CinemaWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages
{
    [IgnoreAntiforgeryToken]
    public class EditMovieModel : PageModel
    {
        public Movie? EditMovie { get; set; }
        public IActionResult OnGet(int id)
        {
            EditMovie = MovieService.Get(id);
            if (EditMovie==null) return RedirectToPage("Index");
            return Page();
        }
        public IActionResult OnPost(Movie movie)
        {

        
            MovieService.Update(movie);
            return RedirectToPage("Index");
            //return Page();
        }
    }
}
