using Microsoft.AspNetCore.Components;
public class Ch15BlazorServerCircuit {
  public MarkupString Render(string html) => (MarkupString)html; // SINK
}
