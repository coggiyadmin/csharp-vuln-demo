using Microsoft.AspNetCore.Builder;
using System.Data.SqlClient;
// profile=app — request entrypoints matter
public static class AppHostedApi {
  public static void Map(WebApplication app) {
    app.MapGet("/u", (string id) => {
      var q = "SELECT * FROM u WHERE id=" + id;
      var cmd = new SqlCommand(q, null);
      return Results.Ok();
    });
  }
}
