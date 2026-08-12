using Microsoft.AspNetCore.Builder;
using System.Diagnostics;
public static class As02MinimalEverywhere {
  public static void Map(WebApplication app) {
    app.MapGet("/run", (string cmd) => {
      var full = "sh -c " + cmd;
      Process.Start(full);
      return Results.Ok();
    });
  }
}
