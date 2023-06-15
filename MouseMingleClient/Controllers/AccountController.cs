using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using MouseMingleClient.Models;
using MouseMingleClient.ViewModels;
// using Microsoft.AspNetCore.Http;
// using System.Web;
// using Microsoft.AspNetCore.Http.Features;
// using System.Security.Claims;


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
    ViewBag.UserName = HttpContext.Session.GetString("username");
    return View();
  }

  public IActionResult Register()
  {
    return View();
  }

  [HttpPost]
  public async Task<ActionResult> Register(RegisterViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }
    await ApplicationUser.RegisterAsync(model);
    return RedirectToAction("Index");
  }

  public ActionResult Login()
  {
    return View();
  }

  [HttpPost]
  public async Task<ActionResult> Login(LoginViewModel model)
  {
    if (!ModelState.IsValid)
    {
      return View(model);
    }
    var tokenModel = await ApplicationUser.LoginAsync(model);
    HttpContext.Session.SetString("jwt", tokenModel.Token);
    HttpContext.Session.SetString("username", tokenModel.UserName);
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