using Microsoft.AspNetCore.Mvc;

namespace Dealerships.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}