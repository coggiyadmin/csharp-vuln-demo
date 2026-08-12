using Microsoft.AspNetCore.Http;
public class PathSensitiveCrlfTp {
  public void Run(string input, HttpResponse res) {
    string v;
    if (input.Length > 0) v = input; else v = "x";
    res.Headers["X-User"] = v; // SINK
  }
}
