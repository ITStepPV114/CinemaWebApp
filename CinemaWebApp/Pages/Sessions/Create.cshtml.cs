using CinemaWebApp.Models;
using CinemaWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages.Sessions
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Session? NewSession { get; set; }
        [BindProperty]
        public int IdMovie { get; set; }
        public Movie? MovieInfo { get; set; }
        public string? Message { get; set; }
        public void OnGet(int id) {
            MovieInfo = MovieService.Get(id);
            IdMovie = id;
         }
        public IActionResult OnPost()
        {
            Message= $"{NewSession?.DateSession.ToShortDateString()}  {NewSession?.TimeSession}  {IdMovie}";
            MovieService.AddSessionToMovie(IdMovie, NewSession);
            // "/InfoMovie" => Pages/InfoMovie 
            // "../InfoMovie" => Pages/InfoMovie 
            // "InfoMovie" => Pages/Sessions/InfoMovie 
            // "./InfoMovie" => Pages/Sessions/InfoMovie 


            return RedirectToPage("/InfoMovie", new  {id=IdMovie});
        }
    }
}
