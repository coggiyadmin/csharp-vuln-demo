using Microsoft.AspNetCore.Http;
public class LoopCrlfTp {
  public void Run(string input, HttpResponse res) {
    var v = input;
    for (int i = 0; i < 1; i++) v = v;
    res.Headers["X-User"] = v; // SINK
  }
}
