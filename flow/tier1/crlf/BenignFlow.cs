using Microsoft.AspNetCore.Http;
public class BenignFlow {
  public void Run() {
    Response.Headers.Add("X-Trace", "static");
  }
}
