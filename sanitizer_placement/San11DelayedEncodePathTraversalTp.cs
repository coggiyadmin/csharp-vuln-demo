using System.IO;
public class San11DelayedEncodePathTraversalTp {
  public string Run(string input) {
    var full = "/data/" + input;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
