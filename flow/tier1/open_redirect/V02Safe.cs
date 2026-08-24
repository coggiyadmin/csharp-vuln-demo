// SAFE — open_redirect: destination resolved from a fixed route table, never from input.
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
public class V02Safe {
  static readonly Dictionary<string, string> Routes = new() {
    ["home"] = "/", ["docs"] = "/docs", ["profile"] = "/me"
  };
  public IActionResult Run(string input) {
    if (!Routes.TryGetValue(input, out var target))
      target = "/";
    return new RedirectResult(target);
  }
}
