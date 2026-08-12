using System.IO;
public class San03AliasHopPathTraversalTp {
  public string Run(string input) {
    var a = input;
    var b = a;
    var v = b;
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
