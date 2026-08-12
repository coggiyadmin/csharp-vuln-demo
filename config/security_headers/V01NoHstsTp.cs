using Microsoft.AspNetCore.Builder;
public static class V01NoHstsTp {
  public static void Configure(WebApplication app) {
    // deliberately no UseHsts / UseHttpsRedirection
    app.MapGet("/", () => "ok");
  }
}
