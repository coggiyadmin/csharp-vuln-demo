using Microsoft.AspNetCore.Components;
public class MauiBlazorHybrid {
  public MarkupString Render(string html) => (MarkupString)html; // SINK hybrid UI
}
