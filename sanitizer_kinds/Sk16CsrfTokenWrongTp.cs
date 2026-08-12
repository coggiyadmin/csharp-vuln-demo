using Microsoft.AspNetCore.Mvc;
public class Sk16CsrfTokenWrongTp : Controller {
  [HttpPost] // missing ValidateAntiForgeryToken
  public IActionResult Post(string action) => Ok(action);
}
