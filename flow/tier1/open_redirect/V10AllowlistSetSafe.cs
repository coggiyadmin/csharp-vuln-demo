using Microsoft.AspNetCore.Mvc;
public class V10AllowlistSetSafe {
  public IActionResult Run(string input) {
    var allow = new[]{"/home","/dash"};
    if (System.Array.IndexOf(allow, input) < 0) return new RedirectResult("/home");
    return new LocalRedirectResult(input);
  }
}
