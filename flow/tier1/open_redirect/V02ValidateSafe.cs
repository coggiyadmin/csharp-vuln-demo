// SAFE — open_redirect: relative-only check, rejecting protocol-relative
using Microsoft.AspNetCore.Mvc;
public class V02ValidateSafe {
  Microsoft.AspNetCore.Mvc.IActionResult Result;
  public void Run(string input) {
    if (!input.StartsWith("/") || input.StartsWith("//"))
      return;
    Result = new RedirectResult(input);
  }
}
