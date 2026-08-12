using System.IO;
public class V02Safe {
  public void Run(string input) {
    var name = Path.GetFileName(input);
        var full = Path.Combine("/data", name);
        var txt = File.ReadAllText(full);
  }
}
