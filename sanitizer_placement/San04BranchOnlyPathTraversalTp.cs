using System.IO;
public class San04BranchOnlyPathTraversalTp {
  public string Run(string input) {
    if (input.Length > 0) { /* no real sanitize */ }
    var full = "/data/" + input;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
