using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class EncodedXssTp {
  public void Run(string input) {
    var v = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
    var s = "<div>" + v + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
