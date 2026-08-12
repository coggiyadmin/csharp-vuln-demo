using System.IO;
public class LoopPathTraversalTp {
  public void Run(string input) {
    var acc = "";
    foreach (var ch in input) acc += ch; // loop-carried
    var full = "/data/" + acc;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
