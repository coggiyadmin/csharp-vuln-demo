using Microsoft.AspNetCore.Mvc;
public class Ch16MvcViewBag : Controller {
  public IActionResult Index(string msg) {
    ViewBag.Html = msg;
    return View();
  }
}
