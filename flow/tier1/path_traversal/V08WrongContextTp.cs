using System.IO;
public class V08WrongContextTp {
  public void Run(string input) {
    var v = input.Replace(";", "");
        var full = "/data/" + v;
            var txt = File.ReadAllText(full); // SINK CWE-22
  }
}
