using Microsoft.AspNetCore.Http;
public class FanoutCrlfTp {
  public void Run(string input, HttpResponse res) {
    var a = input; var b = a; var v = b + b;
    res.Headers["X-User"] = v; // SINK
  }
}
