using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class V01BaselineSafe {
  public object Run(string input) {
    return Html.Raw(HttpUtility.HtmlEncode(input));
  }
}
