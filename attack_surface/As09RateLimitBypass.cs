using Microsoft.AspNetCore.Http;
public class As09RateLimitBypass {
  public string ClientIp(HttpRequest req) => req.Headers["X-Forwarded-For"]; // spoofable
}
