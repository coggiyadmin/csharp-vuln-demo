using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class PathSensitiveXssTp {
  public void Run(string input) {
    string v = input;
    if (input.Length > 0) v = input;
    var s = "<div>" + v + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
