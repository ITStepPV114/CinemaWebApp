using CinemaWebApp.Models;
using CinemaWebApp.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CinemaWebApp.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Session? NewSession { get; set; }
        public Movie? MovieInfo { get; set; }
        public string Message { get; set; }
        public void OnGet(int id) {
            MovieInfo = MovieService.Get(id);
        }
        public IActionResult OnPost()
        {
            NewSession.Id = 1;
            Message= $"{NewSession.DateSession}";
            return Page();
        }
    }
}
