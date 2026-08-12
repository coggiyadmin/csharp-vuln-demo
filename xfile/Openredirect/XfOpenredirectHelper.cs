using Microsoft.AspNetCore.Mvc;
namespace Demo.Xfile.Openredirect;
public static class XfOpenredirectHelper {
  public static IActionResult Go(string next) => new RedirectResult(next); // SINK
}
