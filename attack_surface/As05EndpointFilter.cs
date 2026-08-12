using Microsoft.AspNetCore.Http; using System.Data.SqlClient;
public class As05EndpointFilter : IEndpointFilter {
  public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext ctx, EndpointFilterDelegate next) {
    var id = ctx.HttpContext.Request.Query["id"].ToString();
    var q = "SELECT * FROM u WHERE id=" + id;
    var cmd = new SqlCommand(q, null);
    return await next(ctx);
  }
}
