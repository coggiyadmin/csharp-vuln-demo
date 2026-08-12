using System.IO;
public class San06ChainPathTraversalTp {
  public string Run(string input) {
    var v = input.Trim().ToLowerInvariant();
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
