using Microsoft.AspNetCore.Http;
public class V01BaselineTp {
  public void Run(string input) {
    var h = "X-Trace: " + input;
        Response.Headers.Add("X-Trace", input); // SINK CWE-113
  }
}
