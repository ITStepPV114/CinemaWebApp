using CinemaWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CinemaWebApp.Service;

namespace CinemaWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public List<Movie> Movies { get; set; } = new ();
        //public IndexModel()
        //{
        //    //Movies = new List<Movie>();
        //    Movies = MovieService.GetAll();

        //}

        public void OnGet()
        {
            Movies = MovieService.GetAll();
        }



    }
}