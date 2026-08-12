using Microsoft.AspNetCore.Builder;
public static class V03NoHstsTp {
  public static void Configure(WebApplication app) {
    // intentionally no UseHsts
    app.Run();
  }
}
