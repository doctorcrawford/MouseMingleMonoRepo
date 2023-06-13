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

  public IActionResult Details(int id)
  {
    var interest = Interest.GetDetails(id);

    return View(interest);
  }

  public ActionResult Create()
  {
    return View();
  }

  [HttpPost]
  public ActionResult Create(Interest interest)
  {
    Interest.Post(interest);
    return RedirectToAction("Index");
  }

  public ActionResult Edit(int id)
  {
    Interest interest = Interest.GetDetails(id);
    return View(interest);
  }

  [HttpPost]
  public ActionResult Edit(Interest interest)
  {
    Interest.Put(interest);
    return RedirectToAction("Details", new { id = interest.InterestId});
  }

  public ActionResult Delete(int id)
  {
    Interest interest = Interest.GetDetails(id);
    return View(interest);
  }

  [HttpPost, ActionName("Delete")]
  public ActionResult DeleteConfirmed(int id)
  {
    Interest.Delete(id);
    return RedirectToAction("Index");
  }
}