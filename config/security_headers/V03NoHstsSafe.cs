using Microsoft.AspNetCore.Builder;
public static class V03NoHstsSafe {
  public static void Configure(WebApplication app) {
    app.UseHsts();
  }
}
