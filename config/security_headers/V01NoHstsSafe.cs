using Microsoft.AspNetCore.Builder;
public static class V01NoHstsSafe {
  public static void Configure(WebApplication app) {
    app.UseHsts();
  }
}
