using Microsoft.AspNetCore.Http;
using System.Data.SqlClient;
public class As03Middleware {
  readonly RequestDelegate _next;
  public As03Middleware(RequestDelegate next) => _next = next;
  public async System.Threading.Tasks.Task Invoke(HttpContext ctx) {
    var id = ctx.Request.Query["id"];
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, conn); // SINK CWE-89
    await _next(ctx);
  }
}
