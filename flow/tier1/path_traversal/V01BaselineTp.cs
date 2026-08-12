using System.IO;
public class V01BaselineTp {
  public void Run(string input) {
    var full = "/data/" + input;
        var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
