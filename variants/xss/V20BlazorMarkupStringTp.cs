using Microsoft.AspNetCore.Components;
public class V20BlazorMarkupStringTp {
  public MarkupString Run(string user) {
    var s = "<div>" + user + "</div>";
    return (MarkupString)s; // SINK CWE-79 Blazor
  }
}
