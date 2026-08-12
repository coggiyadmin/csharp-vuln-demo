using Microsoft.AspNetCore.Mvc;
public class AsyncOpenRedirectTp {
  public async System.Threading.Tasks.Task<IActionResult> Run(string input) {
    var v = await System.Threading.Tasks.Task.FromResult(input);
    return new RedirectResult(v); // SINK
  }
}
