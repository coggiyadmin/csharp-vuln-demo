using Microsoft.AspNetCore.Components;
public class BlazorMarkupXssTp {
  public MarkupString Run(string html) {
    var wrapped = "<section>" + html + "</section>";
    return (MarkupString)wrapped; // SINK CWE-79
  }
}
