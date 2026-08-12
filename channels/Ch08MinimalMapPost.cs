using Microsoft.AspNetCore.Builder;
using System.Data.SqlClient;
public static class Ch08MinimalMapPost {
  public static void Map(WebApplication app) {
    app.MapPost("/u", (UserBody b) => {
      var q = "SELECT * FROM u WHERE id=" + b.Id;
      var cmd = new SqlCommand(q, null); // SINK CWE-89
      return Results.Ok();
    });
  }
}
public record UserBody(string Id);
