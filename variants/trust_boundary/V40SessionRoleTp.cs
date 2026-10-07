using Microsoft.AspNetCore.Http;
public class V40SessionRoleTp {
  public void Run(HttpContext ctx, string role) {
    ctx.Session.SetString("role", role); // SINK CWE-501
  }
}
