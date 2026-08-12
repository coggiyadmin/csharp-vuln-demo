using Microsoft.AspNetCore.Builder;
public static class SafeMinimalHealth {
  public static void Map(WebApplication app) => app.MapGet("/health", () => Results.Ok("ok"));
}
