using Microsoft.AspNetCore.Mvc;
namespace Demo.Xfile.Auth;
public static class RedirectHelper {
  public static IActionResult Go(string next) => new RedirectResult(next); // SINK CWE-601
}
