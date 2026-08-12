using System.IO;
public class Prp13CapturedClosurePathTraversalTp {
  public string Run(string input) {
    System.Func<string> get = () => input;
    var v = get();
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
