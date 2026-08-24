// SAFE — open_redirect: wrapper falls back to the site root
using Microsoft.AspNetCore.Mvc;
public class V06CustomWrapperSafe {
  Microsoft.AspNetCore.Mvc.IActionResult Result;
  public void Run(string input) {
    Result = SafeRedirect(input);
  }
  static IActionResult SafeRedirect(string target) {
    return target.StartsWith("/") && !target.StartsWith("//")
      ? new RedirectResult(target)
      : new RedirectResult("/");
  }
}
