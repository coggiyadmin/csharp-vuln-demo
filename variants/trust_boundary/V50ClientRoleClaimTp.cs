using Microsoft.AspNetCore.Http;
public class V50ClientRoleClaimTp {
  public string Run(HttpRequest req) => req.Headers["X-Role"]; // trust client role
}
