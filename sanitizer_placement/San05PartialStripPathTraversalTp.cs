using System.IO;
public class San05PartialStripPathTraversalTp {
  public string Run(string input) {
    var v = input.Replace(";", "");
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
