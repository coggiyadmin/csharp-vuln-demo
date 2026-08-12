using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class V02Safe {
  public object Run(string input) {
    return Html.Raw(HttpUtility.HtmlEncode(input));
  }
}
