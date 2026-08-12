using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class V08WrongContextTp {
  public object Run(string input) {
    var v = input.Replace(";", "");
        var s = "<div>" + v + "</div>";
            return Html.Raw(s); // SINK CWE-79
  }
}
