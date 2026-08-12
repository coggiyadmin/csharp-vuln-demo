using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class CorrectXssSafe {
  public void Run(string q) {
    return Html.Raw(HttpUtility.HtmlEncode(q));
  }
}
