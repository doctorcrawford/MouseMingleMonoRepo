using Microsoft.AspNetCore.Mvc;
using MouseMingleClient.Models;

namespace MouseMingleClient.Controllers;
public class RodentsController : Controller
{
  public async Task<IActionResult> Index()
  {
    var token = HttpContext.Session.GetString("jwt");
    ViewBag.UserName = HttpContext.Session.GetString("username");
    try
    {
      List<Rodent> rodents = await Rodent.GetAllAsync(token);
      return View(rodents);
    }
    catch(Exception e)
    {
      ViewBag.ErrorMessage = e.Message;
      return View();
    }
  }

  public IActionResult Details(int id)
  {
    var rodent = Rodent.GetDetails(id);

    return View(rodent);
  }

  // will need User Id to display join b/w user and their rodent.
  public IActionResult RodentProfile()
  {
    return View();
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Rodent rodent)
  {
    Rodent.Post(rodent);
    // Rodent.FindMyIdWithMyName(rodent);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    var rodent = Rodent.GetDetails(id);

    return View(rodent);
  }

  [HttpPost]
  public ActionResult Edit(Rodent rodent)
  {
    Rodent.Put(rodent);
    return RedirectToAction("Details", new { id = rodent.RodentId });
  }

  public ActionResult Delete(int id)
  {
    var rodent = Rodent.GetDetails(id);

    return View(rodent);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Rodent.Delete(id);
    return RedirectToAction("Index");
  }

  public ActionResult AddInterest(int id)
  {
    List<Interest> interests = Interest.GetAll();
    ViewData["allInterests"] = interests;
    var rodent = Rodent.GetDetails(id);
    return View(rodent);
  }

  [HttpPost]
  public ActionResult AddInterest(Rodent rodent, int[] interestId)
  {
    foreach (int item in interestId)
    {
      Rodent.AddInterestToRodents(rodent.RodentId, item);
    }
    return RedirectToAction("Details", new { id = rodent.RodentId});
  }


  // need tag RodentInterestId

  [HttpPost]
  public ActionResult AddUpVote(int id, string vote)
  {
    Rodent rodent = Rodent.GetDetails(id);
    if (vote == "yes")
    {
      rodent.UpVote++;
    }
    else if (vote == "no")
    {
      rodent.UpVote--;
    }
    Rodent.Put(rodent);
    return RedirectToAction("Index");
  }
}