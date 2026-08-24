// SAFE — open_redirect: LocalRedirect refuses absolute destinations
using Microsoft.AspNetCore.Mvc;
public class V05FrameworkNativeSafe {
  Microsoft.AspNetCore.Mvc.IActionResult Result;
  public void Run(string input) {
    Result = new LocalRedirectResult(input);
  }
}
