using System.IO;
public class FanoutPathTraversalTp {
  public void Run(string input) {
    var a = input; var b = a;
    var full = "/data/" + b;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
