using System.IO;
public class San07CalleePathTraversalTp {
  static string Pass(string s) => s;
  public object Run(string input) {
    var v = Pass(input);
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
