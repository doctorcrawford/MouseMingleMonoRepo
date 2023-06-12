using Microsoft.AspNetCore.Mvc;
using MouseMingleClient.Models;

namespace MouseMingleClient.Controllers;

public class InterestsController : Controller
{
  public IActionResult Index()
  {
    List<Interest> interests = Interest.GetAll();
    
    return View(interests);
  }
}