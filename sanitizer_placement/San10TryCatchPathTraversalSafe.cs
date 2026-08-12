using System.IO;
public class San10TryCatchPathTraversalSafe {
  public string Run(string input) {
    try {
      var v = System.IO.Path.GetFileName(input);
      return File.ReadAllText(System.IO.Path.Combine("/data", v));
    } catch { return ""; }

  }
}
