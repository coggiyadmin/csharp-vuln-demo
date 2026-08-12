using System.IO;
public class San06ChainPathTraversalSafe {
  public string Run(string input) {
    var v = System.IO.Path.GetFileName(input.Trim());
    return File.ReadAllText(System.IO.Path.Combine("/data", v));
  }
}
