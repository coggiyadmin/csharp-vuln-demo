using Microsoft.AspNetCore.Mvc;
public class InfoDisclosureTp : Controller {
  public IActionResult Err() {
    try { throw new System.Exception("db password=secret"); }
    catch (System.Exception ex) { return Content(ex.ToString()); } // SINK CWE-209
  }
}
