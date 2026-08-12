using Microsoft.AspNetCore.Mvc;
public class Sk07AllowlistRedirectWrongTp : Controller {
  public IActionResult Run(string next) {
    var v = next.Replace("http://", ""); // wrong
    return Redirect(v); // SINK CWE-601
  }
}
