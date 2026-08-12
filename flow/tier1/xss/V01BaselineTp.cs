using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class V01BaselineTp {
  public object Run(string input) {
    var s = "<div>" + input + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
