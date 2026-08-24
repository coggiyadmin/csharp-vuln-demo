// SAFE — xss variant: Blazor renders the value as text, never as a MarkupString.
using Microsoft.AspNetCore.Components;
public class V50BlazorEncodeSafe {
  public RenderFragment Run(string html) => builder => {
    builder.OpenElement(0, "div");
    builder.AddContent(1, html);
    builder.CloseElement();
  };
}
