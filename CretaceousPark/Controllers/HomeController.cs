using Microsoft.AspNetCore.Mvc;

namespace CretaceousPark.Controllers
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