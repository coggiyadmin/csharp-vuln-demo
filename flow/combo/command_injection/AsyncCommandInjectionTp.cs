using System.Diagnostics;
public class AsyncCommandInjectionTp {
  public async Task Run(string input) {
    var v = await Task.FromResult(input);
    var full = "sh -c " + v;
        Process.Start(full); // SINK CWE-78
  }
}
