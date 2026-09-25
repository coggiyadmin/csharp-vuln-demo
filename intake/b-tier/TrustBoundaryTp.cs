using Microsoft.AspNetCore.Http;
public class TrustBoundaryTp {
  public void Run(HttpRequest req) {
    var role = req.Headers["X-User-Role"]; // SINK CWE-501 — trust boundary violation: client header drives a trusted decision
    System.Console.WriteLine("role=" + role);
  }
}
