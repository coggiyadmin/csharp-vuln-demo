using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class OopXssTp {
  class Holder { public string V; public Holder(string v) { V = v; } }
  public void Run(string input) {
    var h = new Holder(input);
    var s = "<div>" + h.V + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
