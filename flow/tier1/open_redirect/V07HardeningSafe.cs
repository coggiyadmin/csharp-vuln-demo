// SAFE — open_redirect: key lookup — the destination is never user text
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class V07HardeningSafe {
  Microsoft.AspNetCore.Mvc.IActionResult Result;
  public void Run(string input) {
    var routes = new Dictionary<string, string> { ["home"] = "/", ["docs"] = "/docs" };
    if (!routes.TryGetValue(input, out var target))
      return;
    Result = new RedirectResult(target);
  }
}
