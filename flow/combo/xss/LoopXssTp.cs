using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class LoopXssTp {
  public void Run(string input) {
    var acc = "";
    foreach (var ch in input) acc += ch; // loop-carried
    var s = "<div>" + acc + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
