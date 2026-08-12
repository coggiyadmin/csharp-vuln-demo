using System.IO;
public class San07CalleePathTraversalSafe {
  static string Read(string p) {
    var v = System.IO.Path.GetFileName(p);
    return File.ReadAllText(System.IO.Path.Combine("/data", v));
  }
  public string Run(string input) => Read(input);
}
