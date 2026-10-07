using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class FakeSanXssTp {
  static string Sanitize(string s) => s;
  public async System.Threading.Tasks.Task Run(string input) {
    var v = Sanitize(input); // fake sanitizer — identity
    return Html.Raw("<div>" + v + "</div>"); // SINK CWE-79
  }
}
