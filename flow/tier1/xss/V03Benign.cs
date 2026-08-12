using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class V03Benign {
  public object Run() {
    return Html.Raw("<div>static</div>");
  }
}
