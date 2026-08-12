using System.Web;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
public class AsyncXssTp {
  public async Task Run(string input) {
    var v = await Task.FromResult(input);
    var s = "<div>" + v + "</div>";
        return Html.Raw(s); // SINK CWE-79
  }
}
