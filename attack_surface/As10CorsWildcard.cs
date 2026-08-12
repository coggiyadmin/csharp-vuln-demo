using Microsoft.AspNetCore.Builder;
public static class As10CorsWildcard {
  public static void Configure(WebApplication app) {
    app.UseCors(b => b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
  }
}
