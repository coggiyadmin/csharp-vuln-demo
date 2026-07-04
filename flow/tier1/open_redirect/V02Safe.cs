public class V02Safe {
  public string Run(string next) {
    var host = new Uri(next, UriKind.RelativeOrAbsolute).Host;
    return host == "app.example.com" ? "Location: " + next : "Location: /home";
  }
}
