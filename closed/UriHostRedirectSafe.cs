using Microsoft.AspNetCore.Mvc;
// cognium-dev#1116 — Uri.Host compared to a literal stays clean
public class UriHostRedirectSafe : ControllerBase {
  public IActionResult Run(string input) {
    var host = new Uri(input, UriKind.RelativeOrAbsolute).Host;
    return host == "app.example.com" ? Redirect(input) : Redirect("/home");
  }
}
