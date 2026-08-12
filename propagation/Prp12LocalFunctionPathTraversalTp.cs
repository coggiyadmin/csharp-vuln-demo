using System.IO;
public class Prp12LocalFunctionPathTraversalTp {
  public string Run(string input) {
    string Wrap(string s) => s;
    var v = Wrap(input);
    var full = "/data/" + v;
    return File.ReadAllText(full); // SINK CWE-22
  }
}
