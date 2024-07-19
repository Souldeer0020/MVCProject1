using Microsoft.AspNetCore.Mvc;

namespace MVCProject1.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult GetMovies(int Id)
        {
            return Content($"The ID of the movie is {Id}");
        }
        public IActionResult Index(int Id)
        {
            //ContentResult result = new ContentResult();
            //result.Content = "Index";
            //return result;
            return Content("Index", "text/html");
        }
        public /*RedirectResult*/ IActionResult Reedirect() // here we use the parent interface of all actions so it`d be more flexible
        {
            //RedirectResult result = new RedirectResult("https://localhost:44371/Movies/Index");
            //return result;
            //return Redirect("https://localhost:44371/Movies/Index");

            //return RedirectToAction("Index"); //more dynamic than the above return (we pass the Action name as a parameter)

            return RedirectToRoute("default", new { controller = "Home", action = "Index" });
        }

    }
}
