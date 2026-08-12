using Microsoft.AspNetCore.Http;
public class V30ForwardedHeaderTp {
  public string Run(HttpRequest req) => req.Headers["X-Forwarded-User"]; // trust client header
}
