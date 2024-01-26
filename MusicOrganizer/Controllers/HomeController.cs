using Microsoft.AspNetCore.Mvc;



namespace MusicOrganizer.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Splash() 
    { 
      return View(); 
    }
  }
}