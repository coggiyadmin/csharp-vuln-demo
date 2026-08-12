using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class WrongSanXssTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong sanitizer
    var s = "<div>" + v + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
