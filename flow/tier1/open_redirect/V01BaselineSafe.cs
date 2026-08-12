using Microsoft.AspNetCore.Mvc;
public class V01BaselineSafe {
  public object Run(string input) {
    var host = new Uri(input, UriKind.RelativeOrAbsolute).Host;
        return host == "app.example.com" ? Redirect(input) : Redirect("/home");
  }
}
