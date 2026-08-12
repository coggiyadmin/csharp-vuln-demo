using Microsoft.AspNetCore.Http; using Microsoft.Extensions.Logging; using System.Threading.Tasks;
public class As19Middleware {
  readonly RequestDelegate _next; readonly ILogger _log;
  public As19Middleware(RequestDelegate next, ILogger log) { _next = next; _log = log; }
  public async Task Invoke(HttpContext ctx) {
    _log.LogInformation("path=" + ctx.Request.Path); // SINK CWE-117
    await _next(ctx);
  }
}
