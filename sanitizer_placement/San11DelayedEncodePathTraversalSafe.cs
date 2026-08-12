using System.IO;
public class San11DelayedEncodePathTraversalSafe {
  public string Run(string input) {
    var v = System.IO.Path.GetFileName(input);
    return File.ReadAllText(System.IO.Path.Combine("/data", v));
  }
}
