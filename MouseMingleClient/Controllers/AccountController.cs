using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MouseMingleClient.Models;
using MouseMingleClient.ViewModels;


namespace MouseMingleClient.Controllers;

public class AccountController : Controller
{
  // private readonly MouseMingleClientContext _db;
  // private readonly UserManager<ApplicationUser> _userManager;
  // private readonly SignInManager<ApplicationUser> _signInManager;

  // public AccountController (UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, MouseMingleClientContext db)
  // {
  //   _userManager = userManager;
  //   _signInManager = signInManager;
  //   _db = db;
  // }

  public ActionResult Index()
  {
    return View();
  }

  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Register(RegisterViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }
    ApplicationUser.Register(model);
    return RedirectToAction("Index");
  }

  public ActionResult Login()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Login(LoginViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }
    ApplicationUser.Login(model);
    return RedirectToAction("Index");
  }

  // [HttpPost]
  // public async Task<ActionResult> LogOff()
  // {
  //   await _signInManager.SignOutAsync();
  //   return RedirectToAction("Index");
  // }

  // [HttpPost]
  // public ActionResult Delete()
  // {
  //   return View();
  // }


}