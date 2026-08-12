using Microsoft.AspNetCore.Http;
public class AsyncCrlfTp {
  public async System.Threading.Tasks.Task Run(string input, HttpResponse res) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    res.Headers["X-User"] = v; // SINK
  }
}
