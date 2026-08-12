using Microsoft.AspNetCore.Http;
public class V03Benign {
  public void Run() {
    Response.Headers.Add("X-Trace", "static");
  }
}
