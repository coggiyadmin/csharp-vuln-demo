using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class WrongXssTp {
  public void Run(string q) {
    var v = q.Replace(";", ""); // wrong sanitizer
    var s = "<div>" + v + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
