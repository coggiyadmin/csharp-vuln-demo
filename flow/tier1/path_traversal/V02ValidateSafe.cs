using System.IO;
public class V02ValidateSafe {
  public string Run(string input) {
    if (input.Contains("..")) return "";
    var v = System.IO.Path.GetFileName(input);
    return File.ReadAllText(System.IO.Path.Combine("/data", v));
  }
}
