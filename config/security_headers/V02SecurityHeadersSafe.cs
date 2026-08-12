using Microsoft.AspNetCore.Builder;
public static class V02SecurityHeadersSafe {
  public static void Configure(WebApplication app) {
    app.Use(async (ctx, next) => {
      ctx.Response.Headers["X-Content-Type-Options"] = "nosniff";
      ctx.Response.Headers["X-Frame-Options"] = "DENY";
      await next();
    });
  }
}
