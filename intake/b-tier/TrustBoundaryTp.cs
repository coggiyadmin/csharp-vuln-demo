using Microsoft.AspNetCore.Http;
public class TrustBoundaryTp {
  public void Run(HttpRequest req) {
    var role = req.Headers["X-User-Role"]; // trusted decision from client header
    System.Console.WriteLine("role=" + role);
  }
}
