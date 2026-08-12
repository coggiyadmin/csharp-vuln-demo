using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class FanoutXssTp {
  public void Run(string input) {
    var a = input; var b = a;
    var s = "<div>" + b + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
