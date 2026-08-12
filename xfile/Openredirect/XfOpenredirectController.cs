namespace Demo.Xfile.Openredirect;
public static class XfOpenredirectController {
  public static Microsoft.AspNetCore.Mvc.IActionResult Handle(string next) => XfOpenredirectHelper.Go(next);
}
