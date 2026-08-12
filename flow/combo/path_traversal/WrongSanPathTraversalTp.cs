using System.IO;
public class WrongSanPathTraversalTp {
  public void Run(string input) {
    var v = input.Replace(";", ""); // wrong sanitizer
    var full = "/data/" + v;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
