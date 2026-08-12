using Microsoft.AspNetCore.Builder;
public static class V01HstsSafe {
  public static void Configure(WebApplication app) {
    app.UseHsts();
    app.UseHttpsRedirection();
    app.MapGet("/", () => "ok");
  }
}
