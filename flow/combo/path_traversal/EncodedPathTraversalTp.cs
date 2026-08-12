using System.IO;
public class EncodedPathTraversalTp {
  public void Run(string input) {
    var v = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(input));
    var full = "/data/" + v;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
