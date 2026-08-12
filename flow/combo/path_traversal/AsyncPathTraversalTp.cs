using System.IO;
public class AsyncPathTraversalTp {
  public async Task Run(string input) {
    var v = await Task.FromResult(input);
    var full = "/data/" + v;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
