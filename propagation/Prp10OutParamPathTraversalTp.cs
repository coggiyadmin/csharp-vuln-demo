using System.IO;
public class Prp10OutParamPathTraversalTp {
  static void Box(string i, out string o) { o = i; }
  public string Run(string input) {
    Box(input, out var v);
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
