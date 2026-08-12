using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class BenignFlow {
  public object Run() {
    return Html.Raw("<div>static</div>");
  }
}
