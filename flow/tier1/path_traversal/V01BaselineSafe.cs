using System.IO;
public class V01BaselineSafe {
  public void Run(string input) {
    var name = Path.GetFileName(input);
        var full = Path.Combine("/data", name);
        var txt = File.ReadAllText(full);
  }
}
