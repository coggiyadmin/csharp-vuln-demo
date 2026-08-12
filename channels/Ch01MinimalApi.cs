using Microsoft.AspNetCore.Builder;
using System.Data.SqlClient;
/** channel — Minimal API query → SQLi. */
public static class Ch01MinimalApi {
  public static void Map(WebApplication app) {
    app.MapGet("/u", (string id) => {
      var q = "SELECT * FROM u WHERE id=" + id;
      var cmd = new SqlCommand(q, null); // SINK CWE-89
      return Results.Ok();
    });
  }
}
