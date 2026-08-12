using Microsoft.AspNetCore.Components;
public partial class Ch05BlazorComponent : ComponentBase {
  [Parameter] public string UserHtml { get; set; }
  protected MarkupString Render() {
    var s = "<div>" + UserHtml + "</div>";
    return (MarkupString)s; // SINK CWE-79
  }
}
