using System.IO;
public class Prp09TuplePathTraversalTp {
  public string Run(string input) {
    var tup = (input, 1);
    var v = tup.Item1;
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
