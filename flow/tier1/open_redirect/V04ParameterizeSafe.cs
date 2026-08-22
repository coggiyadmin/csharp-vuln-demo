// SAFE — open_redirect: fixed local route; input is an escaped query value
using Microsoft.AspNetCore.Mvc;
public class V04ParameterizeSafe {
  Microsoft.AspNetCore.Mvc.IActionResult Result;
  public void Run(string input) {
    var target = "/go?next=" + System.Uri.EscapeDataString(input);
    Result = new RedirectResult(target);
  }
}
