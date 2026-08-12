using Microsoft.AspNetCore.Http;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var h = "X-Trace: " + v;
            Response.Headers.Add("X-Trace", v); // SINK CWE-113
  }
}
