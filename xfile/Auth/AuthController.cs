using Microsoft.AspNetCore.Mvc;
namespace Demo.Xfile.Auth;
public class AuthController : Controller {
  public IActionResult Login(string next) => RedirectHelper.Go(next);
}
