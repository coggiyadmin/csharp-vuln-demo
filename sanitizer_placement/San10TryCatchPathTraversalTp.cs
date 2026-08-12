using System.IO;
public class San10TryCatchPathTraversalTp {
  public string Run(string input) {
    try {
      var full = "/data/" + input;
    return File.ReadAllText(full); // SINK CWE-22
    } catch { }

  }
}
