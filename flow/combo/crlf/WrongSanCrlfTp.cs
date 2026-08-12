using Microsoft.AspNetCore.Http;
public class WrongSanCrlfTp {
  public void Run(string input, HttpResponse res) {
    var v = input.Replace(";", ""); // wrong/partial
    res.Headers["X-User"] = v; // SINK
  }
}
