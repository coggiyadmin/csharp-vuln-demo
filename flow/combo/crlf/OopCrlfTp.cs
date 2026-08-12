using Microsoft.AspNetCore.Http;
public class OopCrlfTp {
  class Holder { public string V; public Holder(string x) { V = x; } }
  public void Run(string input, HttpResponse res) {
    var h = new Holder(input);
    var v = h.V;
    res.Headers["X-User"] = v; // SINK
  }
}
