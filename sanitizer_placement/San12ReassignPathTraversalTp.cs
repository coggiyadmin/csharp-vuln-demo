using System.IO;
public class San12ReassignPathTraversalTp {
  public string Run(string input) {
    var v = "safe";
    v = input; // reassign drops sanitize
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
