using System.IO;
public class PathSensitivePathTraversalTp {
  public void Run(string input) {
    string v = input;
    if (input.Length > 0) v = input;
    var full = "/data/" + v;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
